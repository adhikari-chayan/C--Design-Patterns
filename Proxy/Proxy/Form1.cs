using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IPaymentReceipt _paymentReceipt;
        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            Order order = new Order
            {
                OrderDate = DateTime.Now,
                OrderId = Guid.NewGuid(),
                CustomerId = 5,
                Amount = 85.99M,

                CreditCard = "41111111111111111",
                Expiration = "5/15"

            };

            _paymentReceipt = new PaymentReceiptProxy
            {
                Order = order
            };
            Receipt receipt = _paymentReceipt.Receipt;
            DisplayReceipt(receipt);
        }

        private void DisplayReceipt(Receipt receipt)
        {
            txtReceiptID.Text = receipt.Confirmation;
            txtAmountPaid.Text = receipt.AmountPaid.ToString("C");
            txtDatePaid.Text = receipt.DatePaid.ToLongDateString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Receipt receipt = _paymentReceipt.Receipt;
            DisplayReceipt(receipt);
        }
    }
}
