using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visitor
{
    public partial class Form1 : Form
    {
        private Users _users = new Users();
        private User Greg=new User("Greg", DateTime.Now, 25);
        private User Richard= new User("Richard", DateTime.Now.AddMonths(-6), 42);
        public Form1()
        {
            InitializeComponent();
          
           
            _users.Attach(Greg);
            _users.Attach(Richard);
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            lblGregStatus.Text = Greg.Name + ": " + Greg.Credits.ToString() + " credits expire " + Greg.ExpirationDate.ToShortDateString();
            lblRichardStatus.Text = Richard.Name + ": " + Richard.Credits.ToString() + " credits expire " + Richard.ExpirationDate.ToShortDateString();
        }

        private void btnAddCredits_Click(object sender, EventArgs e)
        {
            _users.Accept(new CreditsVisitor());
            UpdateStatus();
        }

        private void btnUpdateExpirationDate_Click(object sender, EventArgs e)
        {
            _users.Accept(new ExpirationVisitor());
            UpdateStatus();
        }
    }
}
