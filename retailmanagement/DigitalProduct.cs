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
        private Nullable<int> Stock;
        public void setSubscription(bool Subscription) { this.Subscription = Subscription; }
        public void setLimitedStock(bool LimitedStock)
        { 
            this.LimitedStock = LimitedStock;
            if (this.LimitedStock == false) {  this.Stock = null;  }
        }
        public bool getSubscription { get { return this.Subscription; } }
        public bool getLimitedStock { get { return this.LimitedStock; } }
        public void setStock(int stock) { this.Stock = stock; }
        public Nullable<int> GetStock()
        { 
            if (this.LimitedStock == true)  {  return this.Stock;  }
            else { return null; }
        }
    }
}
