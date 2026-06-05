using SmartInventorySystem;
using System;
using System.Windows.Forms;

namespace SmartRepositorySystem
{
    public partial class DisposeForm : Form
    {
        public int QuantityToDispose { get; private set; }
        private PerishableItem _item;

        public DisposeForm(PerishableItem item)
        {
            InitializeComponent();
            _item = item;
            lblItemInfo.Text = $"Disposing from: {_item.Name} (Current: {_item.Quantity})";
            numQuantity.Maximum = _item.Quantity;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            QuantityToDispose = (int)numQuantity.Value;
            if (QuantityToDispose <= 0)
            {
                MessageBox.Show("Please enter a quantity greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            QuantityToDispose = 0;
            this.Close();
        }
    }
}