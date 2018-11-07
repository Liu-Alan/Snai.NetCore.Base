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

        public bool CreateStudent(Student student)
        {
            Context.Student.Add(student);
            return Context.SaveChanges() > 0;
        }

        public IEnumerable<Student> GetStudents()
        {
            return Context.Student.ToList();
        }

        public Student GetStudentByID(int id)
        {
            return Context.Student.SingleOrDefault(s => s.ID == id);
        }

        public bool UpdateStudent(Student student)
        {
            Context.Student.Update(student);
            return Context.SaveChanges() > 0;
        }

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

        public bool DeleteStudentByID(int id)
        {
            var student = Context.Student.SingleOrDefault(s => s.ID == id);
            Context.Student.Remove(student);
            return Context.SaveChanges() > 0;
        }
    }
}
