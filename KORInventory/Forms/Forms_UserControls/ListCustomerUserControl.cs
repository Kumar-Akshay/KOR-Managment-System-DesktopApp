using KORDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace KORInventory.Forms.Forms_UserControls
{
    public partial class ListCustomerUserControl : UserControl
    {
        private readonly Panel Content;
        private readonly CultureInfo info = CultureInfo.GetCultureInfo("en-IN");
        public ListCustomerUserControl(Panel Content)
        {
            InitializeComponent();
            //Load the Grid Data
            this.Content = Content;
            CustomerGrid.DataSource = LoadGirdData();
            GetTotalAmount(CustomerGrid);
            CustomerGrid.AutoGenerateColumns = true;
            CustomerGrid.RowHeadersVisible = false;
        }

        private dynamic LoadGirdData()
        {
            using var dbContext = new KORInventoryDBContext();
            var customersAmount = (from customer in dbContext.Customer.Include(p => p.Invoice)
                                   from invoice in customer.Invoice
                                   where invoice.DueAmount != 0 && invoice.BillNo != ""
                                   select new
                                   {
                                       CustomerName = customer.Name,
                                       TotalDueAmount = customer.Invoice.Sum(p => p.DueAmount).ToString("N2", info),
                                       ReturnDate = invoice.ReturnDueAmountDate,
                                       customer.PhoneNumber,
                                       customer.Address
                                   }).ToList();

            var customersAmountDue = (from invoice in customersAmount
                                      group invoice by invoice.CustomerName into g
                                      select new
                                      {
                                          CustomerName = g.Key,
                                          DueTotalAmount = g.Select(p => p.TotalDueAmount).FirstOrDefault(),
                                          ReturnDate = g.Select(p => p.ReturnDate).FirstOrDefault(),
                                          PhoneNumber = g.Select(p => p.PhoneNumber).FirstOrDefault(),
                                          Address = g.Select(p => p.Address).FirstOrDefault()
                                      }).OrderByDescending(p => p.DueTotalAmount).ToList();
            if (customersAmountDue.Count != 0)
            {
                return customersAmountDue;
            }
            return null;
        }

        private void GetTotalAmount(DataGridView CustomerGrid)
        {
            long sum = 0;
            for (int i = 0; i < CustomerGrid.Rows.Count; ++i)
            {
                sum += Convert.ToInt64(CustomerGrid.Rows[i].Cells[1].Value.ToString().Replace(",", "").Replace(".00", ""));
            }
            ShowAmount.Text = sum.ToString("N2", info);
            ShowCustomer.Text = CustomerGrid.Rows.Count.ToString("N2", info);
        }
        private async void CustomerSearchBox_TextChanged(object sender, EventArgs e)
        {
            var customerName = customerSearchBox.Text.ToString();
            using var dbContext = new KORInventoryDBContext();
            var customersAmount = await (from customer in dbContext.Customer.Include(p => p.Invoice)
                                   from invoice in customer.Invoice
                                   where invoice.DueAmount != 0 && invoice.BillNo != "" && customer.Name.ToLower().Contains(customerName.ToLower())
                                   select new
                                   {
                                       CustomerName = customer.Name,
                                       TotalDueAmount = customer.Invoice.Sum(p => p.DueAmount).ToString("N2", info),
                                       ReturnDate = invoice.ReturnDueAmountDate,
                                       customer.PhoneNumber,
                                       customer.Address
                                   }).ToListAsync();
            var customersAmountDue = (from invoice in customersAmount
                                      group invoice by invoice.CustomerName into g
                                      select new
                                      {
                                          CustomerName = g.Key,
                                          DueTotalAmount = g.Select(p => p.TotalDueAmount).FirstOrDefault(),
                                          ReturnDate = g.Select(p => p.ReturnDate).FirstOrDefault(),
                                          PhoneNumber = g.Select(p => p.PhoneNumber).FirstOrDefault(),
                                          Address = g.Select(p => p.Address).FirstOrDefault()
                                      }).OrderByDescending(p => p.DueTotalAmount).ToList();

            if (customersAmountDue.Count == 0)
            {
                CustomerGrid.DataSource = LoadGirdData();
            }
            CustomerGrid.DataSource = customersAmountDue;
            GetTotalAmount(CustomerGrid);
        }       
        private void CustomerGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                if (this.CustomerGrid.Rows.Count == 0)
                {
                    MessageBox.Show("No Rows Selected.");
                }
                var customerName = CustomerGrid.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
                CustomerDetailUserControl customerDetailUserControl = new CustomerDetailUserControl(Content,customerName,"dashboard");
                MainUserControl.ShowControl(customerDetailUserControl, Content);
            }
        }
    }
}
