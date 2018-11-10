using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   public class ComputerDecorator:Computer
    {
        protected Computer _baseComputer = null;
        protected string _optionCode="";
        protected decimal _price = 0.0M;

        protected ComputerDecorator(Computer computer)
        {
            _baseComputer = computer;
            Model = computer.Model;
        }

        public override string GetOptionCode()
        {
            return string.Format("{0}-{1}", _baseComputer.GetOptionCode(), _optionCode);
        }

        public override decimal GetPrice()
        {
            return _price + _baseComputer.GetPrice();
        }
    }
}
