using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
   public class OleDBDatabase : IDatabase
    {
        private IDbConnection _connection = null;
        private IDbCommand _command = null;

        public  IDbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["OleDBConnectionString"].ConnectionString;
                    _connection = new OleDbConnection(connectionString);
                }
                return _connection;
            }

         

        }

        public  IDbCommand Command
        {
            get
            {
                if (_command == null)
                {
                    _command = new OleDbCommand();
                    _command.Connection = Connection;
                }

                return _command;
            }

          
        }
    }
}
