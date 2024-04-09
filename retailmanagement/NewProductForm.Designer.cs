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
            this.stockLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // classSelector
            // 
            this.classSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classSelector.FormattingEnabled = true;
            this.classSelector.Location = new System.Drawing.Point(25, 69);
            this.classSelector.Name = "classSelector";
            this.classSelector.Size = new System.Drawing.Size(220, 24);
            this.classSelector.TabIndex = 0;
            this.classSelector.SelectedIndexChanged += new System.EventHandler(this.classSelector_SelectedIndexChanged);
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(613, 50);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(41, 16);
            this.stockLabel.TabIndex = 30;
            this.stockLabel.Text = "Stock";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(355, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 16);
            this.nameLabel.TabIndex = 28;
            this.nameLabel.Text = "* Name";
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(518, 69);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(220, 22);
            this.stockBox.TabIndex = 22;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(274, 69);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(220, 22);
            this.nameBox.TabIndex = 21;
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
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(22, 113);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 16);
            this.errorLabel.TabIndex = 44;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Fields with a \" * \" are required";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(311, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "To add a new item, please enter name and (optional) stock, then change attributes" +
    " in the main page.";
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.nameLabel);
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
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}