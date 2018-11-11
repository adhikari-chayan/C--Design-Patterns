using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class IteratorClass : IIterator
    {
        IAggregate _aggregate = null;
        int _index = 0;

        public IteratorClass(IAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public User First
        {
            get
            {
                _index = 0;
                return _aggregate[_index];
            }
        }

        public User Next
        {
            get
            {
                _index += 1;
                if(IsDone ==false)
                {
                    return _aggregate[_index];
                }
                else
                {
                    return null;
                }
            }
        }

        

        public User Current
        {
            get
            {
                return _aggregate[_index];
            }
        }

        public bool IsDone
        {
            get
            {
                return (_index >= _aggregate.Count);
            }
        }
    }
}
