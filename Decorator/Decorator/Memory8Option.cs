using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   public class Memory8Option:ComputerDecorator
    {
        public Memory8Option(Computer computer):base(computer)
        {
            _optionCode = "8RAM";
            _price = 70.0M;
        }
    }
}
