using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snai.Common.Extension;

namespace Snai.Common.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IpController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get(int id)
        {
            return HttpContext.GetUserIp();
        }
    }
}