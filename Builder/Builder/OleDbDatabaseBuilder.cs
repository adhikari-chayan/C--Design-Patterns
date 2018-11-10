using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   public class OleDbDatabaseBuilder :IDatabaseBuilder
    {
        private Database _database;

        public OleDbDatabaseBuilder()
        {
            _database = new OleDBDatabase();
        }

        public void BuildCommand()
        {
            _database.Command = new OleDbCommand();
            _database.Command.Connection = _database.Connection;
        }

        public void BuildConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["OleDbConnectionString"].ConnectionString;
            _database.Connection = new OleDbConnection(connectionString);
        }

        public void SetSettings()
        {
            _database.Command.CommandTimeout = 360;
            _database.Command.CommandType = CommandType.Text;
        }

        public Database Database
        {
            get
            {
                return _database;
            }
        }
    }
}
