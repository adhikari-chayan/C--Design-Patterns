using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
   public class Parser
    {
        public Expression Parse(string context)
        {
            List<string> parts = new List<string>(context.Split(' '));

            if(parts.Count < 3)
            {
                return new ValueExpression(context);
            }

            Expression firstExpression = new ValueExpression(parts[0]);
            parts.RemoveAt(0);
            return GetNextExpression(parts, firstExpression);
        }

        private Expression GetNextExpression(List<string> parts,Expression firstExpresson)
        {
            if(parts.Count<2)
            {
                return firstExpresson;
            }
            Expression secondExpression = new ValueExpression(parts[1]);
            string part = parts[0];
            parts.RemoveAt(0);
            parts.RemoveAt(0);

            if(part.ToUpper().Equals("OR"))
            {
                return new OrExpression(firstExpresson, GetNextExpression(parts, secondExpression));
            }
            else
            {
                return new AndExpression(firstExpresson, GetNextExpression(parts, secondExpression));
            }

        }
    }
}
