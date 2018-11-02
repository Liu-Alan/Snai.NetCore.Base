using Microsoft.EntityFrameworkCore;
using Snai.Mysql.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snai.Mysql.DataAccess.Base
{
    public class AlanContext:DbContext
    {
        public AlanContext(DbContextOptions<AlanContext> options)
            : base(options)
        { }

        public DbSet<Student> Student { get; set; }
    }
}
