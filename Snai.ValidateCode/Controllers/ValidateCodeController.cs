using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Snai.ValidateCode.Common.Const;
using Snai.ValidateCode.Infrastructure;

namespace Snai.ValidateCode.Controllers
{
    public class ValidateCodeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ValidateCode(string identify = "")
        {
            string codeValue = "";
            var codeImg = ValidateCodeServices.CreateImage(out codeValue,6);
            codeValue = codeValue.ToUpper();//验证码不分大小写  

            HttpContext.Session.SetString(Const.ValidateCodeSession, codeValue);

            Response.Body.Dispose();
            return File(codeImg, @"image/png");
        }

        public void CompareValidateCode()
        {
            Response.ContentType = "text/html;charset=utf-8";
            string code = Request.Form["validateCode"];
            string codeValue = HttpContext.Session.GetString(Const.ValidateCodeSession);

            HttpContext.Session.Remove(Const.ValidateCodeSession);

            if (string.Equals(codeValue, code, StringComparison.OrdinalIgnoreCase))
            {
                Response.WriteAsync($"{code} == {codeValue} 验证成功！");
            }
            else
            {
                Response.WriteAsync($"{code} != {codeValue} 验证失败！");
            }
        }
    }
}