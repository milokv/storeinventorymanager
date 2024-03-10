using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retailmanagement
{
    // this class is for Physical Products, that dont fall under the "HighPriceItem" category
    // it contains an attribute for whether a product has a security/alarm tag
    // and get/set methods for it, + constructors
    internal class PhysicalProduct : Product
    {
        private bool SecurityTag = false; // defaults as false
        public void setSecurityTag(bool SecurityTag) { this.SecurityTag = SecurityTag; }
        public bool getSecurityTag { get { return this.SecurityTag; } }
        public PhysicalProduct(string name, int stock, bool securityTag) : base(name, stock)
        {
            SecurityTag = securityTag;
        }
        public PhysicalProduct(string name, Nullable<int> stock) : base(name, stock)
        {
        }
        public PhysicalProduct(string name) : base(name)
        {
        }
    }
}
