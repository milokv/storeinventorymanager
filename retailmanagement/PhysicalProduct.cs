using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retailmanagement
{
    internal class PhysicalProduct : Product
    {
        // variabel ifall den har en säkerhetstagg, tex larm (SecurityTag)
        private bool SecurityTag;
        public void setSecurityTag(bool SecurityTag) { this.SecurityTag = SecurityTag; }
        public bool getSecurityTag { get { return this.SecurityTag; } }
        public PhysicalProduct(string name, int stock, bool securityTag) : base(name, stock)
        {
            SecurityTag = securityTag;
        }
        public PhysicalProduct(string name, Nullable<int> stock) : base(name, stock)
        {
            SecurityTag = false; //om inte securitytag anges är det false som default.
        }
        public PhysicalProduct(string name) : base(name)
        {
            //om inget anges utom namn antas det att Stock inte har något värde, och ingen security tag finns.
            SecurityTag = false; 
        }
    }
}
