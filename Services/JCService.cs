using jcg2_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jcg2_dotnet.Services
{
    public class JCService : IJCService
    {
        public GetAllMatches_Rp GetAllMatches(GetAllMatches_Rt GetAllMatches_Rt)
        {
            GetAllMatches_Rt testing;
            Test x = new Test { From = DateTime.Now, To = DateTime.Now, TestField = 1 };
            testing = x;
            return null;
        }

        public GetMatchesByMatchRID_Rp GetMatchesByMatchRID(GetMatchesByMatchRID_Rt GetMatchesByMatchRID_Rt)
        {
            throw new NotImplementedException();
        }
    }
}
