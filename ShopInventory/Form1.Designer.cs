namespace ShopInventory
{
    partial class frmShopInventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstInventory = new ListBox();
            btnAddItem = new Button();
            btnClearAll = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lstInventory
            // 
            lstInventory.FormattingEnabled = true;
            lstInventory.ItemHeight = 15;
            lstInventory.Location = new Point(30, 26);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(280, 139);
            lstInventory.TabIndex = 0;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(340, 26);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(340, 83);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(75, 23);
            btnClearAll.TabIndex = 2;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(340, 142);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmShopInventory
            // 
            AcceptButton = btnAddItem;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(437, 208);
            Controls.Add(btnExit);
            Controls.Add(btnClearAll);
            Controls.Add(btnAddItem);
            Controls.Add(lstInventory);
            Name = "frmShopInventory";
            Text = "Shop Inventory";
            Load += frmShopInventory_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstInventory;
        private Button btnAddItem;
        private Button btnClearAll;
        private Button btnExit;
    }
}