using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   public class SSD512Option:ComputerDecorator
    {
        public SSD512Option(Computer computer):base(computer)
        {
            _optionCode = "512SSD";
            _price = 230.0M;
        }
    }
}
