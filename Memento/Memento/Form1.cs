using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public partial class Form1 : Form
    {
        private User _user=new User();
        private Caretaker _caretaker=new Caretaker();
        public Form1()
        {
            InitializeComponent();

            _user.UserId = 1;
            _user.Username = "KDub";
            _user.Name = "Keith";
            _user.Password = "password";

            DisplayUser();
        }

        private void DisplayUser()
        {
            txtUserId.Text = _user.UserId.ToString();
            txtUsername.Text = _user.Username;
            txtName.Text = _user.Name;
            txtPassword.Text = _user.Password;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _caretaker.UserMemento = _user.SaveState();

            int userId;
            if(int.TryParse(txtUserId.Text,out userId))
            {
                _user.UserId = userId;
            }

            _user.Name = txtName.Text;
            _user.Username = txtUsername.Text;
            _user.Password = txtPassword.Text;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            _user.RestoreState(_caretaker.UserMemento);
            DisplayUser();
        }
    }
}
