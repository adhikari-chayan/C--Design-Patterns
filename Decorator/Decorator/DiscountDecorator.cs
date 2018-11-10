using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   public class DiscountDecorator:ComputerDecorator
    {
        private int _discountRate = 5;

        public DiscountDecorator(Computer computer):base(computer)
        {
            _optionCode = "Discount";
            this._price = 0;
        }

        public override string GetOptionCode()
        {
            return base.GetOptionCode() + string.Format("Disc{0}", _discountRate);
        }

        public override decimal GetPrice()
        {
            return (100 - _discountRate) * _baseComputer.GetPrice() / 100;
        }
    }
}
