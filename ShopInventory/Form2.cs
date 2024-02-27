using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopInventory
{
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string item = txtName.Text + ", " + txtQuantity.Text + ", " + txtPrice.Text;
            Tag = item;
            DialogResult = DialogResult.OK;
        }
    }
}
