using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Snai.SimpleCookie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            Response.ContentType = "text/html;charset=utf-8";

            Response.Cookies.Append("snai.code", "ceshi", new CookieOptions()
            {
                HttpOnly = true,
                Secure = false,
                MaxAge = new TimeSpan(- 1)
            });

            Response.WriteAsync("Cookie 设置成功！");

            Request.Cookies.TryGetValue("snai.code", out string cookieValue);
            if (!string.IsNullOrEmpty(cookieValue))
            {
                Response.WriteAsync("Cookie 获取成功！");
                Response.WriteAsync(cookieValue);
            };

            Response.Cookies.Delete("snai.code");

            Request.Cookies.TryGetValue("snai.code", out string delCookieValue);
            if (string.IsNullOrEmpty(delCookieValue))
            {
                Response.WriteAsync("Cookie 删除成功！");
            }
            else
            {
                Response.WriteAsync("Cookie 删除失败！");
                Response.WriteAsync(delCookieValue);
            }

            return "结束";
        }
        
    }
}
