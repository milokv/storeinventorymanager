﻿namespace retailmanagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buyPriceBox = new System.Windows.Forms.TextBox();
            this.sellPriceBox = new System.Windows.Forms.TextBox();
            this.lockedCaseBox = new System.Windows.Forms.TextBox();
            this.securityTagBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.needManagerBox = new System.Windows.Forms.TextBox();
            this.stockLabel = new System.Windows.Forms.Label();
            this.buyLabel = new System.Windows.Forms.Label();
            this.sellLabel = new System.Windows.Forms.Label();
            this.lockedLabel = new System.Windows.Forms.Label();
            this.securityLabel = new System.Windows.Forms.Label();
            this.limitedLabel = new System.Windows.Forms.Label();
            this.managerLabel = new System.Windows.Forms.Label();
            this.subscriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 16;
            this.productListBox.Location = new System.Drawing.Point(34, 23);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(322, 452);
            this.productListBox.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(736, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(406, 52);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 22);
            this.nameBox.TabIndex = 2;
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(570, 52);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(132, 22);
            this.stockBox.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(736, 115);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 4;
            // 
            // buyPriceBox
            // 
            this.buyPriceBox.Location = new System.Drawing.Point(406, 115);
            this.buyPriceBox.Name = "buyPriceBox";
            this.buyPriceBox.Size = new System.Drawing.Size(132, 22);
            this.buyPriceBox.TabIndex = 5;
            // 
            // sellPriceBox
            // 
            this.sellPriceBox.Location = new System.Drawing.Point(570, 115);
            this.sellPriceBox.Name = "sellPriceBox";
            this.sellPriceBox.Size = new System.Drawing.Size(132, 22);
            this.sellPriceBox.TabIndex = 6;
            // 
            // lockedCaseBox
            // 
            this.lockedCaseBox.Location = new System.Drawing.Point(406, 172);
            this.lockedCaseBox.Name = "lockedCaseBox";
            this.lockedCaseBox.Size = new System.Drawing.Size(132, 22);
            this.lockedCaseBox.TabIndex = 8;
            // 
            // securityTagBox
            // 
            this.securityTagBox.Location = new System.Drawing.Point(570, 172);
            this.securityTagBox.Name = "securityTagBox";
            this.securityTagBox.Size = new System.Drawing.Size(132, 22);
            this.securityTagBox.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(449, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name";
            // 
            // needManagerBox
            // 
            this.needManagerBox.Location = new System.Drawing.Point(736, 172);
            this.needManagerBox.Name = "needManagerBox";
            this.needManagerBox.Size = new System.Drawing.Size(132, 22);
            this.needManagerBox.TabIndex = 11;
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(617, 33);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(41, 16);
            this.stockLabel.TabIndex = 12;
            this.stockLabel.Text = "Stock";
            // 
            // buyLabel
            // 
            this.buyLabel.AutoSize = true;
            this.buyLabel.Location = new System.Drawing.Point(440, 96);
            this.buyLabel.Name = "buyLabel";
            this.buyLabel.Size = new System.Drawing.Size(64, 16);
            this.buyLabel.TabIndex = 13;
            this.buyLabel.Text = "Buy Price";
            // 
            // sellLabel
            // 
            this.sellLabel.AutoSize = true;
            this.sellLabel.Location = new System.Drawing.Point(603, 96);
            this.sellLabel.Name = "sellLabel";
            this.sellLabel.Size = new System.Drawing.Size(64, 16);
            this.sellLabel.TabIndex = 14;
            this.sellLabel.Text = "Sell Price";
            // 
            // lockedLabel
            // 
            this.lockedLabel.AutoSize = true;
            this.lockedLabel.Location = new System.Drawing.Point(420, 153);
            this.lockedLabel.Name = "lockedLabel";
            this.lockedLabel.Size = new System.Drawing.Size(100, 16);
            this.lockedLabel.TabIndex = 15;
            this.lockedLabel.Text = "In Locked Case";
            // 
            // securityLabel
            // 
            this.securityLabel.AutoSize = true;
            this.securityLabel.Location = new System.Drawing.Point(594, 153);
            this.securityLabel.Name = "securityLabel";
            this.securityLabel.Size = new System.Drawing.Size(83, 16);
            this.securityLabel.TabIndex = 16;
            this.securityLabel.Text = "Security Tag";
            // 
            // limitedLabel
            // 
            this.limitedLabel.AutoSize = true;
            this.limitedLabel.Location = new System.Drawing.Point(764, 33);
            this.limitedLabel.Name = "limitedLabel";
            this.limitedLabel.Size = new System.Drawing.Size(87, 16);
            this.limitedLabel.TabIndex = 17;
            this.limitedLabel.Text = "Limited Stock";
            // 
            // managerLabel
            // 
            this.managerLabel.AutoSize = true;
            this.managerLabel.Location = new System.Drawing.Point(753, 153);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(98, 16);
            this.managerLabel.TabIndex = 18;
            this.managerLabel.Text = "Need Manager";
            // 
            // subscriptionLabel
            // 
            this.subscriptionLabel.AutoSize = true;
            this.subscriptionLabel.Location = new System.Drawing.Point(764, 96);
            this.subscriptionLabel.Name = "subscriptionLabel";
            this.subscriptionLabel.Size = new System.Drawing.Size(81, 16);
            this.subscriptionLabel.TabIndex = 19;
            this.subscriptionLabel.Text = "Subscription";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 504);
            this.Controls.Add(this.subscriptionLabel);
            this.Controls.Add(this.managerLabel);
            this.Controls.Add(this.limitedLabel);
            this.Controls.Add(this.securityLabel);
            this.Controls.Add(this.lockedLabel);
            this.Controls.Add(this.sellLabel);
            this.Controls.Add(this.buyLabel);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.needManagerBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.securityTagBox);
            this.Controls.Add(this.lockedCaseBox);
            this.Controls.Add(this.sellPriceBox);
            this.Controls.Add(this.buyPriceBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.stockBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.productListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox buyPriceBox;
        private System.Windows.Forms.TextBox sellPriceBox;
        private System.Windows.Forms.TextBox lockedCaseBox;
        private System.Windows.Forms.TextBox securityTagBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox needManagerBox;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label buyLabel;
        private System.Windows.Forms.Label sellLabel;
        private System.Windows.Forms.Label lockedLabel;
        private System.Windows.Forms.Label securityLabel;
        private System.Windows.Forms.Label limitedLabel;
        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.Label subscriptionLabel;
    }
}

