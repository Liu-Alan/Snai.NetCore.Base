using Snai.Mysql.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snai.Mysql.DataAccess.Interface
{
    public interface IAlanDao
    {
        //插入数据
        bool CreateStudent(Student student);

        //取全部记录
        IEnumerable<Student> GetStudents();

        //取某id记录
        Student GetStudentByID(int id);

        //根据id更新整条记录
        bool UpdateStudent(Student student);

        //根据id更新名称
        bool UpdateNameByID(int id, string name);

        //根据id删掉记录
        bool DeleteStudentByID(int id);
    }
}
