namespace ShopInventory
{
    public partial class frmShopInventory : Form
    {
        public frmShopInventory()
        {
            InitializeComponent();
        }

        public List<string> items = new List<string>();

        private void frmShopInventory_Load(object sender, EventArgs e)
        {
            items.Clear();
            items.Add("Name, Quantity, Price");
            ReloadItemListbox(items[0]);
        }

        private void ReloadItemListbox(string item)
        {
            lstInventory.Items.Add(item);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Form addItem = new frmAddItem();
            DialogResult = addItem.ShowDialog();

            if (DialogResult == DialogResult.OK)
            {
                items.Add(addItem.Tag.ToString());
                ReloadItemListbox(items.Last());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstInventory.Items.Clear();
            items.Clear();

            items.Add("Name, Quantity, Price");
            ReloadItemListbox(items[0]);
        }
    }
}