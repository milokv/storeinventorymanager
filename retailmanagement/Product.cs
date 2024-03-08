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
        private string Name;
        private Nullable<int> Stock; //stock kan vara null (inget värde) om det inte anges.


        public void setSellPrice(int price) {  this.SellPrice = price;  }
        public void setBuyPrice(int price) {  this.BuyPrice = price; }
        public void setStock(Nullable<int> stock) { this.Stock = stock; }
        public int getSellPrice {  get { return this.SellPrice; } }
        public int getBuyPrice { get { return this.BuyPrice; } }
        public Nullable<int> getStock { get { return this.Stock; } }
        public string getName { get { return this.Name; } }
        public Product(string name)
        {
            Name = name;
            Stock = null;
        }
        public Product(string name, Nullable<int> stock)
        {
            Name = name;
            Stock = stock;
        }
    }
}
