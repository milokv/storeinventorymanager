using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retailmanagement
{
    internal class DigitalProduct : Product
    {
        private bool Subscription;
        private bool LimitedStock;
        public void setSubscription(bool Subscription) { this.Subscription = Subscription; }
        public void setLimitedStock(bool LimitedStock)
        { 
            this.LimitedStock = LimitedStock;
            if (this.LimitedStock == false) { setStock(null);  }
        }
        public bool getSubscription { get { return this.Subscription; } }
        public bool getLimitedStock { get { return this.LimitedStock; } }
        public DigitalProduct(string name) : base(name)
        {
            LimitedStock = false;
            Subscription = false;
        }
        public DigitalProduct(string name, Nullable<int> stock) : base(name, stock)
        {
            Subscription = false;
            if (stock != null)
            {
                LimitedStock = true;
            }
            else { LimitedStock = false; }
        }
    }
}
