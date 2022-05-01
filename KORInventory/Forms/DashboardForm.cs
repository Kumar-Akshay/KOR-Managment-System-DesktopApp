using KORDAL.Models;
using KORInventory.Forms.Forms_UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KORInventory.Forms
{
    public partial class DashboardForm : Form
    {
        private ListCustomerUserControl CustomerUserControl { get; set; }
        public DashboardForm()
        {
            InitializeComponent();
            this.FormClosing += DashboardForm_FormClosing;
            this.label2.Text = DateTime.Now.ToString("dd/MM/yyyy");
            var dashboardUserControl = new DashboardUserControl(TopBar);
            MainUserControl.ShowControl(dashboardUserControl, TopBar);
        }
        #region Dashboard Button
        private void dashboardBtn_Click_1(object sender, EventArgs e)
        {
            var dashboardUserControl = new DashboardUserControl(TopBar);
            MainUserControl.ShowControl(dashboardUserControl, TopBar);
            NavbarHeading.Text = "Dashboard";
        }
        private void dashboardBtn_Enter(object sender, EventArgs e)
        {
            dashboardBtn.BackColor = Color.FromArgb((int)(((byte)(234))), ((int)(((byte)(183)))), ((int)(((byte)(149)))));
            dashboardBtn.ForeColor = Color.Black;
            dashboardBtn.IconColor = Color.Black;
        }

        private void dashboardBtn_Leave(object sender, EventArgs e)
        {
            dashboardBtn.BackColor = Color.FromArgb((int)(((byte)(41))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dashboardBtn.ForeColor = Color.FromArgb(234, ((int)(((byte)(183)))), ((int)(((byte)(149)))));
            dashboardBtn.IconColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(183)))), ((int)(((byte)(149)))));
        }
        private void DashboardForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (this.DialogResult == DialogResult.None)
            {
                switch (MessageBox.Show(this, "Are you sure to close it.?", "Do you still want ... ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        Environment.Exit(0);
                        break;
                    default:
                        this.Close();
                        break;
                }
            }
        }

        #endregion

        #region Amount Due Button
        private void AmountDueBtn_Click(object sender, EventArgs e)
        {
            if(CustomerUserControl != null)
            {
                MainUserControl.ShowControl(CustomerUserControl, TopBar);
                NavbarHeading.Text = "Customer";
            }
            else
            {
                CustomerUserControl = new ListCustomerUserControl(TopBar);
                MainUserControl.ShowControl(CustomerUserControl, TopBar);
                NavbarHeading.Text = "Customer";
            }
        }
        private void AmountDue_MouseEnter(object sender, EventArgs e)
        {
            AmountDueBtn.BackColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(183)))), ((int)(((byte)(149)))));
            AmountDueBtn.ForeColor = Color.Black;
            AmountDueBtn.IconColor = Color.Black;
        }

        private void AmountDue_MouseLeave(object sender, EventArgs e)
        {
            AmountDueBtn.BackColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            AmountDueBtn.ForeColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(183)))), ((int)(((byte)(149)))));
            AmountDueBtn.IconColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(183)))), ((int)(((byte)(149)))));
        }

        #endregion

        #region Invoice Button
        private void InvoiceBtn_Click(object sender, EventArgs e)
        {
            var invoiceControl = new CustomerInvoice(TopBar);
            MainUserControl.ShowControl(invoiceControl, TopBar);
            NavbarHeading.Text = "Invoice";
        }
        private void InvoiceBtn_MouseEnter(object sender, EventArgs e)
        {
            InvoiceBtn.BackColor = Color.FromArgb((int)(((byte)(234))), ((int)(((byte)(183)))), ((int)(((byte)(149)))));
            InvoiceBtn.ForeColor = Color.Black;
            InvoiceBtn.IconColor = Color.Black;
        }

        private void InvoiceBtn_MouseLeave(object sender, EventArgs e)
        {
            InvoiceBtn.BackColor = Color.FromArgb((int)(((byte)(41))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            InvoiceBtn.ForeColor = Color.FromArgb(234, ((int)(((byte)(183)))), ((int)(((byte)(149)))));
            InvoiceBtn.IconColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(183)))), ((int)(((byte)(149)))));
        }
        #endregion

        #region Status Button
        private void statusBtn_Click(object sender, EventArgs e)
        {
            NavbarHeading.Text = "Status";
        }
        private void statusBtn_Enter(object sender, EventArgs e)
        {
            statusBtn.BackColor = Color.FromArgb((int)(((byte)(234))), ((int)(((byte)(183)))), ((int)(((byte)(149)))));
            statusBtn.ForeColor = Color.Black;
            statusBtn.IconColor = Color.Black;
        }

        private void statusBtn_Leave(object sender, EventArgs e)
        {
            statusBtn.BackColor = Color.FromArgb((int)(((byte)(41))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            statusBtn.ForeColor = Color.FromArgb(234, ((int)(((byte)(183)))), ((int)(((byte)(149)))));
            statusBtn.IconColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(183)))), ((int)(((byte)(149)))));
        }
        #endregion
        
        #region Manage Button
        private void ManageBtn_Click(object sender, EventArgs e)
        {
            var manageCustomerControl = new ManageCustomer(TopBar);
            MainUserControl.ShowControl(manageCustomerControl, TopBar);
            NavbarHeading.Text = "Manage";
        }
        private void ManageBtn_MouseEnter(object sender, EventArgs e)
        {
            ManageBtn.BackColor = Color.FromArgb((int)(((byte)(234))), ((int)(((byte)(183)))), ((int)(((byte)(149)))));
            ManageBtn.ForeColor = Color.Black;
            ManageBtn.IconColor = Color.Black;
        }

        private void ManageBtn_MouseLeave(object sender, EventArgs e)
        {
            ManageBtn.BackColor = Color.FromArgb((int)(((byte)(41))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            ManageBtn.ForeColor = Color.FromArgb(234, ((int)(((byte)(183)))), ((int)(((byte)(149)))));
            ManageBtn.IconColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(183)))), ((int)(((byte)(149)))));
        }
        #endregion
    }
}
