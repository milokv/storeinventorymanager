using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retailmanagement
{
    // class for digital products.
    // Contains attributes for if the product is a subscription, and if stock is limited or not
    internal class DigitalProduct : Product
    {
        private bool Subscription = false; // attribute for if the product is a subscription
        private bool LimitedStock = false; // attribute for if the product has limited (true) or unlimited (false) stock

        // standard get/set and constructors, with some extras added
        public void setSubscription(bool Subscription) { this.Subscription = Subscription; }
        public void setLimitedStock(bool LimitedStock)
        { 
            this.LimitedStock = LimitedStock;
            if (this.LimitedStock == false) { setStock(null);  }
            // if stock is not limited, set stock to null
        }
        public bool getSubscription { get { return this.Subscription; } }
        public bool getLimitedStock { get {
                if (this.getStock != null) { this.LimitedStock = true; return true; }
                else { this.LimitedStock = false; return false; }
                // if stock is not null, LimitedStock must be true, so it sets its value to true and returns true
                // if stock is null, LimitedStock must be false, so its set to false and returns false
            } }
        public DigitalProduct(string name) : base(name)
        {
            // if only name is specified, both attributes from this class are false as default
        }
        public DigitalProduct(string name, Nullable<int> stock) : base(name, stock)
        {
            Subscription = false;
            // if stock isn't null, set LimitedStock to true, and vice versa.
            if (stock != null)
            {
                LimitedStock = true;
            }
            else { LimitedStock = false; }
        }
    }
}
