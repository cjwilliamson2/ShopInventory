namespace ShopInventory
{
    partial class frmAddItem
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
            lblName = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(41, 46);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(41, 98);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(41, 147);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price:";
            // 
            // txtName
            // 
            txtName.Location = new Point(119, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(119, 95);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(119, 144);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 5;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(22, 206);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(144, 206);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 264);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(lblPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblName);
            Name = "frmAddItem";
            Text = "Add Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblQuantity;
        private Label lblPrice;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button btnOK;
        private Button btnCancel;
    }
}