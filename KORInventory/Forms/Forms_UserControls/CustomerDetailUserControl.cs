using KORDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KORInventory.Forms.Forms_UserControls
{
    public partial class CustomerDetailUserControl : UserControl
    {
        private readonly Panel Content;
        private Customer _Customer;
        private string _ReturnScreenName;
        private readonly CultureInfo info = CultureInfo.GetCultureInfo("en-IN");
        public CustomerDetailUserControl(Panel Content, string customerName, string returnScreenName)
        {
            InitializeComponent();
            this.Content = Content;
            this._ReturnScreenName = returnScreenName;
            GetUserInvoices(customerName);
        }
        
        private async void GetUserInvoices(string customerName)
        {
            try
            {
                using var dbContext = new KORInventoryDBContext();
                var customerInvoice = await dbContext.Customer.Include(I => I.Invoice).FirstOrDefaultAsync(p => p.Name.ToLower() == customerName.ToLower());
                if(customerInvoice != null)
                {
                    showCname.Text = string.IsNullOrEmpty(customerInvoice.Name) ? "NAN" : customerInvoice.Name;
                    showPhone.Text = string.IsNullOrEmpty(customerInvoice.PhoneNumber) ? "NAN" : customerInvoice.PhoneNumber;
                    var totalDue = customerInvoice.Invoice.Sum(p => p.DueAmount);
                    showAmount.Text = totalDue == 0 ? "0" : totalDue.ToString("N2", info);
                    if(totalDue == 0)
                    {
                        showPaystatus.Text = "Paid";
                        showPaystatus.BackColor = Color.Green;
                    }
                    else
                    {
                        showPaystatus.Text = "Unpaid";
                        showPaystatus.BackColor = Color.Red;
                    }
                    CustomerInvoiceGrid.DataSource = (from invoice in customerInvoice.Invoice.ToList()
                                                      select new
                                                      {
                                                          invoice.BillNo,
                                                          TotalAmount = invoice.TotalAmount.ToString("N2", info),
                                                          SubmitAmount = invoice.SubmitAmount.ToString("N2", info),
                                                          DueAmount = invoice.DueAmount.ToString("N2", info),
                                                          ReturnDate = invoice.ReturnDueAmountDate,
                                                      }).ToList();
                    CustomerInvoiceGrid.Columns[0].Width = 200;
                    CustomerInvoiceGrid.Columns[1].Width = 270;
                    CustomerInvoiceGrid.Columns[2].Width = 270;
                    CustomerInvoiceGrid.Columns[3].Width = 270;
                    CustomerInvoiceGrid.Columns[4].Width = 280;
                    _Customer = customerInvoice;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Contact Adminstrator");
                _Customer = null;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if(_ReturnScreenName == "dashboard")
            {
                var listCustomer = new ListCustomerUserControl(Content);
                MainUserControl.ShowControl(listCustomer, Content);
            }
            if (_ReturnScreenName == "customerinvoice")
            {
                var customerInvoiceUserControl = new CustomerInvoice(Content);
                MainUserControl.ShowControl(customerInvoiceUserControl, Content);
            }
        }

        private void TBBill_TextChanged(object sender, EventArgs e)
        {
            var billNumber = TBBill.Text;
            if (Regex.IsMatch(billNumber, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                TBBill.Text = TBBill.Text.Remove(billNumber.Length - 1);
                return;
            }
            CustomerInvoiceGrid.DataSource = (from invoice in _Customer.Invoice.ToList()
                                              where invoice.BillNo.Contains(billNumber) && invoice.BillNo != ""
                                              select new
                                              {
                                                  invoice.BillNo,
                                                  TotalAmount = invoice.TotalAmount.ToString("N2", info),
                                                  SubmitAmount = invoice.SubmitAmount.ToString("N2", info),
                                                  DueAmount = invoice.DueAmount.ToString("N2", info),
                                                  ReturnDate = invoice.ReturnDueAmountDate
                                              }).OrderByDescending(p=>p.DueAmount).ToList();

        }

        private void allInvoice_CheckedChanged(object sender, EventArgs e)
        {
            CustomerInvoiceGrid.DataSource = (from invoice in _Customer.Invoice.ToList()
                                              where invoice.BillNo != ""
                                              select new
                                              {
                                                  invoice.BillNo,
                                                  TotalAmount = invoice.TotalAmount.ToString("N2", info),
                                                  SubmitAmount = invoice.SubmitAmount.ToString("N2", info),
                                                  DueAmount = invoice.DueAmount.ToString("N2", info),
                                                  ReturnDate = invoice.ReturnDueAmountDate
                                              }).OrderByDescending(p => p.DueAmount).ToList();
        }

        private void dueInvoice_CheckedChanged(object sender, EventArgs e)
        {
            CustomerInvoiceGrid.DataSource = (from invoice in _Customer.Invoice.ToList()
                                              where invoice.DueAmount != 0
                                              select new
                                              {
                                                  invoice.BillNo,
                                                  TotalAmount = invoice.TotalAmount.ToString("N2", info),
                                                  SubmitAmount = invoice.SubmitAmount.ToString("N2", info),
                                                  DueAmount = invoice.DueAmount.ToString("N2", info),
                                                  ReturnDate = invoice.ReturnDueAmountDate
                                              }).OrderByDescending(p => p.DueAmount).ToList();
        }
    }
}
