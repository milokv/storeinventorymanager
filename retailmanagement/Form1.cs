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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PhysicalProduct Toy = new PhysicalProduct("toy");
            Toy.setBuyPrice(15);
            Toy.setSellPrice(20);
            Toy.setSecurityTag(false);
            Toy.setStock(1);
            this.productListBox.Items.Add(Toy.getName);
            if (Toy.getStock == null)
            {
                this.productListBox.Items.Add("null");
            }
            else { this.productListBox.Items.Add(Toy.getStock); }
        }
    }
}
