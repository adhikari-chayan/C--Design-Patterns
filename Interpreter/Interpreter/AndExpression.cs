using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
   public class AndExpression:Expression
    {
        private Expression _expression1;
        private Expression _expression2;

        public AndExpression(Expression expression1, Expression expression2)
        {
            _expression1 = expression1;
            _expression2 = expression2;
        }

        public override bool Interpret()
        {
            return _expression1.Interpret() && _expression2.Interpret();
        }
    }
}
