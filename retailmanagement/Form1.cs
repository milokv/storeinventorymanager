﻿using System;
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

            productList.addProduct(new HighPriceItem("Rolex", 14));
            productList.addProduct(new DigitalProduct("Fortnite Giftcard", null));
            loadListBox();
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
            securityTagBox.Text = string.Empty;
            subscriptionBox.Text = string.Empty;
            limitedStockBox.Text = string.Empty;
            needManagerBox.Text = string.Empty;
            lockedCaseBox.Text = string.Empty;

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

            // check if product is of the PhysicalProduct class, and if so, display attributes from that class
            if (product is PhysicalProduct)
            {
                PhysicalProduct physicalProduct = (PhysicalProduct)product;
                securityTagBox.Text = physicalProduct.getSecurityTag.ToString();
            }

            // same as before, but with the DigitalProduct class
            if (product is DigitalProduct)
            {
                DigitalProduct digitalProduct = (DigitalProduct)product;
                subscriptionBox.Text = digitalProduct.getSubscription.ToString();
                limitedStockBox.Text = digitalProduct?.getLimitedStock.ToString();
            }


            // same as before, but with the HighPriceItem class
            if (product is HighPriceItem)
            {
                HighPriceItem highPriceItem = (HighPriceItem)product;
                needManagerBox.Text = highPriceItem.getNeedManager.ToString();
                lockedCaseBox.Text = highPriceItem.getLockedCase.ToString();

            }
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
