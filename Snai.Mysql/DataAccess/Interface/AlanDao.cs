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
    }
}
