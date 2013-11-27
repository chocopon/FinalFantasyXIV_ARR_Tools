using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFXIV_Tools
{
    public class ReportData
    {
        public int TotalDamage { get { return DDValue + DotValue; } }
        public int DDValue { get; set; }
        public int DotValue { get; set; }
        public int TotalCure { get; set; }
        public int Hit { get; set; }
        public int CritHit { get; set; }//クリティカルヒット数
        public double CritHitRate{get{if (Hit > 0) return 100 * (Double)CritHit / (Double)(Hit); return 0;}}//クリティカルヒット率
        public int Miss { get; set; }
        public int Count { get; set; }//発動カウント
        public int Max { get; set; }
        public int Min { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public double Average { get { if (Hit > 0) return (Double)TotalDamage / (Double)Hit; return 0; } }
        public double HitRate { get { if (Hit + Miss > 0) return 100 * (Double)Hit / (Double)(Hit + Miss); return 0; } }
        public double Dps { get { if (End - Start > 0) return (Double)TotalDamage / (Double)(End - Start); return 0; } }
    }
}
