
using System.Windows.Forms;

namespace KORInventory.Forms.Forms_UserControls
{
    partial class DashboardUserControl
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
            this.TodaySaleLabel = new System.Windows.Forms.Label();
            this.TodaySale = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TodayAmountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthlySale = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MonthAmountLabel = new System.Windows.Forms.Label();
            this.MonthSaleLabel = new System.Windows.Forms.Label();
            this.showSaleGird = new System.Windows.Forms.DataGridView();
            this.TodayradioButton = new System.Windows.Forms.RadioButton();
            this.MonthDueRadioButton = new System.Windows.Forms.RadioButton();
            this.MonthRadioButton = new System.Windows.Forms.RadioButton();
            this.TodayDueRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchBillTB = new System.Windows.Forms.TextBox();
            this.billno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDueAmountDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TodaySale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.monthlySale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showSaleGird)).BeginInit();
            this.SuspendLayout();
            // 
            // TodaySaleLabel
            // 
            this.TodaySaleLabel.AutoSize = true;
            this.TodaySaleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodaySaleLabel.Font = new System.Drawing.Font("Nirmala UI Semilight", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TodaySaleLabel.Location = new System.Drawing.Point(75, 52);
            this.TodaySaleLabel.Name = "TodaySaleLabel";
            this.TodaySaleLabel.Size = new System.Drawing.Size(149, 32);
            this.TodaySaleLabel.TabIndex = 1;
            this.TodaySaleLabel.Text = "SaleNumber";
            // 
            // TodaySale
            // 
            this.TodaySale.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TodaySale.AutoSize = true;
            this.TodaySale.BackColor = System.Drawing.Color.DarkOrange;
            this.TodaySale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TodaySale.Controls.Add(this.pictureBox1);
            this.TodaySale.Controls.Add(this.label3);
            this.TodaySale.Controls.Add(this.TodayAmountLabel);
            this.TodaySale.Controls.Add(this.TodaySaleLabel);
            this.TodaySale.Controls.Add(this.label1);
            this.TodaySale.Location = new System.Drawing.Point(109, 33);
            this.TodaySale.Name = "TodaySale";
            this.TodaySale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TodaySale.Size = new System.Drawing.Size(610, 200);
            this.TodaySale.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KORInventory.Properties.Resources.Sales;
            this.pictureBox1.Location = new System.Drawing.Point(361, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Earnings";
            // 
            // TodayAmountLabel
            // 
            this.TodayAmountLabel.AutoSize = true;
            this.TodayAmountLabel.Font = new System.Drawing.Font("Nirmala UI Semilight", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TodayAmountLabel.Location = new System.Drawing.Point(54, 149);
            this.TodayAmountLabel.Name = "TodayAmountLabel";
            this.TodayAmountLabel.Size = new System.Drawing.Size(149, 32);
            this.TodayAmountLabel.TabIndex = 1;
            this.TodayAmountLabel.Text = "SaleNumber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today No. of Sales";
            // 
            // monthlySale
            // 
            this.monthlySale.BackColor = System.Drawing.Color.SpringGreen;
            this.monthlySale.Controls.Add(this.pictureBox2);
            this.monthlySale.Controls.Add(this.label4);
            this.monthlySale.Controls.Add(this.label2);
            this.monthlySale.Controls.Add(this.MonthAmountLabel);
            this.monthlySale.Controls.Add(this.MonthSaleLabel);
            this.monthlySale.Location = new System.Drawing.Point(859, 33);
            this.monthlySale.Name = "monthlySale";
            this.monthlySale.Size = new System.Drawing.Size(617, 200);
            this.monthlySale.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KORInventory.Properties.Resources.monthSales;
            this.pictureBox2.Location = new System.Drawing.Point(327, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Month Earning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "This Month Total Sales";
            // 
            // MonthAmountLabel
            // 
            this.MonthAmountLabel.AutoSize = true;
            this.MonthAmountLabel.Font = new System.Drawing.Font("Nirmala UI Semilight", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MonthAmountLabel.Location = new System.Drawing.Point(47, 136);
            this.MonthAmountLabel.Name = "MonthAmountLabel";
            this.MonthAmountLabel.Size = new System.Drawing.Size(149, 32);
            this.MonthAmountLabel.TabIndex = 1;
            this.MonthAmountLabel.Text = "SaleNumber";
            // 
            // MonthSaleLabel
            // 
            this.MonthSaleLabel.AutoSize = true;
            this.MonthSaleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthSaleLabel.Font = new System.Drawing.Font("Nirmala UI Semilight", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MonthSaleLabel.Location = new System.Drawing.Point(69, 46);
            this.MonthSaleLabel.Name = "MonthSaleLabel";
            this.MonthSaleLabel.Size = new System.Drawing.Size(149, 32);
            this.MonthSaleLabel.TabIndex = 1;
            this.MonthSaleLabel.Text = "SaleNumber";
            // 
            // showSaleGird
            // 
            this.showSaleGird.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.showSaleGird.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.showSaleGird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showSaleGird.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billno,
            this.totalmount,
            this.submitamount,
            this.dueamount,
            this.ReturnDueAmountDate,
            this.purchasedate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showSaleGird.DefaultCellStyle = dataGridViewCellStyle2;
            this.showSaleGird.Location = new System.Drawing.Point(109, 280);
            this.showSaleGird.Name = "showSaleGird";
            this.showSaleGird.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showSaleGird.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.showSaleGird.RowHeadersVisible = false;
            this.showSaleGird.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.showSaleGird.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.showSaleGird.RowTemplate.Height = 29;
            this.showSaleGird.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showSaleGird.Size = new System.Drawing.Size(1367, 522);
            this.showSaleGird.TabIndex = 14;
            this.showSaleGird.AutoGenerateColumns = false;
            // 
            // TodayradioButton
            // 
            this.TodayradioButton.AutoSize = true;
            this.TodayradioButton.Location = new System.Drawing.Point(224, 250);
            this.TodayradioButton.Name = "TodayradioButton";
            this.TodayradioButton.Size = new System.Drawing.Size(121, 24);
            this.TodayradioButton.TabIndex = 15;
            this.TodayradioButton.TabStop = true;
            this.TodayradioButton.Text = "Today Invoice";
            this.TodayradioButton.UseVisualStyleBackColor = true;
            this.TodayradioButton.CheckedChanged += new System.EventHandler(this.TodayradioButton_CheckedChanged);
            // 
            // MonthDueRadioButton
            // 
            this.MonthDueRadioButton.AutoSize = true;
            this.MonthDueRadioButton.Location = new System.Drawing.Point(1314, 250);
            this.MonthDueRadioButton.Name = "MonthDueRadioButton";
            this.MonthDueRadioButton.Size = new System.Drawing.Size(155, 24);
            this.MonthDueRadioButton.TabIndex = 15;
            this.MonthDueRadioButton.TabStop = true;
            this.MonthDueRadioButton.Text = "Month Due Invoice";
            this.MonthDueRadioButton.UseVisualStyleBackColor = true;
            this.MonthDueRadioButton.CheckedChanged += new System.EventHandler(this.MonthDueRadioButton_CheckedChanged);
            // 
            // MonthRadioButton
            // 
            this.MonthRadioButton.AutoSize = true;
            this.MonthRadioButton.Location = new System.Drawing.Point(1131, 250);
            this.MonthRadioButton.Name = "MonthRadioButton";
            this.MonthRadioButton.Size = new System.Drawing.Size(124, 24);
            this.MonthRadioButton.TabIndex = 15;
            this.MonthRadioButton.TabStop = true;
            this.MonthRadioButton.Text = "Month Invoice";
            this.MonthRadioButton.UseVisualStyleBackColor = true;
            this.MonthRadioButton.CheckedChanged += new System.EventHandler(this.MonthRadioButton_CheckedChanged);
            // 
            // TodayDueRadioButton
            // 
            this.TodayDueRadioButton.AutoSize = true;
            this.TodayDueRadioButton.Location = new System.Drawing.Point(395, 250);
            this.TodayDueRadioButton.Name = "TodayDueRadioButton";
            this.TodayDueRadioButton.Size = new System.Drawing.Size(152, 24);
            this.TodayDueRadioButton.TabIndex = 15;
            this.TodayDueRadioButton.TabStop = true;
            this.TodayDueRadioButton.Text = "Today Due Invoice";
            this.TodayDueRadioButton.UseVisualStyleBackColor = true;
            this.TodayDueRadioButton.CheckedChanged += new System.EventHandler(this.TodayDueRadioButton_CheckedChanged);
            // 
            // SearchBillTB
            // 
            this.SearchBillTB.Location = new System.Drawing.Point(672, 249);
            this.SearchBillTB.Name = "SearchBillTB";
            this.SearchBillTB.PlaceholderText = "  Enter the Bill Number";
            this.SearchBillTB.Size = new System.Drawing.Size(383, 27);
            this.SearchBillTB.TabIndex = 16;
            this.SearchBillTB.TextChanged += new System.EventHandler(this.SearchBillTB_TextChanged);
            // 
            // billno
            // 
            this.billno.DataPropertyName = "BillNo";
            this.billno.HeaderText = "Bill Number";
            this.billno.MinimumWidth = 6;
            this.billno.Name = "billno";
            this.billno.ReadOnly = true;
            this.billno.ToolTipText = "Bill Number";
            this.billno.Width = 220;
            // 
            // totalmount
            // 
            this.totalmount.DataPropertyName = "TotalAmount";
            this.totalmount.HeaderText = "Total Amount";
            this.totalmount.MinimumWidth = 6;
            this.totalmount.Name = "totalmount";
            this.totalmount.ReadOnly = true;
            this.totalmount.Width = 220;
            // 
            // submitamount
            // 
            this.submitamount.DataPropertyName = "SubmitAmount";
            this.submitamount.HeaderText = "Submit Amount";
            this.submitamount.MinimumWidth = 6;
            this.submitamount.Name = "submitamount";
            this.submitamount.ReadOnly = true;
            this.submitamount.ToolTipText = "Submit Amount";
            this.submitamount.Width = 220;
            // 
            // dueamount
            // 
            this.dueamount.DataPropertyName = "DueAmount";
            this.dueamount.HeaderText = "Due Amount";
            this.dueamount.MinimumWidth = 6;
            this.dueamount.Name = "dueamount";
            this.dueamount.ReadOnly = true;
            this.dueamount.ToolTipText = "Due Amount";
            this.dueamount.Width = 220;
            // 
            // ReturnDueAmountDate
            // 
            this.ReturnDueAmountDate.DataPropertyName = "ReturnDueAmountDate";
            this.ReturnDueAmountDate.HeaderText = "Return Date";
            this.ReturnDueAmountDate.MinimumWidth = 6;
            this.ReturnDueAmountDate.Name = "ReturnDueAmountDate";
            this.ReturnDueAmountDate.ReadOnly = true;
            this.ReturnDueAmountDate.ToolTipText = "Return Date";
            this.ReturnDueAmountDate.Width = 240;
            // 
            // purchasedate
            // 
            this.purchasedate.DataPropertyName = "PurchaseDate";
            this.purchasedate.HeaderText = "Purchase Date";
            this.purchasedate.MinimumWidth = 6;
            this.purchasedate.Name = "purchasedate";
            this.purchasedate.ReadOnly = true;
            this.purchasedate.ToolTipText = "Purchase Date";
            this.purchasedate.Width = 240;
            // 
            // DashboardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchBillTB);
            this.Controls.Add(this.MonthRadioButton);
            this.Controls.Add(this.MonthDueRadioButton);
            this.Controls.Add(this.TodayDueRadioButton);
            this.Controls.Add(this.TodayradioButton);
            this.Controls.Add(this.showSaleGird);
            this.Controls.Add(this.monthlySale);
            this.Controls.Add(this.TodaySale);
            this.Name = "DashboardUserControl";
            this.Size = new System.Drawing.Size(1609, 835);
            this.TodaySale.ResumeLayout(false);
            this.TodaySale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.monthlySale.ResumeLayout(false);
            this.monthlySale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showSaleGird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TodaySaleLabel;
        private System.Windows.Forms.Panel TodaySale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel monthlySale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MonthSaleLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TodayAmountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MonthAmountLabel;
        private System.Windows.Forms.DataGridView showSaleGird;
        private System.Windows.Forms.RadioButton TodayradioButton;
        private System.Windows.Forms.RadioButton MonthDueRadioButton;
        private System.Windows.Forms.RadioButton MonthRadioButton;
        private System.Windows.Forms.RadioButton TodayDueRadioButton;
        private System.Windows.Forms.TextBox SearchBillTB;
        private DataGridViewTextBoxColumn billno;
        private DataGridViewTextBoxColumn totalmount;
        private DataGridViewTextBoxColumn submitamount;
        private DataGridViewTextBoxColumn dueamount;
        private DataGridViewTextBoxColumn ReturnDueAmountDate;
        private DataGridViewTextBoxColumn purchasedate;
    }
}
