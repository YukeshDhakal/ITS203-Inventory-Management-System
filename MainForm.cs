using SmartInventorySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SmartRepositorySystem
{
    public partial class MainForm : Form
    {
        private List<PerishableItem> _inventory;
        private string _currentFilter = "";

        public MainForm()
        {
            InitializeComponent();
            LoadInventory();
            UpdateInventoryDisplay();
            UpdateStatistics();
            CheckAlerts();
        }

        private void LoadInventory()
        {
            try
            {
                _inventory = DataManager.LoadData();
                UpdateStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading inventory: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _inventory = new List<PerishableItem>();
            }
        }

        private void SaveInventory()
        {
            try
            {
                DataManager.SaveData(_inventory);
                UpdateStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving inventory: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatistics()
        {
            // Update total items count
            lblTotalItems.Text = $"Total Items: {_inventory.Count}";

            // Calculate total inventory value
            decimal totalValue = _inventory.Sum(item => item.Price * item.Quantity);
            lblTotalValue.Text = $"Total Inventory Value: ${totalValue:F2}";

            // Count low stock items
            int lowStockCount = _inventory.Count(item => item.IsLowStock());
            lblLowStockCount.Text = $"Low Stock Items: {lowStockCount}";

            // Change color if there are low stock items
            if (lowStockCount > 0)
            {
                lblLowStockCount.ForeColor = System.Drawing.Color.OrangeRed;
            }
            else
            {
                lblLowStockCount.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void UpdateInventoryDisplay()
        {
            try
            {
                var displayList = _inventory.AsEnumerable();

                // Apply search/filter
                if (!string.IsNullOrWhiteSpace(_currentFilter))
                {
                    displayList = displayList.Where(item =>
                        item.ItemCode.ToLower().Contains(_currentFilter.ToLower()) ||
                        item.Name.ToLower().Contains(_currentFilter.ToLower())
                    );
                }

                lstInventory.Items.Clear();
                foreach (var item in displayList)
                {
                    // Add indicator for low stock or expired items
                    string indicator = "";
                    if (item.IsLowStock()) indicator = "⚠️ ";
                    if (item.IsExpired()) indicator = "❌ ";

                    lstInventory.Items.Add($"{indicator}{item.GetDetails()}");
                }

                toolStripStatusLabel.Text = $"Ready | Showing {lstInventory.Items.Count} of {_inventory.Count} items";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying inventory: {ex.Message}", "Display Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSelectedItemDetails(PerishableItem item)
        {
            if (item != null)
            {
                lblItemCodeValue.Text = $"Item Code: {item.ItemCode}";
                lblNameValue.Text = $"Name: {item.Name}";
                lblQuantityValue.Text = $"Quantity: {item.Quantity}";
                lblPriceValue.Text = $"Price: ${item.Price:F2}";
                lblExpiryValue.Text = $"Expiration Date: {item.ExpirationDate:yyyy-MM-dd}";

                // Set status with color
                if (item.IsExpired())
                {
                    lblStatusValue.Text = "Status: ❌ EXPIRED";
                    lblStatusValue.ForeColor = System.Drawing.Color.Red;
                }
                else if (item.IsLowStock())
                {
                    lblStatusValue.Text = "Status: ⚠️ LOW STOCK";
                    lblStatusValue.ForeColor = System.Drawing.Color.Orange;
                }
                else if (item.IsNearExpiry(7))
                {
                    lblStatusValue.Text = "Status: ⏰ NEAR EXPIRY";
                    lblStatusValue.ForeColor = System.Drawing.Color.Orange;
                }
                else
                {
                    lblStatusValue.Text = "Status: ✓ OK";
                    lblStatusValue.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblItemCodeValue.Text = "Item Code: --";
                lblNameValue.Text = "Name: --";
                lblQuantityValue.Text = "Quantity: --";
                lblPriceValue.Text = "Price: --";
                lblExpiryValue.Text = "Expiration Date: --";
                lblStatusValue.Text = "Status: --";
            }
        }

        private void CheckAlerts()
        {
            // Low Stock Alerts
            var lowStockItems = _inventory.Where(item => item.IsLowStock()).ToList();
            if (lowStockItems.Any())
            {
                string message = "⚠️ LOW STOCK ALERT ⚠️\n\nThe following items are running low:\n\n";
                foreach (var item in lowStockItems)
                {
                    message += $"• {item.Name}: {item.Quantity} left (Threshold: {item.LowStockThreshold})\n";
                }
                message += "\nWould you like to restock these items?";

                var result = MessageBox.Show(message, "Stock Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Select first low stock item to restock
                    var itemToRestock = lowStockItems.First();
                    using (var restockForm = new RestockForm(itemToRestock))
                    {
                        restockForm.ShowDialog();
                        if (restockForm.QuantityToAdd > 0)
                        {
                            itemToRestock.Quantity += restockForm.QuantityToAdd;
                            SaveInventory();
                            UpdateInventoryDisplay();
                        }
                    }
                }
            }

            // Expired Items
            var expiredItems = _inventory.Where(item => item.IsExpired()).ToList();
            if (expiredItems.Any())
            {
                string message = "❌ EXPIRED ITEMS DETECTED ❌\n\nThe following items have expired and should be disposed:\n\n";
                foreach (var item in expiredItems)
                {
                    message += $"• {item.Name} (Expired on: {item.ExpirationDate:yyyy-MM-dd})\n";
                }
                MessageBox.Show(message, "Expiry Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ADD Button
        private void button1_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddItemForm())
            {
                addForm.ShowDialog();
                if (!addForm.IsCancelled && addForm.NewItem != null)
                {
                    if (_inventory.Any(item => item.ItemCode == addForm.NewItem.ItemCode))
                    {
                        MessageBox.Show($"Item code '{addForm.NewItem.ItemCode}' already exists.",
                            "Duplicate Item Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    _inventory.Add(addForm.NewItem);
                    SaveInventory();
                    UpdateInventoryDisplay();
                    UpdateStatistics();
                    CheckAlerts();
                    MessageBox.Show($"Item '{addForm.NewItem.Name}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // REMOVE Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (lstInventory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedDetails = lstInventory.SelectedItem.ToString();
            // Remove the indicator prefix if present
            selectedDetails = selectedDetails.Replace("⚠️ ", "").Replace("❌ ", "");

            var selectedItem = _inventory.FirstOrDefault(item => item.GetDetails() == selectedDetails);

            if (selectedItem != null)
            {
                var confirmResult = MessageBox.Show($"Are you sure you want to remove {selectedItem.Name}?", "Confirm Remove",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    _inventory.Remove(selectedItem);
                    SaveInventory();
                    UpdateInventoryDisplay();
                    UpdateStatistics();
                    UpdateSelectedItemDetails(null);
                    MessageBox.Show($"{selectedItem.Name} has been removed.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // RESTOCK Button
        private void button3_Click(object sender, EventArgs e)
        {
            if (lstInventory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to restock.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedDetails = lstInventory.SelectedItem.ToString();
            selectedDetails = selectedDetails.Replace("⚠️ ", "").Replace("❌ ", "");
            var selectedItem = _inventory.FirstOrDefault(item => item.GetDetails() == selectedDetails);

            if (selectedItem != null)
            {
                using (var restockForm = new RestockForm(selectedItem))
                {
                    restockForm.ShowDialog();
                    if (restockForm.QuantityToAdd > 0)
                    {
                        selectedItem.Quantity += restockForm.QuantityToAdd;
                        SaveInventory();
                        UpdateInventoryDisplay();
                        UpdateStatistics();
                        UpdateSelectedItemDetails(selectedItem);
                        CheckAlerts();
                        MessageBox.Show($"Added {restockForm.QuantityToAdd} units to {selectedItem.Name}.\n\nNew quantity: {selectedItem.Quantity}",
                            "Restock Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        // DISPOSE Button
        private void button4_Click(object sender, EventArgs e)
        {
            if (lstInventory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to dispose.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedDetails = lstInventory.SelectedItem.ToString();
            selectedDetails = selectedDetails.Replace("⚠️ ", "").Replace("❌ ", "");
            var selectedItem = _inventory.FirstOrDefault(item => item.GetDetails() == selectedDetails);

            if (selectedItem != null)
            {
                using (var disposeForm = new DisposeForm(selectedItem))
                {
                    disposeForm.ShowDialog();
                    if (disposeForm.QuantityToDispose > 0)
                    {
                        selectedItem.Quantity -= disposeForm.QuantityToDispose;
                        if (selectedItem.Quantity < 0) selectedItem.Quantity = 0;

                        if (selectedItem.Quantity == 0)
                        {
                            var removeResult = MessageBox.Show($"{selectedItem.Name} quantity is now 0. Remove from inventory?",
                                "Remove Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (removeResult == DialogResult.Yes)
                            {
                                _inventory.Remove(selectedItem);
                                UpdateSelectedItemDetails(null);
                                MessageBox.Show($"{selectedItem.Name} has been removed.", "Item Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            UpdateSelectedItemDetails(selectedItem);
                        }

                        SaveInventory();
                        UpdateInventoryDisplay();
                        UpdateStatistics();
                        CheckAlerts();
                        MessageBox.Show($"Disposed {disposeForm.QuantityToDispose} units of {selectedItem.Name}.\n\nNew quantity: {selectedItem.Quantity}",
                            "Disposal Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        // REFRESH Button
        private void button5_Click(object sender, EventArgs e)
        {
            LoadInventory();
            UpdateInventoryDisplay();
            UpdateStatistics();
            CheckAlerts();
            toolStripStatusLabel.Text = "Ready | Inventory refreshed from database";
            MessageBox.Show("Inventory has been refreshed.", "Refresh Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // SEARCH Text Changed
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _currentFilter = txtSearch.Text;
            UpdateInventoryDisplay();
        }

        // ListBox Selection Changed
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstInventory.SelectedIndex != -1)
            {
                var selectedDetails = lstInventory.SelectedItem.ToString();
                selectedDetails = selectedDetails.Replace("⚠️ ", "").Replace("❌ ", "");
                var selectedItem = _inventory.FirstOrDefault(item => item.GetDetails() == selectedDetails);
                UpdateSelectedItemDetails(selectedItem);
            }
            else
            {
                UpdateSelectedItemDetails(null);
            }
        }

        // Form Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "Smart Inventory Management System";
        }
    }
}