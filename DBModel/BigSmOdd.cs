using System;
using System.Collections.Generic;

#nullable disable

namespace jcg2_dotnet.DBModel
{
    public partial class BigSmOdd
    {
        public long RowId { get; set; }
        public long MatchRid { get; set; }
        public decimal Median { get; set; }
        public decimal BigOdds { get; set; }
        public decimal SmallOdds { get; set; }
    }
    
}
