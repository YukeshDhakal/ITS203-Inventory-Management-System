namespace SmartRepositorySystem
{
    partial class AddItemForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numLowStockThreshold;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

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
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numLowStockThreshold = new System.Windows.Forms.NumericUpDown();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.lblExpiration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowStockThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(140, 30);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(250, 22);
            this.txtItemCode.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 22);
            this.txtName.TabIndex = 3;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(140, 110);
            this.numQuantity.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 22);
            this.numQuantity.TabIndex = 5;
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(140, 150);
            this.numPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 22);
            this.numPrice.TabIndex = 7;
            // 
            // numLowStockThreshold
            // 
            this.numLowStockThreshold.Location = new System.Drawing.Point(160, 190);
            this.numLowStockThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLowStockThreshold.Name = "numLowStockThreshold";
            this.numLowStockThreshold.Size = new System.Drawing.Size(80, 22);
            this.numLowStockThreshold.TabIndex = 9;
            this.numLowStockThreshold.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpirationDate.Location = new System.Drawing.Point(160, 230);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(200, 22);
            this.dtpExpirationDate.TabIndex = 11;
            this.dtpExpirationDate.Value = new System.DateTime(2026, 6, 18, 0, 39, 49, 598);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Location = new System.Drawing.Point(140, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Location = new System.Drawing.Point(260, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblItemCode
            // 
            this.lblItemCode.Location = new System.Drawing.Point(30, 30);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(100, 25);
            this.lblItemCode.TabIndex = 0;
            this.lblItemCode.Text = "Item Code:";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(30, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Item Name:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(30, 110);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 25);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(30, 150);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 25);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // lblLowStock
            // 
            this.lblLowStock.Location = new System.Drawing.Point(30, 190);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(120, 25);
            this.lblLowStock.TabIndex = 8;
            this.lblLowStock.Text = "Low Stock Alert at:";
            // 
            // lblExpiration
            // 
            this.lblExpiration.Location = new System.Drawing.Point(30, 230);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(120, 25);
            this.lblExpiration.TabIndex = 10;
            this.lblExpiration.Text = "Expiration Date:";
            // 
            // AddItemForm
            // 
            this.ClientSize = new System.Drawing.Size(457, 388);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lblLowStock);
            this.Controls.Add(this.numLowStockThreshold);
            this.Controls.Add(this.lblExpiration);
            this.Controls.Add(this.dtpExpirationDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowStockThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label lblExpiration;
    }
}