
namespace KORInventory.Forms.Forms_UserControls
{
    partial class CustomerDetailUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerDetailsLabel = new System.Windows.Forms.Label();
            this.CnameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.PaystatusLabel = new System.Windows.Forms.Label();
            this.showPaystatus = new System.Windows.Forms.Label();
            this.showAmount = new System.Windows.Forms.Label();
            this.showPhone = new System.Windows.Forms.Label();
            this.showCname = new System.Windows.Forms.Label();
            this.CustomerInvoiceGrid = new System.Windows.Forms.DataGridView();
            this.allInvoice = new System.Windows.Forms.RadioButton();
            this.dueInvoice = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TBBill = new System.Windows.Forms.TextBox();
            this.backBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInvoiceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDetailsLabel
            // 
            this.customerDetailsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDetailsLabel.AutoSize = true;
            this.customerDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerDetailsLabel.Location = new System.Drawing.Point(526, 16);
            this.customerDetailsLabel.Name = "customerDetailsLabel";
            this.customerDetailsLabel.Size = new System.Drawing.Size(367, 36);
            this.customerDetailsLabel.TabIndex = 3;
            this.customerDetailsLabel.Text = "Customer Invoice Details";
            // 
            // CnameLabel
            // 
            this.CnameLabel.AutoSize = true;
            this.CnameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CnameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CnameLabel.Location = new System.Drawing.Point(311, 88);
            this.CnameLabel.Name = "CnameLabel";
            this.CnameLabel.Size = new System.Drawing.Size(177, 25);
            this.CnameLabel.TabIndex = 10;
            this.CnameLabel.Text = "Customer Name  🡆";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PhoneLabel.Location = new System.Drawing.Point(312, 134);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(177, 25);
            this.PhoneLabel.TabIndex = 11;
            this.PhoneLabel.Text = "Contact Number  🡆";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.amountLabel.Location = new System.Drawing.Point(790, 88);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(198, 25);
            this.amountLabel.TabIndex = 13;
            this.amountLabel.Text = "Total Due Amount   🡆";
            // 
            // PaystatusLabel
            // 
            this.PaystatusLabel.AutoSize = true;
            this.PaystatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaystatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaystatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PaystatusLabel.Location = new System.Drawing.Point(795, 134);
            this.PaystatusLabel.Name = "PaystatusLabel";
            this.PaystatusLabel.Size = new System.Drawing.Size(193, 25);
            this.PaystatusLabel.TabIndex = 14;
            this.PaystatusLabel.Text = "Payment Status      🡆";
            // 
            // showPaystatus
            // 
            this.showPaystatus.AutoSize = true;
            this.showPaystatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showPaystatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showPaystatus.Location = new System.Drawing.Point(997, 134);
            this.showPaystatus.Name = "showPaystatus";
            this.showPaystatus.Size = new System.Drawing.Size(145, 25);
            this.showPaystatus.TabIndex = 19;
            this.showPaystatus.Text = "PaymentStatus";
            this.showPaystatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showAmount
            // 
            this.showAmount.AutoSize = true;
            this.showAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showAmount.Location = new System.Drawing.Point(996, 88);
            this.showAmount.Name = "showAmount";
            this.showAmount.Size = new System.Drawing.Size(130, 25);
            this.showAmount.TabIndex = 18;
            this.showAmount.Text = "ShowAmount";
            // 
            // showPhone
            // 
            this.showPhone.AutoSize = true;
            this.showPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showPhone.Location = new System.Drawing.Point(490, 134);
            this.showPhone.Name = "showPhone";
            this.showPhone.Size = new System.Drawing.Size(143, 25);
            this.showPhone.TabIndex = 16;
            this.showPhone.Text = "Phone Number";
            // 
            // showCname
            // 
            this.showCname.AutoSize = true;
            this.showCname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showCname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showCname.Location = new System.Drawing.Point(491, 88);
            this.showCname.Name = "showCname";
            this.showCname.Size = new System.Drawing.Size(154, 25);
            this.showCname.TabIndex = 15;
            this.showCname.Text = "Customer Name";
            // 
            // CustomerInvoiceGrid
            // 
            this.CustomerInvoiceGrid.AllowUserToAddRows = false;
            this.CustomerInvoiceGrid.AllowUserToDeleteRows = false;
            this.CustomerInvoiceGrid.AllowUserToOrderColumns = true;
            this.CustomerInvoiceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerInvoiceGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerInvoiceGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.CustomerInvoiceGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.CustomerInvoiceGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerInvoiceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerInvoiceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerInvoiceGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerInvoiceGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CustomerInvoiceGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerInvoiceGrid.Location = new System.Drawing.Point(162, 265);
            this.CustomerInvoiceGrid.MultiSelect = false;
            this.CustomerInvoiceGrid.Name = "CustomerInvoiceGrid";
            this.CustomerInvoiceGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerInvoiceGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerInvoiceGrid.RowHeadersVisible = false;
            this.CustomerInvoiceGrid.RowHeadersWidth = 51;
            this.CustomerInvoiceGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.CustomerInvoiceGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CustomerInvoiceGrid.RowTemplate.Height = 35;
            this.CustomerInvoiceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerInvoiceGrid.Size = new System.Drawing.Size(1330, 522);
            this.CustomerInvoiceGrid.StandardTab = true;
            this.CustomerInvoiceGrid.TabIndex = 20;
            // 
            // allInvoice
            // 
            this.allInvoice.AutoSize = true;
            this.allInvoice.Location = new System.Drawing.Point(806, 204);
            this.allInvoice.Name = "allInvoice";
            this.allInvoice.Size = new System.Drawing.Size(177, 29);
            this.allInvoice.TabIndex = 24;
            this.allInvoice.TabStop = true;
            this.allInvoice.Text = "Show All Invoice";
            this.allInvoice.UseVisualStyleBackColor = true;
            this.allInvoice.CheckedChanged += new System.EventHandler(this.allInvoice_CheckedChanged);
            // 
            // dueInvoice
            // 
            this.dueInvoice.AutoSize = true;
            this.dueInvoice.Location = new System.Drawing.Point(1029, 205);
            this.dueInvoice.Name = "dueInvoice";
            this.dueInvoice.Size = new System.Drawing.Size(191, 29);
            this.dueInvoice.TabIndex = 25;
            this.dueInvoice.TabStop = true;
            this.dueInvoice.Text = "Show Due Invoice";
            this.dueInvoice.UseVisualStyleBackColor = true;
            this.dueInvoice.CheckedChanged += new System.EventHandler(this.dueInvoice_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(225, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Enter Bill Number";
            // 
            // TBBill
            // 
            this.TBBill.Location = new System.Drawing.Point(393, 204);
            this.TBBill.Name = "TBBill";
            this.TBBill.Size = new System.Drawing.Size(317, 30);
            this.TBBill.TabIndex = 27;
            this.TBBill.TextChanged += new System.EventHandler(this.TBBill_TextChanged);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Maroon;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.backBtn.IconColor = System.Drawing.SystemColors.HighlightText;
            this.backBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backBtn.IconSize = 45;
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.backBtn.Location = new System.Drawing.Point(1, 1);
            this.backBtn.Name = "backBtn";
            this.backBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.backBtn.Size = new System.Drawing.Size(168, 61);
            this.backBtn.TabIndex = 28;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // CustomerDetailUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.TBBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dueInvoice);
            this.Controls.Add(this.allInvoice);
            this.Controls.Add(this.CustomerInvoiceGrid);
            this.Controls.Add(this.showPaystatus);
            this.Controls.Add(this.showAmount);
            this.Controls.Add(this.showPhone);
            this.Controls.Add(this.showCname);
            this.Controls.Add(this.PaystatusLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.CnameLabel);
            this.Controls.Add(this.customerDetailsLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CustomerDetailUserControl";
            this.Size = new System.Drawing.Size(1707, 821);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInvoiceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerDetailsLabel;
        private System.Windows.Forms.Label CnameLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label PaystatusLabel;
        private System.Windows.Forms.Label showPaystatus;
        private System.Windows.Forms.Label showAmount;
        private System.Windows.Forms.Label showPhone;
        private System.Windows.Forms.Label showCname;
        private System.Windows.Forms.DataGridView CustomerInvoiceGrid;
        private System.Windows.Forms.RadioButton allInvoice;
        private System.Windows.Forms.RadioButton dueInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBBill;
        private FontAwesome.Sharp.IconButton backBtn;
    }
}
