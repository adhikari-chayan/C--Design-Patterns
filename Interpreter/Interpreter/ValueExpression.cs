using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
   public class ValueExpression:Expression
    {
        private string _context;

        public ValueExpression(string context)
        {
            _context = context;
        }

        public override bool Interpret()
        {
            double value;
            if(double.TryParse(_context,out value))
            {
                return value != 0;
            }
            return !string.IsNullOrEmpty(_context);
        }
    }
}
