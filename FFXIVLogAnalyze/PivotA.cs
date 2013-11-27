using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FFXIV_Tools
{
    public class PivotA
    {
        public TreeElementA Tree;
        public List<string> RowLabels;
        public List<string> Expressions;
        public List<string> Filters;

        FFXIVLogDataSet ds = new FFXIVLogDataSet();

        public PivotA(FFXIVLogDataSet.AnaylzedRow[] rows)
        {
            foreach (FFXIVLogDataSet.AnaylzedRow row in rows)
            {
                DataRow newrow = ds.Anaylzed.NewRow();
                newrow.ItemArray = row.ItemArray;
                ds.Anaylzed.AddAnaylzedRow((FFXIVLogDataSet.AnaylzedRow) newrow);
            }

            Tree = new TreeElementA();
            Tree.ds = ds;

            RowLabels = new List<string>();
            Filters = new List<string>();
            Expressions = new List<string>();

            RowLabels.Add("From");
            RowLabels.Add("ActionName");
            RowLabels.Add("To");

            //Expressions.Add("Sum(Numeric)");
            //Expressions.Add("Count(Numeric)");
            //Expressions.Add("Avg(Numeric)");
            //Expressions.Add("Max(Numeric)");
            //Expressions.Add("Min(Numeric)");
            //Expressions.Add("Min(TotalSeconds)");
            //Expressions.Add("Max(TotalSeconds)");

            //めちゃくちゃやねｗ
            Tree.RowLabels = RowLabels;
            Tree.Expressions = Expressions;
        }



        public void UpdateTree()
        {
            Tree.ChildElements.Clear();
            UpdateTree(Tree,RowLabels[0]);
        }

        /// <summary>
        /// フィルタ作成
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public string GetFilter(TreeElementA element)
        {
            List<string> filters = new List<string>();
            TreeElementA parent = element;
            while (parent.Parent != null)
            {
                if (ds.Anaylzed.Columns[parent.Label].DataType == typeof(string))
                {
                    filters.Add(String.Format("{0} = '{1}'", RowLabels[parent.Depth - 1], parent.Text.Replace("'","''")));
                }
                else
                {
                    filters.Add(String.Format("{0} = {1}", RowLabels[parent.Depth - 1], parent.Text));
                }
                parent = parent.Parent;
            }
            filters.AddRange(Filters.ToArray());
            return String.Join(" and ", filters.ToArray());
        }


        /// <summary>
        /// ツリーを更新する
        /// </summary>
        /// <param name="element"></param>
        /// <param name="label"></param>
        public void UpdateTree(TreeElementA element, string childElementLabel)
        {
            List<string> items = new List<string>();

            string filter = GetFilter(element);

            foreach (FFXIVLogDataSet.AnaylzedRow row in ds.Anaylzed.Select(filter))
            {
                string val = row[childElementLabel].ToString();
                if (val !="" && !items.Contains(val))
                {
                    TreeElementA child = element.AddChild(val, childElementLabel);
                    items.Add(val);
                }
            }

            foreach (TreeElementA child in element.ChildElements)
            {
                if (child.Depth < RowLabels.Count)
                {
                    UpdateTree(child,RowLabels[child.Depth]);
                }
            }

        }

        public void Calc()
        {
            Tree.Calc();
        }


        public void Calc(TreeElementA element)
        {
            element.Calc();
        }

    }
}
