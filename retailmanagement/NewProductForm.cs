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
        List<ComboBox> dropdowns = new List<ComboBox>(); // list containing all bool dropdowns
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

            // add bool dropdowns to dropdown list
            dropdowns.Add(limitedStockSelector);
            dropdowns.Add(subscriptionSelector);
            dropdowns.Add(lockedCaseSelector);
            dropdowns.Add(securityTagSelector);
            dropdowns.Add(needManagerSelector);

            foreach (ComboBox comboBox in dropdowns) // add true/false to all bool dropdowns, and show false as default
            {
                comboBox.Items.Add("False");
                comboBox.Items.Add("True");
                comboBox.SelectedIndex = 0;
            }

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
            if (selectedClass == 0) { errorLabel.Text = "Error, please check \n inputs and selected values"; }
        //    else if (inputChecker.inputChecker(nameBox.Text, 1) is bool) { errorLabel.Text = "Error, please check \n inputs and selected values"; }
        //funkar inte just nu    else if (inputChecker.inputChecker(int.Parse(stockBox.Text), 2) is bool) { errorLabel.Text = "Error, please check \n inputs and selected values"; }
            else
            {
                Form1 form1 = (Form1)this.Owner;
                errorLabel.Text = string.Empty;
                bool output = form1.addProduct(nameBox.Text, int.Parse(stockBox.Text), selectedClass);
                if (output != true) { errorLabel.Text = "Error when adding class"; }
                else if (output == true) { this.Close(); form1.loadListBox(); }
            }
        }
    }
}
