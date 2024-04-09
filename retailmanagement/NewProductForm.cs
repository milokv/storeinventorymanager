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
    public partial class NewProductForm : Form
    {
        private bool submitReady = false; // bool for checking if all conditions are fulfilled, and new item is ready to be created
        private int selectedClass;
        InputChecker inputChecker = new InputChecker();
        public NewProductForm()
        {
            InitializeComponent();

            // add options to class picker dropdown menu
            classSelector.Items.Add("Select Product Type");
            classSelector.Items.Add("Digital Product");
            classSelector.Items.Add("Physical Product");
            classSelector.Items.Add("High-Priced Physical Product");

            classSelector.SelectedIndex = 0; // show "select product type" when form is loaded


        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {

        }

        private void classSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            // change selectedClass variable to the index of the selected class in the dropdown menu
            selectedClass = classSelector.SelectedIndex;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // create new item, error handling to handle blank or invalid inputs on stock and name.
            if (selectedClass == 0) { errorLabel.Text = "Error, please check \n inputs and selected values"; }
            else
            {
                Form1 form1 = (Form1)this.Owner;
                errorLabel.Text = string.Empty;
                string tryStock = stockBox.Text;
                int stockResult;
                if (int.TryParse(tryStock, out stockResult) != true)
                {
                    if (string.IsNullOrEmpty(stockBox.Text))
                    {
                        bool output = form1.addProduct(nameBox.Text, null, selectedClass);
                        if (output != true) { errorLabel.Text = "Error when adding item."; }
                        else if (output == true) { this.Close(); form1.loadListBox(); }
                    }
                    else { errorLabel.Text = "Please make Stock an integer or leave it as empty."; }
                }
                else if (stockBox.Text.Length > 0)
                {
                    bool output = form1.addProduct(nameBox.Text, stockResult, selectedClass);
                    if (output != true) { errorLabel.Text = "Error when adding item."; }
                    else if (output == true) { this.Close(); form1.loadListBox(); }
                }
                else { errorLabel.Text = "Error when adding item."; }
            }
        }
    }
}
