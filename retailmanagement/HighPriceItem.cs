using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retailmanagement
{
    internal class HighPriceItem : PhysicalProduct
    {
        private bool LockedCase;
        private bool NeedManager;
        public void setLockedCase (bool Locked) { this.LockedCase = Locked; }
        public void setNeedManager(bool NeedManager) { this.NeedManager = NeedManager; }
        public bool getLockedCase { get { return this.LockedCase; } }
        public bool getNeedManager { get { return this.NeedManager; } }
        public HighPriceItem(string name) : base(name)
        {

        }
    }
}
