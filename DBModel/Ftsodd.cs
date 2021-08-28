using System;
using System.Collections.Generic;

#nullable disable

namespace jcg2_dotnet.DBModel
{
    public partial class Ftsodd
    {
        public long RowId { get; set; }
        public long MatchRid { get; set; }
        public decimal HomeOdds { get; set; }
        public decimal DrawOdds { get; set; }
        public decimal AwayOdds { get; set; }
    }
}
