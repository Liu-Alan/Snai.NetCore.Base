using Snai.Mysql.DataAccess.Base;
using Snai.Mysql.DataAccess.Interface;
using Snai.Mysql.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snai.Mysql.DataAccess.Implement
{
    public class AlanDao: IAlanDao
    {
        public AlanContext Context;

        public AlanDao(AlanContext context)
        {
            Context = context;
        }

        //插入数据
        public bool CreateStudent(Student student)
        {
            Context.Student.Add(student);
            return Context.SaveChanges() > 0;
        }

        //取全部记录
        public IEnumerable<Student> GetStudents()
        {
            return Context.Student.ToList();
        }

        //取某id记录
        public Student GetStudentByID(int id)
        {
            return Context.Student.SingleOrDefault(s => s.ID == id);
        }

        //根据id更新整条记录
        public bool UpdateStudent(Student student)
        {
            Context.Student.Update(student);
            return Context.SaveChanges() > 0;
        }

        //根据id更新名称
        public bool UpdateNameByID(int id, string name)
        {
            var state = false;
            var student = Context.Student.SingleOrDefault(s => s.ID == id);

            if (student != null)
            {
                student.Name = name;
                state = Context.SaveChanges() > 0;
            }

            return state;
        }

        //根据id删掉记录
        public bool DeleteStudentByID(int id)
        {
            var student = Context.Student.SingleOrDefault(s => s.ID == id);
            Context.Student.Remove(student);
            return Context.SaveChanges() > 0;
        }
    }
}
