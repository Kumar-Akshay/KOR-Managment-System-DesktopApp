using KORDAL.Models;
using KORInventory.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Threading;

namespace KORInventory.Forms.Forms_UserControls
{
    public partial class DashboardUserControl : UserControl
    {
        private Panel Content;
        private readonly System.Globalization.CultureInfo info = System.Globalization.CultureInfo.GetCultureInfo("en-IN");
        private List<InvoiceViewModel> TodayInvoice;
        private List<InvoiceViewModel> MonthInvoice;

        public DashboardUserControl(Panel Content)
        {
            InitializeComponent();
            this.Content = Content;
            TodaySaleCalculationAsync();
        }

        public async void TodaySaleCalculationAsync()
        {
            var today = DateTime.Today;
            var min = new DateTime(today.Year, today.Month, 1); // first of this month
            var max = new DateTime(today.Year, today.Month, today.Day);// first of last month

            using var dbContext = new KORInventoryDBContext();
            var customers = await dbContext.Customer.Include(p => p.Invoice).ToListAsync();
            TodayInvoice = (from customer in customers
                                from invoice in customer.Invoice
                                where invoice.PurchaseDate.Value.Date.CompareTo(DateTime.Today) == 0
                                select new InvoiceViewModel
                                {
                                    BillNo = invoice.BillNo,
                                    DueAmount = invoice.DueAmount.ToString("N2", info),
                                    TotalAmount = invoice.TotalAmount.ToString("N2", info),
                                    SubmitAmount = invoice.SubmitAmount.ToString("N2", info),
                                    ReturnDueAmountDate = invoice.ReturnDueAmountDate,
                                    PurchaseDate = (DateTime)invoice.PurchaseDate,
                                    _DueAmount = invoice.DueAmount,
                                    _TotalAmount = invoice.TotalAmount,
                                    _SubmitAmount = invoice.SubmitAmount
                                }
                         ).ToList();

            showSaleGird.DataSource = TodayInvoice;

            var noSale = TodayInvoice.Count();
            var todayTotalAmount = TodayInvoice.Sum(p => p._TotalAmount);
            this.TodaySaleLabel.Text = noSale.ToString("N2", info);
            this.TodayAmountLabel.Text = todayTotalAmount.ToString("N2", info);

            MonthInvoice = (from c in customers
                            from invoice in c.Invoice
                            where invoice.PurchaseDate.Value.Date.CompareTo(min.Date) >= 0 && invoice.PurchaseDate.Value.Date.CompareTo(max.Date) <= 0
                            select new InvoiceViewModel
                            {
                                BillNo = invoice.BillNo,
                                DueAmount = invoice.DueAmount.ToString("N2", info),
                                TotalAmount = invoice.TotalAmount.ToString("N2", info),
                                SubmitAmount = invoice.SubmitAmount.ToString("N2", info),
                                ReturnDueAmountDate = invoice.ReturnDueAmountDate,
                                PurchaseDate = (DateTime)invoice.PurchaseDate,
                                _DueAmount = invoice.DueAmount,
                                _TotalAmount = invoice.TotalAmount,
                                _SubmitAmount = invoice.SubmitAmount
                            }).ToList();

            var MonthSale = MonthInvoice.Count();
            var TotalMonthAmount = MonthInvoice.Sum(p => p._TotalAmount);
            this.MonthSaleLabel.Text = MonthSale.ToString("N2", info);
            this.MonthAmountLabel.Text = TotalMonthAmount.ToString("N2", info);

        }

        private void TodayradioButton_CheckedChanged(object sender, EventArgs e)
        {
            showSaleGird.DataSource = TodayInvoice;
        }

        private void TodayDueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var todayDueInvoice = TodayInvoice.Where(p => p._DueAmount != 0).ToList();
            showSaleGird.DataSource = todayDueInvoice;
        }

        private void MonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            showSaleGird.DataSource = MonthInvoice;
        }

        private void MonthDueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var monthDueInvoice = MonthInvoice.Where(p => p._DueAmount != 0).ToList();
            showSaleGird.DataSource = monthDueInvoice;
        }

        private void SearchBillTB_TextChanged(object sender, EventArgs e)
        {
            var searchbill = SearchBillTB.Text;
            var invoices = MonthInvoice.Where(p => p.BillNo.Contains(searchbill)).ToList();
            showSaleGird.DataSource = invoices;
        }
    }
}
