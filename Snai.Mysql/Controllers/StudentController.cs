using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snai.Mysql.DataAccess.Interface;
using Snai.Mysql.Entities;

namespace Snai.Mysql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IAlanDao AlanDao;

        public StudentController(IAlanDao alanDao)
        {
            AlanDao = alanDao;
        }

        [HttpGet]
        public ActionResult<string> Create(string name, byte sex, int age)
        {
            if (string.IsNullOrEmpty(name.Trim()))
            {
                return "姓名不能为空";
            }

            if (sex < 0 || sex > 2)
            {
                return "性别数据有误";
            }

            if (age <= 0)
            {
                return "年龄数据有误";
            }

            var student = new Student() {
                Name = name,
                Sex = sex,
                Age = age
            };

            var result = AlanDao.CreateStudent(student);

            if (result)
            {
                return "学生插入成功";
            }
            else
            {
                return "学生插入失败";
            }
            
        }
    }
}