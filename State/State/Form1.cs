using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace State
{
    public partial class Form1 : Form
    {
        private User _user = new User("KW");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _user.Login();
            txtNextPage.Text = _user.NextPage;

        }

        private void btnUpgradeUser_Click(object sender, EventArgs e)
        {
            _user.Upgrade();
            txtNextPage.Text = _user.NextPage;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _user.Logout();
            txtNextPage.Text = _user.NextPage;

        }
    }
}
