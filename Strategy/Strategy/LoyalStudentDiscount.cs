using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
   public class LoyalStudentDiscount :DiscountStrategy
    {
        public LoyalStudentDiscount()
        {
            _discountPercentage = 33;
        }

        public override decimal ApplyDiscount(decimal sale)
        {
            return (decimal)(100 - _discountPercentage) * sale / 100;
        }
    }
}
