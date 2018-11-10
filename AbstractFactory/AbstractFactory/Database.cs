using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
   public abstract class Database
    {
        public virtual DbConnection Connection { get; set; }

        public virtual DbCommand Command { get; set; }
    }
}
