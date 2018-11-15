using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
   public class PriceWatcher:PriceObserver
    {
        private string _name;
        private decimal _price;

        public event System.EventHandler<decimal> PriceChanged = null;

        public PriceWatcher(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public override void Update(Price priceToWatch)
        {
            _price = priceToWatch.ProductPrice;
            if(PriceChanged !=null)
            {
                PriceChanged(this, _price);
            }
        }
    }
}
