using Snai.Mysql.DataAccess.Base;
using Snai.Mysql.DataAccess.Implement;
using Snai.Mysql.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snai.Mysql.DataAccess.Interface
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
            var students = new List<Student>();
            students.AddRange(Context.Student);
            return students;
        }

        public Student GetStudentByID(int id)
        {
            return Context.Find<Student>(id);
        }

        public bool UpdateStudent(Student student)
        {
            Context.Update<Student>(student);
            return Context.SaveChanges() > 0;
        }

        public bool DeleteStudentByID(int id)
        {
            Context.Student.Remove(Context.Find<Student>(id));
			
            return Context.SaveChanges() > 0;
        }
    }
}
