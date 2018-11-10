using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _customerList = new CustomerAdapter();
        }

        private int _customerId = 1;
        private ICustomerList _customerList;
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerDTO customer = new CustomerDTO
            {
                Id = _customerId,
                FirstName = "Customer",
                LastName = _customerId.ToString(),
                Address = "",
                City = "",
                State = "",
                PostalCode = ""
            };
            _customerList.AddCustomer(customer);
            _customerId++;
        }

        private void btnGetCustomers_Click(object sender, EventArgs e)
        {
            lstCustomers.Items.Clear();
            foreach(var customer in _customerList.GetCustomers())
            {
                lstCustomers.Items.Add(customer.Name);
            }
        }
    }
}
