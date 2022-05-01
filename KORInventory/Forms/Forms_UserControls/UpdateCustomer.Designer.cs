
namespace KORInventory.Forms.Forms_UserControls
{
    partial class UpdateCustomer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpdateHeading = new System.Windows.Forms.Label();
            this.selectLabel = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addresstb = new System.Windows.Forms.TextBox();
            this.phonetb = new System.Windows.Forms.TextBox();
            this.nametb = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateHeading
            // 
            this.UpdateHeading.AutoSize = true;
            this.UpdateHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateHeading.Location = new System.Drawing.Point(279, 19);
            this.UpdateHeading.Name = "UpdateHeading";
            this.UpdateHeading.Size = new System.Drawing.Size(351, 39);
            this.UpdateHeading.TabIndex = 1;
            this.UpdateHeading.Text = "Update The Customer";
            this.UpdateHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(168, 74);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(157, 25);
            this.selectLabel.TabIndex = 2;
            this.selectLabel.Text = "Select Customer";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(342, 70);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(268, 33);
            this.cmbCustomer.TabIndex = 3;
            this.cmbCustomer.Text = "   Select the customer";
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.CmbCustomer_SelectedIndexChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(305, 258);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(200, 44);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "Update Customer";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // addresstb
            // 
            this.addresstb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addresstb.Location = new System.Drawing.Point(184, 197);
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(200, 30);
            this.addresstb.TabIndex = 13;
            // 
            // phonetb
            // 
            this.phonetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phonetb.Location = new System.Drawing.Point(564, 145);
            this.phonetb.Name = "phonetb";
            this.phonetb.Size = new System.Drawing.Size(200, 30);
            this.phonetb.TabIndex = 12;
            // 
            // nametb
            // 
            this.nametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nametb.Location = new System.Drawing.Point(184, 147);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(200, 30);
            this.nametb.TabIndex = 11;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aLabel.Location = new System.Drawing.Point(96, 201);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(85, 25);
            this.aLabel.TabIndex = 10;
            this.aLabel.Text = "Address";
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pLabel.Location = new System.Drawing.Point(411, 147);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(143, 25);
            this.pLabel.TabIndex = 9;
            this.pLabel.Text = "Phone Number";
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nLabel.Location = new System.Drawing.Point(97, 147);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(64, 25);
            this.nLabel.TabIndex = 8;
            this.nLabel.Text = "Name";
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addresstb);
            this.Controls.Add(this.phonetb);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.UpdateHeading);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(828, 368);
            this.MinimumSize = new System.Drawing.Size(828, 368);
            this.Name = "UpdateCustomer";
            this.Size = new System.Drawing.Size(828, 368);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpdateHeading;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox addresstb;
        private System.Windows.Forms.TextBox phonetb;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label nLabel;
    }
}
