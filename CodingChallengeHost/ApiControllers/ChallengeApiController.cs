using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodingChallengeHost.ApiControllers
{
    [Produces("application/json")]
    [Route("api/Challenge")]
    public class ChallengeApiController : Controller
    {
        [Authorize]
        [HttpGet]
        public string Get()
        {
            return "Hello world!";
        }
    }
}