using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Form1 : Form
    {
        User _admin;
        User _adminClone;
        User _adminDeepClone;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _admin = new Admin
            {
                FirstName = txtFirstname.Text,
                LastName = txtLastname.Text,
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
                HomeAddress = new Address
                {
                    Address1 = txtHomeAddress.Text,
                    Address2 = txtHomeAddress2.Text,
                    City = txtHomeCity.Text,
                    State = txtHomeState.Text,
                    Zip = txtHomeZip.Text

                },
                BusinessAddress = new Address
                {
                    Address1 = txtBizAddress.Text,
                    Address2 = txtBizAddress2.Text,
                    City = txtBizCity.Text,
                    State = txtBizState.Text,
                    Zip = txtBizZip.Text
                }
            };

            _adminClone = (User)_admin.Clone();
            _adminDeepClone = _admin.DeepClone();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _admin.FirstName = txtFirstname.Text;
            _admin.LastName = txtLastname.Text;
            _admin.UserName = txtUsername.Text;
            _admin.Password = txtPassword.Text;
            _admin.HomeAddress.Address1 = txtHomeAddress.Text;
            _admin.HomeAddress.Address2 = txtHomeAddress2.Text;
            _admin.HomeAddress.City = txtHomeCity.Text;
            _admin.HomeAddress.State = txtHomeState.Text;
            _admin.HomeAddress.Zip = txtHomeZip.Text;
            _admin.BusinessAddress.Address1 = txtBizAddress.Text;
            _admin.BusinessAddress.Address2 = txtBizAddress2.Text;
            _admin.BusinessAddress.City = txtBizCity.Text;
            _admin.BusinessAddress.State = txtBizState.Text;
            _admin.BusinessAddress.Zip = txtBizZip.Text;
        }

        private void btnReadClone_Click(object sender, EventArgs e)
        {
            lblFirstname.Text = _adminClone.FirstName;
            lblLastname.Text = _adminClone.LastName;
            lblUsername.Text = _adminClone.UserName;
            lblPassword.Text = _adminClone.Password;

            lblHomeAddress.Text = _adminClone.HomeAddress.Address1;
            lblHomeAddress2.Text = _adminClone.HomeAddress.Address2;
            lblHomeCity.Text = _adminClone.HomeAddress.City;
            lblHomeState.Text = _adminClone.HomeAddress.State;
            lblZip.Text = _adminClone.HomeAddress.Zip;

            lblBizAddress.Text = _adminClone.BusinessAddress.Address1;
            lblBizAddress2.Text = _adminClone.BusinessAddress.Address2;
            lblBizCity.Text = _adminClone.BusinessAddress.City;
            lblBizState.Text = _adminClone.BusinessAddress.State;
            lblBizZip.Text = _adminClone.BusinessAddress.Zip;
        }

        private void btnReadDeepClone_Click(object sender, EventArgs e)
        {
            lblFirstname.Text = _adminDeepClone.FirstName;
            lblLastname.Text = _adminDeepClone.LastName;
            lblUsername.Text = _adminDeepClone.UserName;
            lblPassword.Text = _adminDeepClone.Password;

            lblHomeAddress.Text = _adminDeepClone.HomeAddress.Address1;
            lblHomeAddress2.Text = _adminDeepClone.HomeAddress.Address2;
            lblHomeCity.Text = _adminDeepClone.HomeAddress.City;
            lblHomeState.Text = _adminDeepClone.HomeAddress.State;
            lblZip.Text = _adminDeepClone.HomeAddress.Zip;

            lblBizAddress.Text = _adminDeepClone.BusinessAddress.Address1;
            lblBizAddress2.Text = _adminDeepClone.BusinessAddress.Address2;
            lblBizCity.Text = _adminDeepClone.BusinessAddress.City;
            lblBizState.Text = _adminDeepClone.BusinessAddress.State;
            lblBizZip.Text = _adminDeepClone.BusinessAddress.Zip;
        }
    }
}
