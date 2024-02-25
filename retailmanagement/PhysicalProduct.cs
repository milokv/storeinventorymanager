using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retailmanagement
{
    internal class PhysicalProduct : Product
    {
        private int Stock;
        private bool SecurityTag;
        public void setStock(int stock) { this.Stock = stock; }
        public void setSecurityTag(bool SecurityTag) { this.SecurityTag = SecurityTag; }
        public int getStock { get { return this.Stock; } }
        public bool getSecurityTag { get { return this.SecurityTag; } }

    }
}
