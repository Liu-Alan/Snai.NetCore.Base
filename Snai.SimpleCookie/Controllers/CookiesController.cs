using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snai.SimpleCookie.Common.Encrypt;

namespace Snai.SimpleCookie.Controllers
{
    public class CookiesController : ControllerBase
    {
        public void SetCookie(string date)
        {
            Response.ContentType = "text/html;charset=utf-8";

            string cipherText = EncryptAES.Encrypt(date);

            Response.Cookies.Append("snai.code", cipherText, new CookieOptions()
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
                string plainText = EncryptAES.Decrypt(cookieValue);
                Response.WriteAsync(plainText);
                Response.WriteAsync("\r\n Cookie 获取成功！");
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
