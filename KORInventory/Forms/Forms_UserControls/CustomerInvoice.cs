using KORDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KORInventory.Forms.Forms_UserControls
{
    public partial class CustomerInvoice : UserControl
    {
        private readonly Panel Content;
        public CustomerInvoice(Panel Content)
        {
            InitializeComponent();
            this.Content = Content;
            customerListGird.Visible = false;
            TBAmount.Enabled = false;
            AddInvoicePanel.Visible = false;
        }

        private void customerListGird_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }
            var customerName = customerListGird.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Customer Name Invalid");
                return;
            }
            AddInvoicePanel.Visible = true;
            TBCustomer.Text = customerName;
        }
        private void customerListGird_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var customerName = customerListGird.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            if(!string.IsNullOrEmpty(customerName)|| !string.IsNullOrWhiteSpace(customerName))
            {
                var customerDetailUserControl = new CustomerDetailUserControl(Content, customerName, "customerinvoice");
                MainUserControl.ShowControl(customerDetailUserControl, Content);
            }
        }
        private async void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            customerListGird.Visible = true;
            using var dbContext = new KORInventoryDBContext();
            customerListGird.DataSource = await dbContext.Customer.Where(p => p.Name.Contains(TextBoxSearch.Text)).Select(p => new { Name = p.Name }).ToListAsync();
            customerListGird.Columns[0].Width = 500;
        }
        private void TBSAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(TBSAmount.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    TBSAmount.Text = TBSAmount.Text.Remove(TBSAmount.Text.Length - 1);
                    return;
                }
                if(string.IsNullOrEmpty(TBSAmount.Text)|| string.IsNullOrWhiteSpace(TBSAmount.Text))
                {
                    TBAmount.Text = "0";
                    return;
                }
                var purchase = Convert.ToInt32(TBPAmount.Text);
                var submitAmount = Convert.ToInt32(TBSAmount.Text);
                var dueAmount = purchase - submitAmount;
                TBAmount.Text = dueAmount.ToString();
            }
            catch (FormatException)
            {
                return;
            }
            catch (OverflowException)
            {
                return;
            }
        }
        private void TBPAmount_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TBPAmount.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                TBPAmount.Text = TBPAmount.Text.Remove(TBPAmount.Text.Length - 1);
            }
        }
        private void TBAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TBAmount.Text) || string.IsNullOrWhiteSpace(TBAmount.Text))
                {
                    return;
                }

                var DueAmount = Convert.ToInt32(TBAmount.Text);
                if (DueAmount < 0)
                {
                    TBAmount.Text = "0";
                    return;
                }
                if (Regex.IsMatch(TBAmount.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    TBAmount.Text = TBAmount.Text.Remove(TBAmount.Text.Length - 1);
                }
            }
            catch (FormatException)
            {
                return;
            }
            catch (OverflowException)
            {
                return;
            }
        }
        private void TBPhone_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TBPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                TBPhone.Text = TBPhone.Text.Remove(TBPhone.Text.Length - 1);
            }
        }
        private async void SubmitInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                var customerName = TBCustomer.Text;
                var billNumber = TBBill.Text;
                var purchaseAmount = TBPAmount.Text;
                var submitAmount = TBSAmount.Text;
                var purchaseDate = purchasedateTimePicker.Value;
                var returnDate = returndateTimePicker.Value;
                var phoneNumber = TBPhone.Text;
                var dueAmount = TBAmount.Text;

                if (string.IsNullOrEmpty(customerName) || string.IsNullOrWhiteSpace(customerName))
                {
                    MessageBox.Show("Customer Name Incorret");
                    return;
                }
                if (string.IsNullOrEmpty(billNumber) || string.IsNullOrWhiteSpace(billNumber))
                {
                    MessageBox.Show("Bill Number Incorret");
                    return;
                }
                if (string.IsNullOrEmpty(purchaseAmount) || string.IsNullOrWhiteSpace(purchaseAmount))
                {
                    MessageBox.Show("Purchase Amount Incorret");
                    return;
                }
                if (string.IsNullOrEmpty(submitAmount) || string.IsNullOrWhiteSpace(submitAmount))
                {
                    MessageBox.Show("Submit Amount Incorret");
                    return;
                }
                using var dbContext = new KORInventoryDBContext();
                var customer = await dbContext.Customer.FirstOrDefaultAsync(p => p.Name.ToLower() == customerName.ToLower());
                if (customer == null)
                {
                    // add customer and Invoice
                    var newCustomer = new Customer()
                    {
                        Name = customerName,
                        PhoneNumber = phoneNumber,
                        CreationTime = DateTime.Now.ToString("yyyy-MM-dd"),
                        Address = ""
                    };
                    newCustomer.Invoice.Add(new Invoice()
                    {
                        BillNo = billNumber,
                        TotalAmount = Convert.ToInt32(purchaseAmount),
                        PurchaseDate = purchaseDate,
                        DueAmount = Convert.ToInt32(dueAmount),
                        SubmitAmount = Convert.ToInt32(submitAmount),
                        ReturnDueAmountDate = returnDate.ToString("yyyy-MM-dd"),
                    });
                    dbContext.Add(newCustomer);
                    await dbContext.SaveChangesAsync();
                    MessageBox.Show("Add the New Customer and Their Invoice.");
                }
                else
                {
                    customer.Invoice.Add(new Invoice()
                    {
                        BillNo = billNumber,
                        TotalAmount = Convert.ToInt32(purchaseAmount),
                        PurchaseDate = purchaseDate,
                        DueAmount = Convert.ToInt32(dueAmount),
                        SubmitAmount = Convert.ToInt32(submitAmount),
                        ReturnDueAmountDate = returnDate.ToString("yyyy-MM-dd"),
                    });
                    dbContext.Update(customer);
                    await dbContext.SaveChangesAsync();
                    ClearInvoice();
                    MessageBox.Show("Add the Invoice.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Contact the administrator.");
                return;
            }
        }
        private void ClearInvoice()
        {
            TBCustomer.Text = "";
            TBBill.Text = "";
            TBPAmount.Text = "";
            TBSAmount.Text = "";
            purchasedateTimePicker.Value = DateTime.Now;
            returndateTimePicker.Value = DateTime.Now;
            TBPhone.Text = "";
            TBAmount.Text = "";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddInvoicePanel.Visible = true;
        }
    }
}
