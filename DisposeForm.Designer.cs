namespace SmartRepositorySystem
{
    partial class DisposeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblItemInfo;
        private System.Windows.Forms.Label lblPrompt;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblItemInfo = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();

            this.lblItemInfo.Location = new System.Drawing.Point(20, 20);
            this.lblItemInfo.Size = new System.Drawing.Size(300, 30);

            this.lblPrompt.Text = "Quantity to dispose:";
            this.lblPrompt.Location = new System.Drawing.Point(20, 60);
            this.lblPrompt.Size = new System.Drawing.Size(120, 25);

            this.numQuantity.Location = new System.Drawing.Point(150, 60);
            this.numQuantity.Size = new System.Drawing.Size(100, 27);
            this.numQuantity.Minimum = 1;
            this.numQuantity.Maximum = 99999;

            this.btnConfirm.Text = "Confirm Dispose";
            this.btnConfirm.Location = new System.Drawing.Point(80, 110);
            this.btnConfirm.Size = new System.Drawing.Size(100, 35);
            this.btnConfirm.BackColor = System.Drawing.Color.Orange;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(200, 110);
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.Text = "Dispose Damaged Item";
            this.Size = new System.Drawing.Size(350, 180);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

            this.Controls.Add(this.lblItemInfo);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
        }
    }
}