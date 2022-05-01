
namespace KORInventory.Forms.Forms_UserControls
{
    partial class CustomerInvoice
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
            this.InvoicePanel = new System.Windows.Forms.Panel();
            this.AddBtn = new FontAwesome.Sharp.IconButton();
            this.customerListGird = new System.Windows.Forms.DataGridView();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.AddInvoicePanel = new System.Windows.Forms.Panel();
            this.returndateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.purchasedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.TBAmount = new System.Windows.Forms.TextBox();
            this.TBSAmount = new System.Windows.Forms.TextBox();
            this.TBPAmount = new System.Windows.Forms.TextBox();
            this.TBBill = new System.Windows.Forms.TextBox();
            this.TBCustomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteHeadingLabel = new System.Windows.Forms.Label();
            this.SubmitInvoice = new FontAwesome.Sharp.IconButton();
            this.InvoicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerListGird)).BeginInit();
            this.AddInvoicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InvoicePanel
            // 
            this.InvoicePanel.Controls.Add(this.AddBtn);
            this.InvoicePanel.Controls.Add(this.customerListGird);
            this.InvoicePanel.Controls.Add(this.TextBoxSearch);
            this.InvoicePanel.Controls.Add(this.AddInvoicePanel);
            this.InvoicePanel.Controls.Add(this.deleteHeadingLabel);
            this.InvoicePanel.Location = new System.Drawing.Point(3, 3);
            this.InvoicePanel.Name = "InvoicePanel";
            this.InvoicePanel.Size = new System.Drawing.Size(1609, 835);
            this.InvoicePanel.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.Black;
            this.AddBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddBtn.IconColor = System.Drawing.SystemColors.Desktop;
            this.AddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddBtn.IconSize = 40;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(691, 76);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(266, 55);
            this.AddBtn.TabIndex = 18;
            this.AddBtn.Text = "      Add New Invoice";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // customerListGird
            // 
            this.customerListGird.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customerListGird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerListGird.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerListGird.Location = new System.Drawing.Point(54, 129);
            this.customerListGird.Name = "customerListGird";
            this.customerListGird.RowHeadersWidth = 51;
            this.customerListGird.RowTemplate.Height = 29;
            this.customerListGird.Size = new System.Drawing.Size(610, 703);
            this.customerListGird.TabIndex = 16;
            this.customerListGird.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerListGird_CellClick);
            this.customerListGird.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerListGird_CellDoubleClick);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(54, 92);
            this.TextBoxSearch.Multiline = true;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PlaceholderText = "  Search Existing Customer";
            this.TextBoxSearch.Size = new System.Drawing.Size(610, 31);
            this.TextBoxSearch.TabIndex = 15;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // AddInvoicePanel
            // 
            this.AddInvoicePanel.Controls.Add(this.SubmitInvoice);
            this.AddInvoicePanel.Controls.Add(this.returndateTimePicker);
            this.AddInvoicePanel.Controls.Add(this.purchasedateTimePicker);
            this.AddInvoicePanel.Controls.Add(this.TBPhone);
            this.AddInvoicePanel.Controls.Add(this.TBAmount);
            this.AddInvoicePanel.Controls.Add(this.TBSAmount);
            this.AddInvoicePanel.Controls.Add(this.TBPAmount);
            this.AddInvoicePanel.Controls.Add(this.TBBill);
            this.AddInvoicePanel.Controls.Add(this.TBCustomer);
            this.AddInvoicePanel.Controls.Add(this.label7);
            this.AddInvoicePanel.Controls.Add(this.label8);
            this.AddInvoicePanel.Controls.Add(this.label5);
            this.AddInvoicePanel.Controls.Add(this.label6);
            this.AddInvoicePanel.Controls.Add(this.label3);
            this.AddInvoicePanel.Controls.Add(this.label4);
            this.AddInvoicePanel.Controls.Add(this.label2);
            this.AddInvoicePanel.Controls.Add(this.label1);
            this.AddInvoicePanel.Location = new System.Drawing.Point(691, 153);
            this.AddInvoicePanel.Name = "AddInvoicePanel";
            this.AddInvoicePanel.Size = new System.Drawing.Size(738, 679);
            this.AddInvoicePanel.TabIndex = 14;
            // 
            // returndateTimePicker
            // 
            this.returndateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returndateTimePicker.Location = new System.Drawing.Point(234, 395);
            this.returndateTimePicker.Name = "returndateTimePicker";
            this.returndateTimePicker.Size = new System.Drawing.Size(327, 30);
            this.returndateTimePicker.TabIndex = 25;
            // 
            // purchasedateTimePicker
            // 
            this.purchasedateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchasedateTimePicker.Location = new System.Drawing.Point(234, 228);
            this.purchasedateTimePicker.Name = "purchasedateTimePicker";
            this.purchasedateTimePicker.Size = new System.Drawing.Size(327, 30);
            this.purchasedateTimePicker.TabIndex = 24;
            // 
            // TBPhone
            // 
            this.TBPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBPhone.Location = new System.Drawing.Point(234, 449);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.PlaceholderText = "Optional";
            this.TBPhone.Size = new System.Drawing.Size(327, 30);
            this.TBPhone.TabIndex = 23;
            this.TBPhone.TextChanged += new System.EventHandler(this.TBPhone_TextChanged);
            // 
            // TBAmount
            // 
            this.TBAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBAmount.Location = new System.Drawing.Point(234, 336);
            this.TBAmount.Name = "TBAmount";
            this.TBAmount.Size = new System.Drawing.Size(327, 30);
            this.TBAmount.TabIndex = 21;
            this.TBAmount.TextChanged += new System.EventHandler(this.TBAmount_TextChanged);
            // 
            // TBSAmount
            // 
            this.TBSAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBSAmount.Location = new System.Drawing.Point(234, 284);
            this.TBSAmount.Name = "TBSAmount";
            this.TBSAmount.Size = new System.Drawing.Size(327, 30);
            this.TBSAmount.TabIndex = 20;
            this.TBSAmount.TextChanged += new System.EventHandler(this.TBSAmount_TextChanged);
            // 
            // TBPAmount
            // 
            this.TBPAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBPAmount.Location = new System.Drawing.Point(234, 173);
            this.TBPAmount.Name = "TBPAmount";
            this.TBPAmount.Size = new System.Drawing.Size(327, 30);
            this.TBPAmount.TabIndex = 18;
            this.TBPAmount.TextChanged += new System.EventHandler(this.TBPAmount_TextChanged);
            // 
            // TBBill
            // 
            this.TBBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBBill.Location = new System.Drawing.Point(234, 113);
            this.TBBill.Name = "TBBill";
            this.TBBill.Size = new System.Drawing.Size(327, 30);
            this.TBBill.TabIndex = 17;
            // 
            // TBCustomer
            // 
            this.TBCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBCustomer.Location = new System.Drawing.Point(234, 58);
            this.TBCustomer.Name = "TBCustomer";
            this.TBCustomer.Size = new System.Drawing.Size(327, 30);
            this.TBCustomer.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(43, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(43, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Return Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Purchase Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(43, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Due Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Submit Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Purchase Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bill Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer Name";
            // 
            // deleteHeadingLabel
            // 
            this.deleteHeadingLabel.AutoSize = true;
            this.deleteHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteHeadingLabel.Location = new System.Drawing.Point(633, 13);
            this.deleteHeadingLabel.Name = "deleteHeadingLabel";
            this.deleteHeadingLabel.Size = new System.Drawing.Size(361, 39);
            this.deleteHeadingLabel.TabIndex = 12;
            this.deleteHeadingLabel.Text = "Add Customer Invoice ";
            this.deleteHeadingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SubmitInvoice
            // 
            this.SubmitInvoice.BackColor = System.Drawing.Color.MediumTurquoise;
            this.SubmitInvoice.FlatAppearance.BorderSize = 0;
            this.SubmitInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitInvoice.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.SubmitInvoice.IconColor = System.Drawing.Color.Black;
            this.SubmitInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmitInvoice.IconSize = 45;
            this.SubmitInvoice.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SubmitInvoice.Location = new System.Drawing.Point(234, 504);
            this.SubmitInvoice.Name = "SubmitInvoice";
            this.SubmitInvoice.Padding = new System.Windows.Forms.Padding(20, 0, 15, 0);
            this.SubmitInvoice.Size = new System.Drawing.Size(327, 58);
            this.SubmitInvoice.TabIndex = 27;
            this.SubmitInvoice.Text = "Submit Invoice";
            this.SubmitInvoice.UseVisualStyleBackColor = false;
            this.SubmitInvoice.Click += new System.EventHandler(this.SubmitInvoice_Click);
            // 
            // CustomerInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InvoicePanel);
            this.Name = "CustomerInvoice";
            this.Size = new System.Drawing.Size(1658, 852);
            this.InvoicePanel.ResumeLayout(false);
            this.InvoicePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerListGird)).EndInit();
            this.AddInvoicePanel.ResumeLayout(false);
            this.AddInvoicePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InvoicePanel;
        private System.Windows.Forms.DataGridView customerListGird;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Panel AddInvoicePanel;
        private System.Windows.Forms.DateTimePicker returndateTimePicker;
        private System.Windows.Forms.DateTimePicker purchasedateTimePicker;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.TextBox TBAmount;
        private System.Windows.Forms.TextBox TBSAmount;
        private System.Windows.Forms.TextBox TBPAmount;
        private System.Windows.Forms.TextBox TBBill;
        private System.Windows.Forms.TextBox TBCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label deleteHeadingLabel;
        private FontAwesome.Sharp.IconButton AddBtn;
        private FontAwesome.Sharp.IconButton SubmitInvoice;
    }
}
