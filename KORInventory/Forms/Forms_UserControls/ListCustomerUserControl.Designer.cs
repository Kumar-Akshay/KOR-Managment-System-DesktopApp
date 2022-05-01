
namespace KORInventory.Forms.Forms_UserControls
{
    partial class ListCustomerUserControl
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
            this.SearchLabel = new System.Windows.Forms.Label();
            this.customerSearchBox = new System.Windows.Forms.TextBox();
            this.ShowAmount = new System.Windows.Forms.Label();
            this.ShowCustomer = new System.Windows.Forms.Label();
            this.TAlabel = new System.Windows.Forms.Label();
            this.TClabel = new System.Windows.Forms.Label();
            this.CustomerGrid = new System.Windows.Forms.DataGridView();
            this.Headinglabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchLabel.Location = new System.Drawing.Point(13, 56);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(217, 29);
            this.SearchLabel.TabIndex = 25;
            this.SearchLabel.Text = "Search Customer : ";
            // 
            // customerSearchBox
            // 
            this.customerSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerSearchBox.Location = new System.Drawing.Point(237, 56);
            this.customerSearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerSearchBox.Name = "customerSearchBox";
            this.customerSearchBox.PlaceholderText = "  Enter the Customer Name";
            this.customerSearchBox.Size = new System.Drawing.Size(314, 30);
            this.customerSearchBox.TabIndex = 24;
            this.customerSearchBox.TextChanged += new System.EventHandler(this.CustomerSearchBox_TextChanged);
            // 
            // ShowAmount
            // 
            this.ShowAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAmount.AutoSize = true;
            this.ShowAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowAmount.Location = new System.Drawing.Point(711, 598);
            this.ShowAmount.Name = "ShowAmount";
            this.ShowAmount.Size = new System.Drawing.Size(155, 29);
            this.ShowAmount.TabIndex = 23;
            this.ShowAmount.Text = "ShowAmount";
            // 
            // ShowCustomer
            // 
            this.ShowCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCustomer.AutoSize = true;
            this.ShowCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowCustomer.Location = new System.Drawing.Point(220, 600);
            this.ShowCustomer.Name = "ShowCustomer";
            this.ShowCustomer.Size = new System.Drawing.Size(178, 29);
            this.ShowCustomer.TabIndex = 22;
            this.ShowCustomer.Text = "ShowCustomer";
            // 
            // TAlabel
            // 
            this.TAlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TAlabel.AutoSize = true;
            this.TAlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TAlabel.Location = new System.Drawing.Point(541, 598);
            this.TAlabel.Name = "TAlabel";
            this.TAlabel.Size = new System.Drawing.Size(173, 29);
            this.TAlabel.TabIndex = 21;
            this.TAlabel.Text = "Total Amount : ";
            // 
            // TClabel
            // 
            this.TClabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TClabel.AutoSize = true;
            this.TClabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TClabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TClabel.Location = new System.Drawing.Point(27, 599);
            this.TClabel.Name = "TClabel";
            this.TClabel.Size = new System.Drawing.Size(196, 29);
            this.TClabel.TabIndex = 20;
            this.TClabel.Text = "Total Customer : ";
            // 
            // CustomerGrid
            // 
            this.CustomerGrid.AllowUserToAddRows = false;
            this.CustomerGrid.AllowUserToDeleteRows = false;
            this.CustomerGrid.AllowUserToOrderColumns = true;
            this.CustomerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.CustomerGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.CustomerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CustomerGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerGrid.Location = new System.Drawing.Point(0, 108);
            this.CustomerGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerGrid.MultiSelect = false;
            this.CustomerGrid.Name = "CustomerGrid";
            this.CustomerGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerGrid.RowHeadersWidth = 51;
            this.CustomerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.CustomerGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CustomerGrid.RowTemplate.DividerHeight = 1;
            this.CustomerGrid.RowTemplate.Height = 35;
            this.CustomerGrid.RowTemplate.ReadOnly = true;
            this.CustomerGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CustomerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGrid.Size = new System.Drawing.Size(1012, 471);
            this.CustomerGrid.StandardTab = true;
            this.CustomerGrid.TabIndex = 19;
            this.CustomerGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CustomerGrid_CellMouseDoubleClick);
            // 
            // Headinglabel
            // 
            this.Headinglabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Headinglabel.AutoSize = true;
            this.Headinglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Headinglabel.Location = new System.Drawing.Point(353, 1);
            this.Headinglabel.Name = "Headinglabel";
            this.Headinglabel.Size = new System.Drawing.Size(370, 36);
            this.Headinglabel.TabIndex = 18;
            this.Headinglabel.Text = "Amount Due CustomerList.";
            // 
            // ListCustomerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.customerSearchBox);
            this.Controls.Add(this.ShowAmount);
            this.Controls.Add(this.ShowCustomer);
            this.Controls.Add(this.TAlabel);
            this.Controls.Add(this.TClabel);
            this.Controls.Add(this.CustomerGrid);
            this.Controls.Add(this.Headinglabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListCustomerUserControl";
            this.Size = new System.Drawing.Size(1013, 655);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox customerSearchBox;
        private System.Windows.Forms.Label ShowAmount;
        private System.Windows.Forms.Label ShowCustomer;
        private System.Windows.Forms.Label TAlabel;
        private System.Windows.Forms.Label TClabel;
        private System.Windows.Forms.DataGridView CustomerGrid;
        private System.Windows.Forms.Label Headinglabel;
    }
}
