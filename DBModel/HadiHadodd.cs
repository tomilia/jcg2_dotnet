using System;
using System.Collections.Generic;

#nullable disable

namespace jcg2_dotnet.DBModel
{
    public partial class HadiHadodd
    {
        public long RowId { get; set; }
        public long MatchRid { get; set; }
        public int HomeHadicap { get; set; }
        public decimal HomeOdds { get; set; }
        public int DrawHadicap { get; set; }
        public decimal DrawOdds { get; set; }
        public int AwayHadicap { get; set; }
        public decimal AwayOdds { get; set; }
    }
}
