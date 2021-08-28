using jcg2_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jcg2_dotnet.Services
{
    public interface IJCService
    {
        public GetAllMatches_Rp GetAllMatches(GetAllMatches_Rt GetAllMatches_Rt);
        public GetMatchesByMatchRID_Rp GetMatchesByMatchRID(GetMatchesByMatchRID_Rt GetMatchesByMatchRID_Rt);

    }
}
