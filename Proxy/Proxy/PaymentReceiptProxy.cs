using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
   public class PaymentReceiptProxy:IPaymentReceipt
    {
        private bool _paymentProcessing = false;
        private bool _paymentProcessed = false;
        private PaymentReceipt _paymentReceipt = new PaymentReceipt();
        private Receipt _receipt = null;

        public Order Order { get; set; }

        public Receipt Receipt
        {
            get
            {
                if(_paymentProcessed)
                {
                    return _receipt;
                }
                else
                {
                    if(!_paymentProcessing)
                    {
                        _paymentProcessing = true;
                        //here we kickoff  the third party  payment process by calling _paymentReceipt.Receipt preferably on another thread
                        _paymentReceipt.Order = Order;
                        _receipt = _paymentReceipt.Receipt;

                        _paymentProcessing = false;
                        _paymentProcessed = true;
                    }

                    //return Placeholder receipt while processing
                    return GetPlaceHolderReceipt();
                }
            }
        }

        private Receipt GetPlaceHolderReceipt()
        {
            Receipt receipt = new Receipt();
            receipt.OrderId = Order.OrderId;
            receipt.AmountPaid = Order.Amount;
            receipt.Confirmation = "Processing...";
            receipt.DatePaid = DateTime.Now;
            return receipt;
        }
    }
}
