using Snai.Mysql.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snai.Mysql.DataAccess.Implement
{
    interface IAlanDao
    {
        bool CreateStudent(Student student);
    }
}
