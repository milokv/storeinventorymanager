using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retailmanagement
{
    internal class Product
    {
        private int SellPrice;
        private int BuyPrice;
        private string Name = nameof();

        public void setSellPrice(int price) {  this.SellPrice = price;  }
        public void setBuyPrice(int price) {  this.BuyPrice = price; }
        public int getSellPrice {  get { return this.SellPrice; } }
        public int getBuyPrice { get { return this.BuyPrice; } }
        public string getName { get { return this.Name; } }
    }
}
