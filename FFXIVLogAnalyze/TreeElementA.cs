using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace FFXIV_Tools
{
    public class TreeElementA
    {

        public List<string> RowLabels = new List<string>();
        public List<string> Expressions = new List<string>();
        public List<string> Filters = new List<string>();

        public ReportData report = new ReportData();


        //高速化用
        public FFXIVLogDataSet ds = new FFXIVLogDataSet();

        public List<TreeElementA> ChildElements = new List<TreeElementA>();
        public DataTable DataTable;
        public DataRow CurrentRow;
        public TreeElementA Parent;
        public int AddColumn()
        {
            int num = DataTable.Columns.Count;
            DataTable.Columns.Add(String.Format("data{0}", num - 3));
            return num;
        }

        /// <summary>
        /// コンスタント
        /// </summary>
        public TreeElementA()
        {

            //高速化

            DataTable = new DataTable();

            InitializeTable();

            CurrentRow =  DataTable.NewRow();
            CurrentRow["Name"] = "root";
            DataTable.Rows.Add(CurrentRow);
        }

        private TreeElementA(TreeElementA parent, string text, string label)
        {
            this.Text = text;
            this.Label = label;

            //高速化
            string filter = GetFilter();
            foreach (FFXIVLogDataSet.AnaylzedRow row in parent.ds.Anaylzed.Select(filter))
            {
                FFXIVLogDataSet.AnaylzedRow _row = ds.Anaylzed.NewAnaylzedRow();
                _row.ItemArray = row.ItemArray;
                ds.Anaylzed.AddAnaylzedRow(_row);
            }


            Parent = parent;
            DataTable = parent.DataTable;
            CurrentRow = DataTable.NewRow();
            DataTable.Rows.Add(CurrentRow);
            CurrentRow["ParentID"] = parent.CurrentRow["ID"];
        }


        public int Depth
        {
            get
            {
                TreeElementA parent = this.Parent;
                int depth = 0;
                while (parent != null)
                {
                    depth++;
                    parent = parent.Parent;
                }
                return depth;
            }
        }


        private void InitializeTable()
        {
            DataColumn col0 = DataTable.Columns.Add("ID",typeof(decimal));//0
            col0.AutoIncrement = true;
            col0.AutoIncrementSeed = 0;
            col0.AutoIncrementStep = 1;
            DataColumn col1 = DataTable.Columns.Add("ParentID",typeof(decimal));//1
            DataColumn col2 = DataTable.Columns.Add("Name", typeof(string));//2
//          DataTable.ChildRelations.Add("ParentChild", col0, col1);
        }

        public TreeElementA AddChild(string text, string label)
        {
            TreeElementA child = new TreeElementA(this, text, label);
            child.Expressions = this.Expressions;
            child.RowLabels = this.RowLabels;
            ChildElements.Add(child);
            return child;
        }

        public string Label
        {
            get;
            set;
        }

        public string Text
        {
            get;
            set;
        }

        string _ViewText;

        public string ViewText
        {
            get
            {
                if (String.IsNullOrEmpty(_ViewText))
                {
                    return Text;
                }
                return _ViewText;
            }
            set
            {
                _ViewText = value;
            }
        }

        public override string ToString()
        {
            return ViewText;
        }

        public string GetFilter()
        {
            if (ds.Anaylzed.Columns[this.Label] == null)
                return "";

            if (ds.Anaylzed.Columns[this.Label].DataType == typeof(string))
            {
                return (String.Format("{0} = '{1}'", this.Label,this.Text.Replace("'","''")));
            }
            else
            {
                return (String.Format("{0} = {1}", this.Label, this.Text));
            }
        }


        public void Calc()
        {

            //DDValue
            object o = ds.Anaylzed.Compute("Sum(Numeric)", "IsDamage = true and IsHP = true");
            if (o != DBNull.Value)
            {
                report.DDValue = Convert.ToInt32(o);
            }

            //DotValue

            object dot = ds.Anaylzed.Compute("Sum(DotDamage)", "");
            if (dot != DBNull.Value)
            {
                report.DotValue = Convert.ToInt32(dot);
            }

            //TotalHeal
            object oh = ds.Anaylzed.Compute("Sum(Numeric)", "IsCure = true and IsHP = true");
            if (oh != DBNull.Value)
            {
                report.TotalCure = Convert.ToInt32(oh);
            }
            //発動 Count
            object cc = ds.Anaylzed.Compute("Count(from)",String.Format("IsDone = true or ActionName = '攻撃' "));
            if (cc != DBNull.Value)
            {
                report.Count = Convert.ToInt32(cc);
            }
            //Hit Count
            object c = ds.Anaylzed.Compute("Count(Numeric)","");
            if (c != DBNull.Value)
            {
                report.Hit = Convert.ToInt32(c);
            }
            //Miss
            object miss = ds.Anaylzed.Compute("Count(From)", "IsDodge = true");
            if (miss != DBNull.Value)
            {
                report.Miss = Convert.ToInt32(miss);
            }
            //Max
            object mx = ds.Anaylzed.Compute("Max(Numeric)", "");
            if (mx != DBNull.Value)
            {
                report.Max = Convert.ToInt32(mx);
            }
            //Min
            object min = ds.Anaylzed.Compute("Min(Numeric)", "");
            if (min != DBNull.Value)
            {
                report.Min = Convert.ToInt32(min);
            }
            //CriticalHit
            object critcount = ds.Anaylzed.Compute("Count(Numeric)", "IsCritical = true");
            if (critcount != DBNull.Value)
            {
                report.CritHit = Convert.ToInt32(critcount);
            }

            //Start
            object st = ds.Anaylzed.Compute("Min(TotalSeconds)", "");
            if (st != DBNull.Value)
            {
                report.Start = Convert.ToInt32(st);
            }
            //End
            object ed = ds.Anaylzed.Compute("Max(TotalSeconds)", "");
            if (ed != DBNull.Value)
            {
                report.End = Convert.ToInt32(ed);
            }


            foreach (TreeElementA child in ChildElements)
            {
                child.Calc();
            }
        }

        /// <summary>
        /// 子をTotalでソートする
        /// </summary>
        /// <param name="ASC">昇順</param>
        public void SortByTotal(bool asc)
        {
            if (asc)
            {
                ChildElements.Sort((a, b) => a.report.TotalDamage - b.report.TotalDamage);
            }
            else
            {
                ChildElements.Sort((a, b) => b.report.TotalDamage - a.report.TotalDamage);
            }
            foreach (TreeElementA child in ChildElements)
            {
                child.SortByTotal(asc);
            }
        }

        /// <summary>
        /// 子をTotalでソートする
        /// </summary>
        /// <param name="ASC">昇順</param>
        public void SortByCount(bool asc)
        {
            if (asc)
            {
                ChildElements.Sort((a, b) => a.report.Count - b.report.Count);
            }
            else
            {
                ChildElements.Sort((a, b) => b.report.Count - a.report.Count);
            }
            foreach (TreeElementA child in ChildElements)
            {
                child.SortByCount(asc);
            }
        }


        /// <summary>
        /// 子をDPSでソートする
        /// </summary>
        /// <param name="ASC">昇順</param>
        public void SortByDPS(bool asc)
        {
            if (asc)
            {
                ChildElements.Sort((a, b) => a.report.Dps.CompareTo(b.report.Dps));
            }
            else
            {
                ChildElements.Sort((a, b) => b.report.Dps.CompareTo(a.report.Dps));
            }
            foreach (TreeElementA child in ChildElements)
            {
                child.SortByDPS(asc);
            }
        }

        public void SortByName(string[]names)
        {
            List<string> nameList = new List<string>();
            nameList.AddRange(names);

            ChildElements.Sort((a, b) => nameList.IndexOf(a.Text) - nameList.IndexOf(b.Text));
        }

    }
}
