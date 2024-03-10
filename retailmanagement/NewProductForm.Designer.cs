namespace retailmanagement
{
    partial class NewProductForm
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
            this.classSelector = new System.Windows.Forms.ComboBox();
            this.subscriptionLabel = new System.Windows.Forms.Label();
            this.managerLabel = new System.Windows.Forms.Label();
            this.limitedLabel = new System.Windows.Forms.Label();
            this.securityLabel = new System.Windows.Forms.Label();
            this.lockedLabel = new System.Windows.Forms.Label();
            this.sellLabel = new System.Windows.Forms.Label();
            this.buyLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sellPriceBox = new System.Windows.Forms.TextBox();
            this.buyPriceBox = new System.Windows.Forms.TextBox();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.needManagerSelector = new System.Windows.Forms.ComboBox();
            this.subscriptionSelector = new System.Windows.Forms.ComboBox();
            this.limitedStockSelector = new System.Windows.Forms.ComboBox();
            this.securityTagSelector = new System.Windows.Forms.ComboBox();
            this.lockedCaseSelector = new System.Windows.Forms.ComboBox();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classSelector
            // 
            this.classSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classSelector.FormattingEnabled = true;
            this.classSelector.Location = new System.Drawing.Point(25, 69);
            this.classSelector.Name = "classSelector";
            this.classSelector.Size = new System.Drawing.Size(164, 24);
            this.classSelector.TabIndex = 0;
            this.classSelector.SelectedIndexChanged += new System.EventHandler(this.classSelector_SelectedIndexChanged);
            // 
            // subscriptionLabel
            // 
            this.subscriptionLabel.AutoSize = true;
            this.subscriptionLabel.Location = new System.Drawing.Point(632, 113);
            this.subscriptionLabel.Name = "subscriptionLabel";
            this.subscriptionLabel.Size = new System.Drawing.Size(81, 16);
            this.subscriptionLabel.TabIndex = 37;
            this.subscriptionLabel.Text = "Subscription";
            // 
            // managerLabel
            // 
            this.managerLabel.AutoSize = true;
            this.managerLabel.Location = new System.Drawing.Point(621, 170);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(98, 16);
            this.managerLabel.TabIndex = 36;
            this.managerLabel.Text = "Need Manager";
            // 
            // limitedLabel
            // 
            this.limitedLabel.AutoSize = true;
            this.limitedLabel.Location = new System.Drawing.Point(632, 50);
            this.limitedLabel.Name = "limitedLabel";
            this.limitedLabel.Size = new System.Drawing.Size(87, 16);
            this.limitedLabel.TabIndex = 35;
            this.limitedLabel.Text = "Limited Stock";
            // 
            // securityLabel
            // 
            this.securityLabel.AutoSize = true;
            this.securityLabel.Location = new System.Drawing.Point(462, 170);
            this.securityLabel.Name = "securityLabel";
            this.securityLabel.Size = new System.Drawing.Size(83, 16);
            this.securityLabel.TabIndex = 34;
            this.securityLabel.Text = "Security Tag";
            // 
            // lockedLabel
            // 
            this.lockedLabel.AutoSize = true;
            this.lockedLabel.Location = new System.Drawing.Point(288, 170);
            this.lockedLabel.Name = "lockedLabel";
            this.lockedLabel.Size = new System.Drawing.Size(100, 16);
            this.lockedLabel.TabIndex = 33;
            this.lockedLabel.Text = "In Locked Case";
            // 
            // sellLabel
            // 
            this.sellLabel.AutoSize = true;
            this.sellLabel.Location = new System.Drawing.Point(471, 113);
            this.sellLabel.Name = "sellLabel";
            this.sellLabel.Size = new System.Drawing.Size(64, 16);
            this.sellLabel.TabIndex = 32;
            this.sellLabel.Text = "Sell Price";
            // 
            // buyLabel
            // 
            this.buyLabel.AutoSize = true;
            this.buyLabel.Location = new System.Drawing.Point(308, 113);
            this.buyLabel.Name = "buyLabel";
            this.buyLabel.Size = new System.Drawing.Size(64, 16);
            this.buyLabel.TabIndex = 31;
            this.buyLabel.Text = "Buy Price";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(485, 50);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(41, 16);
            this.stockLabel.TabIndex = 30;
            this.stockLabel.Text = "Stock";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(317, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 28;
            this.nameLabel.Text = "Name";
            // 
            // sellPriceBox
            // 
            this.sellPriceBox.Location = new System.Drawing.Point(438, 132);
            this.sellPriceBox.Name = "sellPriceBox";
            this.sellPriceBox.Size = new System.Drawing.Size(132, 22);
            this.sellPriceBox.TabIndex = 25;
            // 
            // buyPriceBox
            // 
            this.buyPriceBox.Location = new System.Drawing.Point(274, 132);
            this.buyPriceBox.Name = "buyPriceBox";
            this.buyPriceBox.Size = new System.Drawing.Size(132, 22);
            this.buyPriceBox.TabIndex = 24;
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(438, 69);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(132, 22);
            this.stockBox.TabIndex = 22;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(274, 69);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 22);
            this.nameBox.TabIndex = 21;
            // 
            // needManagerSelector
            // 
            this.needManagerSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.needManagerSelector.FormattingEnabled = true;
            this.needManagerSelector.Location = new System.Drawing.Point(604, 190);
            this.needManagerSelector.Name = "needManagerSelector";
            this.needManagerSelector.Size = new System.Drawing.Size(132, 24);
            this.needManagerSelector.TabIndex = 38;
            // 
            // subscriptionSelector
            // 
            this.subscriptionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subscriptionSelector.FormattingEnabled = true;
            this.subscriptionSelector.Location = new System.Drawing.Point(604, 132);
            this.subscriptionSelector.Name = "subscriptionSelector";
            this.subscriptionSelector.Size = new System.Drawing.Size(132, 24);
            this.subscriptionSelector.TabIndex = 39;
            // 
            // limitedStockSelector
            // 
            this.limitedStockSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.limitedStockSelector.FormattingEnabled = true;
            this.limitedStockSelector.Location = new System.Drawing.Point(604, 69);
            this.limitedStockSelector.Name = "limitedStockSelector";
            this.limitedStockSelector.Size = new System.Drawing.Size(132, 24);
            this.limitedStockSelector.TabIndex = 40;
            // 
            // securityTagSelector
            // 
            this.securityTagSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.securityTagSelector.FormattingEnabled = true;
            this.securityTagSelector.Location = new System.Drawing.Point(438, 190);
            this.securityTagSelector.Name = "securityTagSelector";
            this.securityTagSelector.Size = new System.Drawing.Size(132, 24);
            this.securityTagSelector.TabIndex = 41;
            // 
            // lockedCaseSelector
            // 
            this.lockedCaseSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lockedCaseSelector.FormattingEnabled = true;
            this.lockedCaseSelector.Location = new System.Drawing.Point(274, 190);
            this.lockedCaseSelector.Name = "lockedCaseSelector";
            this.lockedCaseSelector.Size = new System.Drawing.Size(132, 24);
            this.lockedCaseSelector.TabIndex = 42;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(25, 157);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(164, 43);
            this.createButton.TabIndex = 43;
            this.createButton.Text = "Add Item";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.lockedCaseSelector);
            this.Controls.Add(this.securityTagSelector);
            this.Controls.Add(this.limitedStockSelector);
            this.Controls.Add(this.subscriptionSelector);
            this.Controls.Add(this.needManagerSelector);
            this.Controls.Add(this.subscriptionLabel);
            this.Controls.Add(this.managerLabel);
            this.Controls.Add(this.limitedLabel);
            this.Controls.Add(this.securityLabel);
            this.Controls.Add(this.lockedLabel);
            this.Controls.Add(this.sellLabel);
            this.Controls.Add(this.buyLabel);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.sellPriceBox);
            this.Controls.Add(this.buyPriceBox);
            this.Controls.Add(this.stockBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.classSelector);
            this.Name = "NewProductForm";
            this.Text = "NewProductForm";
            this.Load += new System.EventHandler(this.NewProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classSelector;
        private System.Windows.Forms.Label subscriptionLabel;
        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.Label limitedLabel;
        private System.Windows.Forms.Label securityLabel;
        private System.Windows.Forms.Label lockedLabel;
        private System.Windows.Forms.Label sellLabel;
        private System.Windows.Forms.Label buyLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox sellPriceBox;
        private System.Windows.Forms.TextBox buyPriceBox;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox needManagerSelector;
        private System.Windows.Forms.ComboBox subscriptionSelector;
        private System.Windows.Forms.ComboBox limitedStockSelector;
        private System.Windows.Forms.ComboBox securityTagSelector;
        private System.Windows.Forms.ComboBox lockedCaseSelector;
        private System.Windows.Forms.Button createButton;
    }
}