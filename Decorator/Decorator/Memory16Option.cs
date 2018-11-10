using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   public class Memory16Option:ComputerDecorator
    {
        public Memory16Option(Computer computer) : base(computer)
        {
            _optionCode = "16RAM";
            _price = 150.0M;
        }
    }
}
