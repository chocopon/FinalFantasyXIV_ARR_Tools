using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FFXIV_Tools;

namespace FF14FastReport
{
    /// <summary>
    /// 
    /// </summary>
    public class Report
    {

        int Span;

        FF14LogParser ar;

        public FF14FastReportDataSet FF14FastReportDS;

        public Report()
        {
            ar = new FF14LogParser();

            Span = 60;//60秒

            FF14FastReportDS = new FF14FastReportDataSet();
            Reset();

        }


        /// <summary>
        /// ログを追加する
        /// </summary>
        /// <param name="log"></param>
        public void Add(FFXIVLog log)
        {
            FFXIVLogDataSet.AnaylzedRow arow = ar.Add(log);

        }

        public void SetActionReport(FF14LogParser _ar)
        {
//            ar = new ActionReport();
            Reset();
            ar.ds.Merge((FFXIVLogDataSet)_ar.ds.Copy());
        }

        /// <summary>
        /// リセットする
        /// </summary>
        public void Reset()
        {
            FF14FastReportDS.Clear();
            ar.ds.Anaylzed.Clear();
            ar.ds.Actor.Clear();
            ar.ds.EnemyGroup.Clear();

            FF14FastReportDS.DPSReport.AddDPSReportRow("Party", -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }

          /// <summary>
        /// アクションの実行を追加する
        /// </summary>
        /// <param name="name"></param>
        /// <param name="action"></param>
        private FF14FastReportDataSet.ActionReportRow GetActionRow(string name, string action)
        {
            string name_action = name + "_" + action;
            FF14FastReportDataSet.ActionReportRow row = FF14FastReportDS.ActionReport.FindByName_Action(name_action);
            if (row == null)
            {//新規追加
                row = FF14FastReportDS.ActionReport.NewActionReportRow();
                row.Name_Action = name_action;
                row.Name = name;
                row.Action = action;
                FF14FastReportDS.ActionReport.AddActionReportRow(row);
            }
            return row;
        }

        private int GetDOtDamageTo(string To,int totalsecond, int startSeconds, string[] from)
        {
            int dot_a = 0;//終了済み
            int dot_b = 0;//未計算繰り入れ
            int dot_c = 0;//継続中

            string filter = "";
            if (from != null && from.Length> 0)
            {
                for(int i=0;i<from.Length;i++)
                {
                    from[i] = from[i].Replace("'","''");
                }
                filter = String.Format("and (from = '{0}')", String.Join("' or from ='", from));
            }

            List<FFXIVLogDataSet.AnaylzedRow> damagebasenull = new List<FFXIVLogDataSet.AnaylzedRow>();
            foreach (FFXIVLogDataSet.AnaylzedRow arow in ar.ds.Anaylzed.Select(String.Format("DotEndSeconds is null and IsDot = true and To = '{0}' and TotalSeconds > {1} {2}",To.Replace("'","''"),startSeconds,filter)))
            {
                if (arow.IsDamageBaseNull())
                {
                    damagebasenull.Add(arow);
                    continue;
                }
                //damagebaseのなかったDOTを処理して追加
                for (int i = damagebasenull.Count - 1; i >= 0; i--)
                {
                    damagebasenull[i].DamageBase = arow.DamageBase;
                    double _dot_b = arow.Dot_Iryoku * damagebasenull[i].DamageBase * Math.Min(arow.DotSecs, Math.Max(0, (totalsecond - arow.TotalSeconds))) / 3.0;
                    if (damagebasenull[i].IsDotEndSecondsNull())
                    {
                        dot_b += (int)_dot_b;
                    }
                    else
                    {//時間が確定したものは除外
                    }
                    damagebasenull.RemoveAt(i);
                }
                double _dot_c = arow.Dot_Iryoku * arow.DamageBase * Math.Min(arow.DotSecs, Math.Max(0, (totalsecond - arow.TotalSeconds))) / 3.0;
                dot_c += (int)_dot_c;
            }
            //効果時間が確定したもの
            object o = ar.ds.Anaylzed.Compute("Sum(DotDamage)", String.Format("To = '{0}' and TotalSeconds > {1} {2}", To.Replace("'", "''"),startSeconds,filter));
            if (o != DBNull.Value)
            {
                dot_a = Convert.ToInt32(o);

            }

            return dot_a + dot_b + dot_c;
        }

        private int GetDotDamage(string from, int totalsecond,int startSeconds)
        {
            int dot_a = 0;//終了済み
            int dot_b = 0;//未計算繰り入れ
            int dot_c = 0;//継続中

            List<FFXIVLogDataSet.AnaylzedRow> damagebasenull = new List<FFXIVLogDataSet.AnaylzedRow>();
            foreach (FFXIVLogDataSet.AnaylzedRow arow in ar.ds.Anaylzed.Select(String.Format("DotEndSeconds is null and IsDot = true and From = '{0}' and TotalSeconds > {1}",from.Replace("'","''"),startSeconds)))
            {
                if (arow.IsDamageBaseNull())
                {
                    damagebasenull.Add(arow);
                    continue;
                }
                //damagebaseのなかったDOTを処理して追加
                for (int i = damagebasenull.Count - 1; i >= 0; i--)
                {
                    damagebasenull[i].DamageBase = arow.DamageBase;
                    double _dot_b = arow.Dot_Iryoku * damagebasenull[i].DamageBase * Math.Min(arow.DotSecs, Math.Max(0, (totalsecond - arow.TotalSeconds))) / 3.0;
                    if (damagebasenull[i].IsDotEndSecondsNull())
                    {
                        dot_b += (int)_dot_b;
                    }
                    else
                    {//時間が確定したものは除外
                    }
                    damagebasenull.RemoveAt(i);
                }
                double _dot_c =　　 arow.Dot_Iryoku * arow.DamageBase　　　　　　　 * Math.Min(arow.DotSecs, Math.Max(0, (totalsecond - arow.TotalSeconds))) / 3.0;
                dot_c += (int)_dot_c;
            }
            //効果時間が確定したもの
            object o = ar.ds.Anaylzed.Compute("Sum(DotDamage)", String.Format("From = '{0}' and TotalSeconds > {1}", from.Replace("'", "''"),startSeconds));
            if (o != DBNull.Value)
            {
                dot_a = Convert.ToInt32(o);

            }

            return dot_a + dot_b+dot_c;
        }


   

        public void UpdateDamage(DateTime JST)
        {
            int totalSeconds = FFXIVLog.GetTotalSecond(new DateTime(JST.Year, JST.Month, JST.Day, JST.Hour, JST.Minute, JST.Second),true);


            int ptDD = 0;
            int ptDot = 0;
            float ptAtkTotal = 0;
            float ptAtkHit = 0;
            int ptMax = 0;
            int ptMin = 0;
            int ptStart = 0;
            int ptEnd = 0;


            //DPS用
            float ptTotalSpanDmg = 0;
            float ptDotSpanDmg =0;


            List<string> PtAndMe = new List<string>();

            //更新されたDPSROW
            List<FF14FastReportDataSet.DPSReportRow> viewdpsList = new List<FF14FastReportDataSet.DPSReportRow>();

            foreach (FFXIVLogDataSet.ActorRow actor in ar.ds.Actor.Select("IsMe = true or IsMyPet = true or IsPTMember = true or IsPTPet = true"))
            {
                PtAndMe.Add(actor.Name);
            }


            foreach (FFXIVLogDataSet.ActorRow actor in ar.ds.Actor.Select(String.Format("IsMe = true or IsMyPet = true or IsPTMember = true or IsPTPet = true or (IsNPC = true and LastSeconds > {0})", totalSeconds - 300)))
            {
                FF14FastReportDataSet.DPSReportRow dps = FF14FastReportDS.DPSReport.FindByName(actor.Name);
                if (dps == null)
                {
                    dps = FF14FastReportDS.DPSReport.NewDPSReportRow();
                    dps.Name = actor.Name;

                    if (actor.IsMe || actor.IsMyPet)
                    {
                        dps.Category = 0;
                    }
                    else if (actor.IsPTMember || actor.IsPTPet)
                    {
                        if (actor.Name.Contains("ホルス"))
                        {
                        }
                        dps.Category = 1;
                    }
                    else if (actor.IsNPC)
                    {
                        if (ar.ds.EnemyGroup.FindByName(actor.Name) != null)
                        {
                            dps.Category = 2;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        dps.Category = 3;
                        continue;
                    }
                    FF14FastReportDS.DPSReport.AddDPSReportRow(dps);
                }
                string ptfilter = "";
                string FromOrTO = "From";

                            string PTFilter = "";
            if (PtAndMe.Count > 0)
            {
                string[] froms = new string[PtAndMe.Count];
                for (int i = 0; i < PtAndMe.Count; i++)
                {
                    froms[i] = PtAndMe[i].Replace("'", "''");
                   
                }
                PTFilter = String.Format("and (From = '{0}')", String.Join("' or From = '", froms));
            }

                if (dps.Category > 1)
                {
                    FromOrTO = "To";
                    ptfilter = PTFilter;
                }


                //DDValue
                object o = ar.ds.Anaylzed.Compute("Sum(Numeric)", String.Format("IsDamage = true and IsHP = true and {1} = '{0}' {2}",dps.Name.Replace("'","''"),FromOrTO,ptfilter));
                if (o != DBNull.Value)
                {
                    dps.DDValue = Convert.ToInt32(o);
                }

                ////DotValue

                if (FromOrTO == "From")
                {
                    dps.DotValue = GetDotDamage(dps.Name, totalSeconds, 0);
                }
                else
                {
                    dps.DotValue = GetDOtDamageTo(dps.Name, totalSeconds, 0,PtAndMe.ToArray());
                }


                //Hit Count
                object c = ar.ds.Anaylzed.Compute("Count(Numeric)", String.Format("{1} = '{0}' {2}", dps.Name.Replace("'", "''"), FromOrTO,ptfilter));
                if (c != DBNull.Value)
                {
                    dps.AtkHit = Convert.ToInt32(c);
                    dps.AtkTotal = Convert.ToInt32(c);
                }
                //Miss
                object miss = ar.ds.Anaylzed.Compute("Count(From)", String.Format("IsDodge = true and {1} = '{0}' {2}", dps.Name.Replace("'", "''"), FromOrTO,ptfilter));
                if (miss != DBNull.Value)
                {
                    dps.AtkTotal += Convert.ToInt32(miss);
                }
                //Max
                object mx = ar.ds.Anaylzed.Compute("Max(Numeric)", String.Format("{1} = '{0}' {2}", dps.Name.Replace("'", "''"), FromOrTO,ptfilter));
                if (mx != DBNull.Value)
                {
                    dps.MaxDmg = Convert.ToInt32(mx);
                }
                //Min
                object min = ar.ds.Anaylzed.Compute("Min(Numeric)", String.Format("{1} = '{0}' {2}", dps.Name.Replace("'", "''"), FromOrTO,ptfilter));
                if (min != DBNull.Value)
                {
                    dps.MinDmg = Convert.ToInt32(min);
                }
                //Start
                object st = ar.ds.Anaylzed.Compute("Min(TotalSeconds)", String.Format("{1} = '{0}' {2}", dps.Name.Replace("'", "''"), FromOrTO,ptfilter));
                if (st != DBNull.Value)
                {
                    dps.FirstSeconds = Convert.ToInt32(st);
                }
                //End
                object ed = ar.ds.Anaylzed.Compute("Max(TotalSeconds)", String.Format("{1} = '{0}' {2}", dps.Name.Replace("'", "''"), FromOrTO,ptfilter));
                if (ed != DBNull.Value)
                {
                    dps.LastSeconds = Convert.ToInt32(ed);
                }

                viewdpsList.Add(dps);
                if (dps.Category <= 1)
                {
                    //DDValue
                    object dd = ar.ds.Anaylzed.Compute("Sum(Numeric)", String.Format("IsDamage = true and IsHP = true and {1} = '{0}' and TotalSeconds > {2} {3}", dps.Name.Replace("'", "''"), FromOrTO, totalSeconds - Span,ptfilter));
                    Single TotalSpanDmg = 0;
                    if (dd != DBNull.Value)
                    {
                        TotalSpanDmg = Convert.ToInt32(dd);
                    }

                    //PT
                    ptDD += dps.DDValue;
                    ptDot += dps.DotValue;
                    ptAtkTotal += dps.AtkTotal;
                    ptAtkHit += dps.AtkHit;
                    ptMax =  Math.Max(ptMax, dps.MaxDmg);
                    ptMin = Math.Min(ptMin, dps.MinDmg);
                    ptStart = Math.Min(ptStart, dps.FirstSeconds);
                    ptEnd = Math.Max(ptEnd, dps.LastSeconds);

                    //Dot
                    Single DotSpanDmg = GetDotDamage(dps.Name, totalSeconds, totalSeconds - Span);
                    //DPS
                    TotalSpanDmg += DotSpanDmg;
                    dps.DPS = TotalSpanDmg / Span;
                    dps.MaxDPS = Math.Max(dps.DPS, dps.MaxDPS);
                    ptTotalSpanDmg += TotalSpanDmg;
                    ptDotSpanDmg += DotSpanDmg;
                }
                else
                {
                    //DDValue
                    object dd = ar.ds.Anaylzed.Compute("Sum(Numeric)", String.Format("IsDamage = true and IsHP = true and {1} = '{0}' and TotalSeconds > {2} {3}", dps.Name.Replace("'", "''"), FromOrTO,totalSeconds - Span,ptfilter));
                    Single TotalSpanDmg = 0;
                    if (dd != DBNull.Value)
                    {
                        TotalSpanDmg = Convert.ToInt32(dd);
                    }
                    //DoT
                    Single DotSpanDmg = GetDOtDamageTo(dps.Name, totalSeconds, totalSeconds - Span,PtAndMe.ToArray());
                    TotalSpanDmg += DotSpanDmg;
                    dps.DPS = TotalSpanDmg / (float)Span;
                    dps.MaxDPS = Math.Max(dps.DPS, dps.MaxDPS);

                }
            }
            //PTのDPSを出す
            FF14FastReportDataSet.DPSReportRow ptdps = FF14FastReportDS.DPSReport.FindByName("party");
            if (ptdps != null)
            {
                //PT合計
                ptdps.DDValue = ptDD;
                ptdps.DotValue = ptDot;
                ptdps.AtkTotal = ptAtkTotal;
                ptdps.AtkHit = ptAtkHit;
                ptdps.MaxDmg = ptMax;
                ptdps.MinDmg = ptMin;
                ptdps.FirstSeconds = ptStart;
                ptdps.LastSeconds = ptEnd;
                //DPS
                ptdps.DPS = ptTotalSpanDmg / (float)Span;
                ptdps.MaxDPS = Math.Max(ptdps.MaxDPS, ptdps.DPS);
            }
            //更新されなかった古いDPSROWを削除
            for (int i = FF14FastReportDS.DPSReport.Count - 1; i >= 0; i--)
            {
                FF14FastReportDataSet.DPSReportRow _dps = FF14FastReportDS.DPSReport[i];
                if (_dps.Category > 1 && !viewdpsList.Contains(_dps))
                {
                    FF14FastReportDS.DPSReport.RemoveDPSReportRow(_dps);
                }
            }
        }
    }
}
