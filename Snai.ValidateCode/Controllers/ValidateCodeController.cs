using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            Response.Body.Dispose();
            return File(codeImg, @"image/png");
        }
    }
}