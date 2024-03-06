using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retailmanagement
{
    internal class PhysicalProduct : Product
    {
        // variablar för nuvarande lager (stock), och ifall den har en säkerhetstagg, tex larm (SecurityTag)
        private Nullable<int> Stock; //stock kan vara null (inget värde) om det inte anges.
        private bool SecurityTag;
        public void setStock(Nullable<int> stock) { this.Stock = stock; }
        public void setSecurityTag(bool SecurityTag) { this.SecurityTag = SecurityTag; }
        public Nullable<int> getStock { get { return this.Stock; } }
        public bool getSecurityTag { get { return this.SecurityTag; } }
        public PhysicalProduct(string name, int stock, bool securityTag) : base(name)
        {
            Stock = stock;
            SecurityTag = securityTag;
        }
        public PhysicalProduct(string name, int stock) : base(name)
        {
            Stock = stock;
            SecurityTag = false; //om inte securitytag anges är det false som default.
        }
        public PhysicalProduct(string name) : base(name)
        {
            //om inget anges utom namn antas det att Stock inte har något värde, och ingen security tag finns.
            Stock = null;
            SecurityTag = false; 
        }
    }
}
