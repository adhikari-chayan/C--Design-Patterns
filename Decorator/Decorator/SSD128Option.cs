using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   public class SSD128Option:ComputerDecorator
    {
        public SSD128Option(Computer computer):base(computer)
        {
            _optionCode = "128SSD";
            _price = 74.0M;
        }
    }
}
