using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retailmanagement
{
    public partial class Form1 : Form
    {
        // new instance of ProductList class
        List<ComboBox> dropdowns = new List<ComboBox>();
        ProductList productList = new ProductList();

        public bool addProduct(string name, Nullable<int> stock, int selectedClass)
        {
            if (selectedClass == 1) { productList.addProduct(new DigitalProduct(name, stock)); return true; }
            else if (selectedClass == 2) { productList.addProduct(new PhysicalProduct(name, stock)); return true; }
            else if (selectedClass == 3) { productList.addProduct(new HighPriceItem(name, stock)); return true; }
            else { return false; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            productList.addProduct(new HighPriceItem("Rolex", 14, true));
            productList.addProduct(new DigitalProduct("Fortnite Giftcard", null));
            loadListBox();
            // add bool dropdowns to dropdown list
            dropdowns.Add(limitedStockBox);
            dropdowns.Add(subscriptionBox);
            dropdowns.Add(lockedCaseBox);
            dropdowns.Add(securityTagBox);
            dropdowns.Add(needManagerBox);

            foreach (ComboBox comboBox in dropdowns) // add true/false to all bool dropdowns, and show false as default
            {
                comboBox.Items.Add("False");
                comboBox.Items.Add("True");
                comboBox.SelectedIndex = 0;
            }
        }
        public void loadListBox()
        {
            // add products in List<Product> to the listbox, displaying the name in the listbox
            productListBox.Items.Clear();
            List<Product> products = productList.getProductList;
            foreach (Product product in products)
            {
                productListBox.Items.Add(product.getName);
            }
        }
        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check if a product is selected in listBox, run UpdateTextBoxes with the selected product
            if (productListBox.SelectedIndex != -1)
            {
                Product selectedProduct = productList.getProductList[productListBox.SelectedIndex];
                // clears textboxes, then updates their text with the values from the selected product
                ClearTextBoxes();
                UpdateTextBoxes(selectedProduct);
            }
        }

        // clears all text in textBoxes
        private void ClearTextBoxes()
        {
            nameBox.Text = string.Empty;
            stockBox.Text = string.Empty;
            buyPriceBox.Text = string.Empty;
            sellPriceBox.Text = string.Empty;
            securityTagBox.SelectedIndex = 0;
            subscriptionBox.SelectedIndex = 0;
            limitedStockBox.SelectedIndex = 0;
            needManagerBox.SelectedIndex = 0;
            lockedCaseBox.SelectedIndex = 0;

        }

        // display values of the selected products attributes in the corresponding textBoxes.
        private void UpdateTextBoxes(Product product)
        {

            nameBox.Text = product.getName;

            // checks if stock attribute has a value, and displays it. if value is null, displays "null" as stock.
            if (product.getStock != null) { stockBox.Text = product.getStock.ToString(); }
            else { stockBox.Text = "null"; }

            buyPriceBox.Text = product.getBuyPrice.ToString();
            sellPriceBox.Text = product.getSellPrice.ToString();
            if (product.getStock != null) { limitedStockBox.SelectedIndex = 1; }

            // check if product is of the PhysicalProduct class, and if so, display attributes from that class
            if (product is PhysicalProduct)
            {
                PhysicalProduct physicalProduct = (PhysicalProduct)product;
                if (physicalProduct.getSecurityTag == true) { securityTagBox.SelectedIndex = 1; }
                else {  securityTagBox.SelectedIndex = 0; }
            }

            // same as before, but with the DigitalProduct class
            if (product is DigitalProduct)
            {
                DigitalProduct digitalProduct = (DigitalProduct)product;
                if (digitalProduct.getSubscription == true) { subscriptionBox.SelectedIndex = 1; }
                else { subscriptionBox.SelectedIndex = 0; }
                if (digitalProduct.getLimitedStock == true) { limitedStockBox.SelectedIndex = 1; }
                else { limitedStockBox.SelectedIndex = 0; }
                securityTagBox.SelectedIndex = -1;
            }
            else { subscriptionBox.SelectedIndex = -1; limitedStockBox.SelectedIndex= -1; }


            // same as before, but with the HighPriceItem class
            if (product is HighPriceItem)
            {
                HighPriceItem highPriceItem = (HighPriceItem)product;
                if (highPriceItem.getNeedManager == true) { needManagerBox.SelectedIndex = 1; }
                else { needManagerBox.SelectedIndex = 0; }
                if (highPriceItem.getLockedCase == true) { lockedCaseBox.SelectedIndex = 1; }
                else { lockedCaseBox.SelectedIndex = 0; }
            }
            else { needManagerBox.SelectedIndex = -1; lockedCaseBox.SelectedIndex= -1; }
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            //open a new form to create a new product, with Form1 as owner
            NewProductForm productForm = new NewProductForm();
            productForm.Owner = this; // Set Form1 as the owner
            productForm.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //check if any product is selected, and remove that product and load the listbox again.
            if (productListBox.SelectedIndex != -1)
            {
                Product selectedProduct = productList.getProductList[productListBox.SelectedIndex];
                // clears textboxes, then updates their text with the values from the selected product
                productList.removeProduct(selectedProduct);
                loadListBox();
            }
        }

        //method to change the attributes of selected product
        //checks if the inputted value is correct datatype, and then submits changes
        private void updateProduct(Product product)
        {
            InputChecker inputChecker = new InputChecker();
            if (inputChecker.inputChecker(nameBox.Text, 1) == true) { product.setName(nameBox.Text); }
            string tryStock = stockBox.Text;
            int stockResult;
            if (int.TryParse(tryStock,out stockResult) == true) { product.setStock(stockResult); }
            // if input is blank or null stock will be nullified
            else if (stockBox.Text == "") { product.setStock(null); }
            else if (stockBox.Text == "null") { product.setStock(null); }
            string tryBuyPrice = buyPriceBox.Text;
            int buyResult;
            if (int.TryParse(tryBuyPrice,out buyResult) == true) { product.setBuyPrice(buyResult); }
            // if no input is made on buyPrice, it will default to 0
            else if (buyPriceBox.Text == "") { product.setBuyPrice(0); }
            else { product.setBuyPrice(0); }
            string trySellPrice = sellPriceBox.Text;
            int sellResult;
            if (int.TryParse(trySellPrice, out sellResult) == true) { product.setSellPrice(sellResult); }
            // if no input is made on sellPrice, it will default to 0
            else if (sellPriceBox.Text == "") { product.setSellPrice(0); }
            else { product.setSellPrice(0); }

            //check if product is physical product, and if so, change if values on dropdown are changed
            if (product is PhysicalProduct)
            {
                PhysicalProduct physicalProduct = (PhysicalProduct)product;
                if (securityTagBox.SelectedIndex == 1) { physicalProduct.setSecurityTag(true); }
                else { physicalProduct.setSecurityTag(false); }
            }
            // same as before, but with the DigitalProduct class
            if (product is DigitalProduct)
            {
                DigitalProduct digitalProduct = (DigitalProduct)product;
                if (subscriptionBox.SelectedIndex == 1) { digitalProduct.setSubscription(true); }
                else { digitalProduct.setSubscription(false); }
                if (limitedStockBox.SelectedIndex == 1) { digitalProduct.setLimitedStock(true); }
                else { digitalProduct.setLimitedStock(false); }
            }
            // same as before, but with the HighPriceItem class
            if (product is HighPriceItem)
            {
                HighPriceItem highPriceItem = (HighPriceItem)product;
                if (lockedCaseBox.SelectedIndex == 1) { highPriceItem.setLockedCase(true); }
                else { highPriceItem.setLockedCase(false); }
                if (needManagerBox.SelectedIndex == 1) { highPriceItem.setNeedManager(true); }
                else { highPriceItem.setNeedManager(false); }
            }
        }

        //runs updateProduct when submit button is clicked and then loads the list and textboxes again to show changes
        private void submitButton_Click(object sender, EventArgs e)
        {
            //check if any product is selected, and remove that product and load the listbox again.
            if (productListBox.SelectedIndex != -1)
            {
                Product selectedProduct = productList.getProductList[productListBox.SelectedIndex];
                // clears textboxes, then updates their text with the values from the selected product
                updateProduct(selectedProduct);
                loadListBox();
                UpdateTextBoxes(selectedProduct);
            }
        }
    }
}
