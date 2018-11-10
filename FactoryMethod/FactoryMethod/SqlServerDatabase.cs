using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SqlServerDatabase : IDatabase
    {
        private IDbConnection _connection = null;
        private IDbCommand _command = null;

        public  IDbConnection Connection
        {
            get
            {
                if(_connection==null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnectionString"].ConnectionString;
                    _connection = new SqlConnection(connectionString);
                }
                return _connection;
            }

          

        }

        public  IDbCommand Command
        {
            get
            {
                if(_command==null)
                {
                    _command = new SqlCommand();
                    _command.Connection = Connection;
                }

                return _command;
            }

        }
    }
}
