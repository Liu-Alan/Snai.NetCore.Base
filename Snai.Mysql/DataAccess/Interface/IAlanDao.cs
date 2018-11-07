using Snai.Mysql.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snai.Mysql.DataAccess.Interface
{
    public interface IAlanDao
    {
        bool CreateStudent(Student student);

        IEnumerable<Student> GetStudents();

        Student GetStudentByID(int id);

        bool UpdateStudent(Student student);

        bool UpdateNameByID(int id, string name);
            
        bool DeleteStudentByID(int id);
    }
}
