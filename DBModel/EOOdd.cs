using System;
using System.Collections.Generic;

#nullable disable

namespace jcg2_dotnet.DBModel
{
    public partial class EOOdd
    {
        public long RowId { get; set; }
        public long MatchRid { get; set; }
        public decimal Even { get; set; }
        public decimal Odd { get; set; }
    }
}
