using Snai.Mysql.DataAccess.Base;
using Snai.Mysql.DataAccess.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snai.Mysql.DataAccess.Interface
{
    public class AlanDao: IAlanDao
    {
        public IAlanContext AlanContext;

        public AlanDao(IAlanContext context)
        {
            AlanContext = context;
        }
    }
}
