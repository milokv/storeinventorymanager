using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retailmanagement
{
    /// <summary>
    ///  this class is for Physical Products with a high price.
    ///  the attributes are LockedCase and NeedManager.
    ///  they determine whether the product is locked in a case, and if a manager is needed to confirm the sale
    /// </summary>
    internal class HighPriceItem : PhysicalProduct
    {
        private bool LockedCase = false; // defaults as false
        private bool NeedManager = false; // defaults as false
        public void setLockedCase (bool Locked) { this.LockedCase = Locked; }
        public void setNeedManager(bool NeedManager) { this.NeedManager = NeedManager; }
        public bool getLockedCase { get { return this.LockedCase; } }
        public bool getNeedManager { get { return this.NeedManager; } }
        public HighPriceItem(string name) : base(name) { }
        public HighPriceItem(string name, Nullable<int> stock) : base(name, stock) { }

    }
}
