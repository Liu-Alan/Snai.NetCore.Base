using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Snai.SimpleCookie.Controllers
{
    public class CookiesController : ControllerBase
    {
        public void SetCookie()
        {
            Response.ContentType = "text/html;charset=utf-8";

            Response.Cookies.Append("snai.code", "ceshi", new CookieOptions()
            {
                HttpOnly = true,
                Secure = false
            });

            Response.WriteAsync("Cookie 设置成功！");
        }

        public void GetCookie()
        {
            Response.ContentType = "text/html;charset=utf-8";

            Request.Cookies.TryGetValue("snai.code", out string cookieValue);
            if (!string.IsNullOrEmpty(cookieValue))
            {
                Response.WriteAsync("Cookie 获取成功！");
                Response.WriteAsync(cookieValue);
            }
            else
            {
                Response.WriteAsync("Cookie 获取失败！");
            }
        }

        public void DelCookie()
        {
            Response.ContentType = "text/html;charset=utf-8";

            Response.Cookies.Delete("snai.code");
            Response.WriteAsync("Cookie 删除成功！");
        }
    }
}
