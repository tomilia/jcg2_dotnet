using System;
using System.Collections.Generic;

#nullable disable

namespace jcg2_dotnet.DBModel
{
    public partial class Match
    {
        public long RowId { get; set; }
        public string HomeName { get; set; }
        public string AwayName { get; set; }
        public string ChhomeName { get; set; }
        public string ChawayName { get; set; }
        public bool IsFinished { get; set; }
        public bool RecStatus { get; set; }
    }
}
