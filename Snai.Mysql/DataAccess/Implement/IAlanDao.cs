using Snai.Mysql.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snai.Mysql.DataAccess.Implement
{
    public interface IAlanDao
    {
        bool CreateStudent(Student student);

        IEnumerable<Student> GetStudents();

        Student GetStudentByID(int id);

        bool UpdateStudent(Student student);
		
        bool DeleteStudentByID(int id);
    }
}
