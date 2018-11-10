using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
   public class Assembly:BaseAssembly
    {
        private List<BaseAssembly> _elements = new List<BaseAssembly>();

        public Assembly(string name,int quantity):base(name,quantity)
        { }

        public override void Add(BaseAssembly assembly)
        {
            _elements.Add(assembly);
        }

        public override void Remove(BaseAssembly assembly)
        {
            _elements.Remove(assembly);
        }

        public override void WritePartsList(List<string> list)
        {
            list.Add(_quantity.ToString() + " - " + _name);

            foreach(BaseAssembly assembly in _elements)
            {
                assembly.WritePartsList(list);
            }
        }
    }
}
