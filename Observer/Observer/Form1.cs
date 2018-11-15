using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        private BigStorePrice _price;
        public Form1()
        {
            InitializeComponent();
            _price = new BigStorePrice();
            _price.ProductPrice = numPrice.Value;

            PriceWatcher observer1 = new PriceWatcher("Observer 1");
            _price.Subscribe(observer1);
            observer1.PriceChanged += Observer1_PriceChanged;

            PriceWatcher observer2 = new PriceWatcher("Observer 2");
            _price.Subscribe(observer2);
            observer2.PriceChanged += Observer2_PriceChanged;
        }

        private void Observer2_PriceChanged(object sender, decimal e)
        {
            lblObserver2.Text = ((PriceWatcher)sender).Name + ": " + e.ToString("C");
        }

        private void Observer1_PriceChanged(object sender, decimal e)
        {
            lblObserver1.Text = ((PriceWatcher)sender).Name + ": " + e.ToString("C");
        }

        private void btnSetNewPrice_Click(object sender, EventArgs e)
        {
            _price.ProductPrice = numPrice.Value;
        }
    }
}
