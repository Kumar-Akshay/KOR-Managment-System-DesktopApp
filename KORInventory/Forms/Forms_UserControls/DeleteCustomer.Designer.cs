
namespace KORInventory.Forms.Forms_UserControls
{
    partial class DeleteCustomer
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
            this.deleteHeadingLabel = new System.Windows.Forms.Label();
            this.cmbCustomerDelete = new System.Windows.Forms.ComboBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.showaddress = new System.Windows.Forms.Label();
            this.showphone = new System.Windows.Forms.Label();
            this.showname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteHeadingLabel
            // 
            this.deleteHeadingLabel.AutoSize = true;
            this.deleteHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteHeadingLabel.Location = new System.Drawing.Point(282, 19);
            this.deleteHeadingLabel.Name = "deleteHeadingLabel";
            this.deleteHeadingLabel.Size = new System.Drawing.Size(340, 39);
            this.deleteHeadingLabel.TabIndex = 1;
            this.deleteHeadingLabel.Text = "Delete The Customer";
            this.deleteHeadingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbCustomerDelete
            // 
            this.cmbCustomerDelete.FormattingEnabled = true;
            this.cmbCustomerDelete.Location = new System.Drawing.Point(342, 74);
            this.cmbCustomerDelete.Name = "cmbCustomerDelete";
            this.cmbCustomerDelete.Size = new System.Drawing.Size(268, 33);
            this.cmbCustomerDelete.TabIndex = 5;
            this.cmbCustomerDelete.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerDelete_SelectedIndexChanged);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(171, 77);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(157, 25);
            this.selectLabel.TabIndex = 4;
            this.selectLabel.Text = "Select Customer";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aLabel.Location = new System.Drawing.Point(169, 202);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(85, 25);
            this.aLabel.TabIndex = 13;
            this.aLabel.Text = "Address";
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pLabel.Location = new System.Drawing.Point(426, 148);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(143, 25);
            this.pLabel.TabIndex = 12;
            this.pLabel.Text = "Phone Number";
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nLabel.Location = new System.Drawing.Point(169, 148);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(64, 25);
            this.nLabel.TabIndex = 11;
            this.nLabel.Text = "Name";
            // 
            // showaddress
            // 
            this.showaddress.AutoSize = true;
            this.showaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showaddress.Location = new System.Drawing.Point(268, 202);
            this.showaddress.Name = "showaddress";
            this.showaddress.Size = new System.Drawing.Size(85, 25);
            this.showaddress.TabIndex = 16;
            this.showaddress.Text = "Address";
            // 
            // showphone
            // 
            this.showphone.AutoSize = true;
            this.showphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showphone.Location = new System.Drawing.Point(580, 148);
            this.showphone.Name = "showphone";
            this.showphone.Size = new System.Drawing.Size(143, 25);
            this.showphone.TabIndex = 15;
            this.showphone.Text = "Phone Number";
            // 
            // showname
            // 
            this.showname.AutoSize = true;
            this.showname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showname.Location = new System.Drawing.Point(267, 148);
            this.showname.Name = "showname";
            this.showname.Size = new System.Drawing.Size(64, 25);
            this.showname.TabIndex = 14;
            this.showname.Text = "Name";
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showaddress);
            this.Controls.Add(this.showphone);
            this.Controls.Add(this.showname);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.cmbCustomerDelete);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.deleteHeadingLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(828, 368);
            this.MinimumSize = new System.Drawing.Size(828, 368);
            this.Name = "DeleteCustomer";
            this.Size = new System.Drawing.Size(828, 368);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deleteHeadingLabel;
        private System.Windows.Forms.ComboBox cmbCustomerDelete;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label showaddress;
        private System.Windows.Forms.Label showphone;
        private System.Windows.Forms.Label showname;
    }
}
