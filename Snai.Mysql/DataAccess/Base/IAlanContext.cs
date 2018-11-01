using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Snai.Mysql.Entities;

namespace Snai.Mysql.DataAccess.Base
{
    interface IAlanContext
    {
        DbSet<Student> Student { get; set; }
    }
}
