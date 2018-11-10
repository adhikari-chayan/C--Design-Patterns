using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
   public abstract class BaseAssembly
    {
        protected string _name;
        protected int _quantity;

        public BaseAssembly(string name,int quantity)
        {
            _name = name;
            _quantity = quantity;
        }

        public abstract void Add(BaseAssembly assembly);
        public abstract void Remove(BaseAssembly assembly);
        public abstract void WritePartsList(List<string> list);
    }
}
