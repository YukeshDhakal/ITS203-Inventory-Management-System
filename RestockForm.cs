using SmartInventorySystem;
using System;
using System.Windows.Forms;

namespace SmartRepositorySystem
{
    public partial class RestockForm : Form
    {
        public int QuantityToAdd { get; private set; }
        private PerishableItem _item;

        public RestockForm(PerishableItem item)
        {
            InitializeComponent();
            _item = item;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            QuantityToAdd = (int)numQuantity.Value;
            if (QuantityToAdd <= 0)
            {
                MessageBox.Show("Please enter a quantity greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            QuantityToAdd = 0;
            this.Close();
        }
    }
}