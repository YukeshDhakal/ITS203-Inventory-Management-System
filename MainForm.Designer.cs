namespace SmartRepositorySystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Controls declaration
        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Button btnDispose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblLowStockCount;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.Label lblItemCodeValue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblQuantityValue;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblExpiryValue;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.btnDispose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblLowStockCount = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.lblItemCodeValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblQuantityValue = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblExpiryValue = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpInventory.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInventory
            // 
            this.grpInventory.Controls.Add(this.lstInventory);
            this.grpInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInventory.Location = new System.Drawing.Point(12, 12);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Size = new System.Drawing.Size(450, 550);
            this.grpInventory.TabIndex = 0;
            this.grpInventory.TabStop = false;
            this.grpInventory.Text = "📦 Inventory Items";
            // 
            // lstInventory
            // 
            this.lstInventory.BackColor = System.Drawing.Color.White;
            this.lstInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstInventory.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstInventory.IntegralHeight = false;
            this.lstInventory.ItemHeight = 20;
            this.lstInventory.Location = new System.Drawing.Point(10, 30);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(430, 505);
            this.lstInventory.TabIndex = 0;
            this.lstInventory.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.btnAdd);
            this.grpControls.Controls.Add(this.btnRemove);
            this.grpControls.Controls.Add(this.btnRestock);
            this.grpControls.Controls.Add(this.btnDispose);
            this.grpControls.Controls.Add(this.btnRefresh);
            this.grpControls.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpControls.Location = new System.Drawing.Point(475, 12);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(600, 130);
            this.grpControls.TabIndex = 1;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "🎮 Controls";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(15, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "➕ Add New Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(210, 30);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(180, 40);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "❌ Remove Item";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnRestock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestock.FlatAppearance.BorderSize = 0;
            this.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRestock.ForeColor = System.Drawing.Color.White;
            this.btnRestock.Location = new System.Drawing.Point(405, 30);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(180, 40);
            this.btnRestock.TabIndex = 2;
            this.btnRestock.Text = "📦 Restock Item";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDispose
            // 
            this.btnDispose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnDispose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDispose.FlatAppearance.BorderSize = 0;
            this.btnDispose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDispose.ForeColor = System.Drawing.Color.White;
            this.btnDispose.Location = new System.Drawing.Point(15, 80);
            this.btnDispose.Name = "btnDispose";
            this.btnDispose.Size = new System.Drawing.Size(180, 40);
            this.btnDispose.TabIndex = 3;
            this.btnDispose.Text = "🗑️ Dispose Damaged";
            this.btnDispose.UseVisualStyleBackColor = false;
            this.btnDispose.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(210, 80);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(180, 40);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.button5_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpSearch.Location = new System.Drawing.Point(475, 150);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(600, 60);
            this.grpSearch.TabIndex = 2;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "🔍 Search";
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearch.Location = new System.Drawing.Point(15, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(200, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search by Item Code or Name:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(220, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(360, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.lblTotalItems);
            this.grpStats.Controls.Add(this.lblTotalValue);
            this.grpStats.Controls.Add(this.lblLowStockCount);
            this.grpStats.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpStats.Location = new System.Drawing.Point(475, 220);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(290, 120);
            this.grpStats.TabIndex = 3;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "📊 Statistics";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalItems.Location = new System.Drawing.Point(15, 30);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(250, 25);
            this.lblTotalItems.TabIndex = 0;
            this.lblTotalItems.Text = "Total Items: 0";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalValue.Location = new System.Drawing.Point(15, 60);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(250, 25);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "Total Inventory Value: $0.00";
            // 
            // lblLowStockCount
            // 
            this.lblLowStockCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLowStockCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblLowStockCount.Location = new System.Drawing.Point(15, 90);
            this.lblLowStockCount.Name = "lblLowStockCount";
            this.lblLowStockCount.Size = new System.Drawing.Size(250, 25);
            this.lblLowStockCount.TabIndex = 2;
            this.lblLowStockCount.Text = "Low Stock Items: 0";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lblSelectedItem);
            this.grpDetails.Controls.Add(this.lblItemCodeValue);
            this.grpDetails.Controls.Add(this.lblNameValue);
            this.grpDetails.Controls.Add(this.lblQuantityValue);
            this.grpDetails.Controls.Add(this.lblPriceValue);
            this.grpDetails.Controls.Add(this.lblExpiryValue);
            this.grpDetails.Controls.Add(this.lblStatusValue);
            this.grpDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDetails.Location = new System.Drawing.Point(475, 350);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(600, 212);
            this.grpDetails.TabIndex = 4;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "ℹ️ Selected Item Details";
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelectedItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblSelectedItem.Location = new System.Drawing.Point(15, 25);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(200, 25);
            this.lblSelectedItem.TabIndex = 0;
            this.lblSelectedItem.Text = "Item Information";
            // 
            // lblItemCodeValue
            // 
            this.lblItemCodeValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblItemCodeValue.Location = new System.Drawing.Point(15, 55);
            this.lblItemCodeValue.Name = "lblItemCodeValue";
            this.lblItemCodeValue.Size = new System.Drawing.Size(270, 25);
            this.lblItemCodeValue.TabIndex = 1;
            this.lblItemCodeValue.Text = "Item Code: --";
            // 
            // lblNameValue
            // 
            this.lblNameValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNameValue.Location = new System.Drawing.Point(15, 85);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(270, 25);
            this.lblNameValue.TabIndex = 2;
            this.lblNameValue.Text = "Name: --";
            // 
            // lblQuantityValue
            // 
            this.lblQuantityValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuantityValue.Location = new System.Drawing.Point(15, 115);
            this.lblQuantityValue.Name = "lblQuantityValue";
            this.lblQuantityValue.Size = new System.Drawing.Size(270, 25);
            this.lblQuantityValue.TabIndex = 3;
            this.lblQuantityValue.Text = "Quantity: --";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPriceValue.Location = new System.Drawing.Point(300, 55);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(270, 25);
            this.lblPriceValue.TabIndex = 4;
            this.lblPriceValue.Text = "Price: --";
            // 
            // lblExpiryValue
            // 
            this.lblExpiryValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblExpiryValue.Location = new System.Drawing.Point(300, 85);
            this.lblExpiryValue.Name = "lblExpiryValue";
            this.lblExpiryValue.Size = new System.Drawing.Size(270, 25);
            this.lblExpiryValue.TabIndex = 5;
            this.lblExpiryValue.Text = "Expiration Date: --";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusValue.Location = new System.Drawing.Point(300, 115);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(270, 25);
            this.lblStatusValue.TabIndex = 6;
            this.lblStatusValue.Text = "Status: --";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 627);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1082, 26);
            this.statusStrip.TabIndex = 5;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(309, 20);
            this.toolStripStatusLabel.Text = "Ready | Smart Inventory Management System";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.grpInventory);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Inventory Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpInventory.ResumeLayout(false);
            this.grpControls.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpStats.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}