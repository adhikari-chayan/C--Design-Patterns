using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
   public class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType databaseType)
        {
            switch(databaseType)
            {
                case DatabaseType.OleDb:
                    return new OleDBDatabase();
                case DatabaseType.SqlServer:
                    return new SqlServerDatabase();

                default:
                    return new SqlServerDatabase();


            }
        }
    }
}
