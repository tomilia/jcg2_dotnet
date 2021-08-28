using System;
using System.Collections.Generic;

#nullable disable

namespace jcg2_dotnet.DBModel
{
    public partial class HadiOdd
    {
        public long RowId { get; set; }
        public long MatchRid { get; set; }
        public string HomeHadicap { get; set; }
        public decimal HomeOdds { get; set; }
        public string AwayHadicap { get; set; }
        public decimal AwayOdds { get; set; }
    }
}
