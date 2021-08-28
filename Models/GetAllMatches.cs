using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jcg2_dotnet.Models
{
    public class GetAllMatches_Rt
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
    public class Test : GetAllMatches_Rt
    {
        public long TestField { get; set; }
    }
    public class GetAllMatches_Rp
    {
        public long RowID { get; set; }
        public string HomeName { get; set; }
        public string AwayName { get; set; }
        public string CHHomeName { get; set; }
        public string CHAwayName { get; set; }
        public string IsFinished { get; set; }
        public HADOdds HADOdds { get; set; }
        public HTHADOdds HTHADOdds { get; set; }
        public HadiHADOdds HadiHADOdds { get; set; }
        public HadiOdds HadiOdds { get; set; }
        public BigSmOdds BigSmOdds { get; set; }
    }
    public class HADOdds
    {
        public decimal HomeOdds { get; set; }
        public decimal DrawOdds { get; set; }
        public decimal AwayOdds { get; set; }
    }
    public class HTHADOdds
    {
        public decimal HomeHTOdds { get; set; }
        public decimal DrawHTOdds { get; set; }
        public decimal AwayHTOdds { get; set; }
        public bool HRaise { get; set; }
        public bool DRaise { get; set; }
        public bool ARaise { get; set; }
    }
    public class HadiHADOdds
    {
        public int HadiHome { get; set; }
        public decimal HadiHomeOdds { get; set; }
        public int HadiDraw { get; set; }
        public decimal HadiDrawOdds { get; set; }
        public int HadiAway { get; set; }
        public decimal HadiAwayOdds { get; set; }
        public bool HRaise { get; set; }
        public bool DRaise { get; set; }
        public bool ARaise { get; set; }
    }
    public class HadiOdds
    {
        public string HadiHome { get; set; }
        public decimal HadiHomeOdds { get; set; }
        public string HadiAway { get; set; }
        public decimal HadiAwayOdds { get; set; }
        public bool HRaise { get; set; }
        public bool ARaise { get; set; }
    }
    public class BigSmOdds
    {
        public decimal BigOdds { get; set; }
        public decimal LowOdds { get; set; }
        public bool BRaise { get; set; }
        public bool LRaise { get; set; }
    }
    public class FTSOdds
    {
        public decimal HomeOdds { get; set; }
        public decimal AwayOdds { get; set; }
        public decimal NoGoal { get; set; }
        public bool HRaise { get; set; }
        public bool ARaise { get; set; }
        public bool NRaise { get; set; }
    }
}
