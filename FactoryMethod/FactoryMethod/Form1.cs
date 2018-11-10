using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetDatabase_Click(object sender, EventArgs e)
        {
            IDatabase database;
            DatabaseType databaseType = DatabaseType.SqlServer;

            if(radUseSqlServer.Checked)
            {
                database = DatabaseFactory.CreateDatabase(databaseType);
            }
            else
            {
                database = DatabaseFactory.CreateDatabase(databaseType);
            }

            IDbCommand command = database.Command;

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM CUSTOMERS";
            command.Connection.Open();

            IDataReader reader = command.ExecuteReader();

            reader.Close();
            command.Connection.Close();
        }

        
    }
}
