using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   public class SSD256Option:ComputerDecorator
    {
        public SSD256Option(Computer computer):base(computer)
        {
            _optionCode = "256SSD";
            _price = 120.0M;
        }
    }
}
