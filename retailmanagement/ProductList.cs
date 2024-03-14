using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retailmanagement
{
    // this class is used to handle the product list which is displayed in the forms listBox
    // methods for adding new products and getting the list of products are included
    internal class ProductList
    {
        // create list with all products and their respective values using constructors
        private List<Product> productList = new List<Product>();

        // get and set methods for productList
        public void addProduct(Product product) { productList.Add(product); }
        public List<Product> getProductList { get { return productList; } }
        public void removeProduct(Product product) { productList.Remove(product); }
    }
}
