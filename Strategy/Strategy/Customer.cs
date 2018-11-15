using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
   public class Customer
    {
        private DiscountStrategy _discountStrategy;

        public void  SetDiscountStrategy(DiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal ApplyDiscount(decimal sale)
        {
            return _discountStrategy.ApplyDiscount(sale);
        }


    }
}
