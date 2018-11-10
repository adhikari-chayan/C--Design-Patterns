using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
   public class OleDBDatabase : Database
    {
        private DbConnection _connection = null;
        private DbCommand _command = null;

        public override DbConnection Connection
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

            set
            {
                _connection = value;
            }

        }

        public override DbCommand Command
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

            set
            {
                _command = value;
            }
        }
    }
}
