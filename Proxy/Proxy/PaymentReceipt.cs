using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class PaymentReceipt : IPaymentReceipt
    {
        public Order Order { get ; set ; }

        public Receipt Receipt
        {
            get { return GetReceipt(); }
        }

        private Receipt GetReceipt()
        {
            //contact the payment processor with order info

            Receipt receipt = new Receipt();
            receipt.OrderId = Order.OrderId;
            receipt.AmountPaid = Order.Amount;
            receipt.Confirmation = "AG43679864FG";
            receipt.DatePaid = DateTime.Now;

            return receipt;
        }
    }
}
