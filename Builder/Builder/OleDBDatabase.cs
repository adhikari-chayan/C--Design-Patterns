using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   public class OleDBDatabase : Database
    {
        private DbConnection _connection = null;
        private DbCommand _command = null;

        public override DbConnection Connection
        {
            get
            {
              
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
               

                return _command;
            }

            set
            {
                _command = value;
            }
        }
    }
}
