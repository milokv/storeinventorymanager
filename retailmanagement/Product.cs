using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retailmanagement
{
    // parent class for all products
    // contains attributes and methods concerning buy and sell prices, names and stock
    internal class Product
    {
        private int SellPrice; // price product is sold for
        private int BuyPrice; // price product is bought for
        private string Name; // name of product
        private Nullable<int> Stock = null; // stock is null if not specified otherwise

        // standard get and set methods for attributes + constructors for name and name + stock
        public void setSellPrice(int price) {  this.SellPrice = price;  }
        public void setBuyPrice(int price) {  this.BuyPrice = price; }
        public void setStock(Nullable<int> stock) { this.Stock = stock; }
        public void setName(string name ) { this.Name = name; }
        public int getSellPrice {  get { return this.SellPrice; } }
        public int getBuyPrice { get { return this.BuyPrice; } }
        public Nullable<int> getStock { get { return this.Stock; } }
        public string getName { get { return this.Name; } }
        public Product(string name)
        {
            Name = name;
        }
        public Product(string name, Nullable<int> stock)
        {
            Name = name;
            Stock = stock;
        }
    }
}
