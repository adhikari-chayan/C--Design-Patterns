using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
   public abstract class Price
    {
        private List<PriceObserver> _observers = new List<PriceObserver>();
        private decimal _productPrice;

        public void Subscribe(PriceObserver observer)
        {
            _observers.Add(observer);
                
        }

        public void Unsubscribe(PriceObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(PriceObserver observer in _observers)
            {
                observer.Update(this);
            }
        }

        public decimal ProductPrice
        {
            get
            {
                return _productPrice;
            }
            set
            {
                if (_productPrice != value)
                {
                    _productPrice = value;
                    Notify();
                }
             }
            }

        }

    }

