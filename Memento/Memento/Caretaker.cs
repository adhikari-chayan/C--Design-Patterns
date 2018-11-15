using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
   public class Caretaker
    {
        private UserMemento _userMemento;

        public UserMemento UserMemento
        {
            get
            {
                return _userMemento;
            }
            set
            {
                _userMemento = value;
            }
        }
    }
}
