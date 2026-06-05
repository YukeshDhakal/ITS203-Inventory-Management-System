using SmartInventorySystem;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmartRepositorySystem
{
    public partial class AddItemForm : Form
    {
        public PerishableItem NewItem { get; private set; }
        public bool IsCancelled { get; private set; }

        public AddItemForm()
        {
            InitializeComponent();
            IsCancelled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtItemCode.Text))
                {
                    MessageBox.Show("Item Code is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Item Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create new item
                NewItem = new PerishableItem(
                    txtItemCode.Text.Trim(),
                    txtName.Text.Trim(),
                    (int)numQuantity.Value,
                    numPrice.Value,
                    (int)numLowStockThreshold.Value,
                    dtpExpirationDate.Value
                );

                IsCancelled = false;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsCancelled = true;
            this.Close();
        }
    }
}