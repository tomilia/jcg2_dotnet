using jcg2_dotnet.Models;
using jcg2_dotnet.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jcg2_dotnet.Controllers
{
    [Route("jcg2/v1")]
    public class JCController : Controller
    {
        private readonly IJCService __JCService;

        public JCController(IJCService IJCService)
        {
            __JCService = IJCService;
        }
        [Route("GetAllMatches")]
        public GetAllMatches_Rp GetAllMatches(GetAllMatches_Rt GetAllMatches_Rt)
        {
            return __JCService.GetAllMatches(GetAllMatches_Rt);
        }
        [Route("GetAllMatchesByMatchRID")]
        public GetMatchesByMatchRID_Rp GetMatchByMatchRID(GetMatchesByMatchRID_Rt GetMatchesByMatchRID_Rt)
        {
            return __JCService.GetMatchesByMatchRID(GetMatchesByMatchRID_Rt);
        }

    }
}
