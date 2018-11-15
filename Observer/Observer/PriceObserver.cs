using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
   public abstract class PriceObserver
    {
        public abstract void Update(Price priceToWatch);
    }
}
