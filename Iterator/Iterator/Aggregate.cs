using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
   public class Aggregate : IAggregate
    {
        List<User> _values = null;

        public Aggregate()
        {
            _values = new List<User>();
        }

        public IIterator GetIterator()
        {
            return new IteratorClass(this);
        }

        public User this[int index]
        {
            get
            {
                if (index < _values.Count)
                {
                    return _values[index];

                }
                else
                {
                    return null;
                }
            }
            set
            {
                _values.Add(value);
            }
        }

        public int Count
        {
            get
            {
                return _values.Count;
            }
        }
    }
}
