using System;
using System.Collections.Generic;
using System.Text;

namespace KORInventory.DAL
{
    public class Invoice
    {
        public string InvoiceId { get; set; }
        public string ID { get; set; }
        public string BillNo { get; set; }
        public string DueAmount { get; set; }
        public string SubmitAmount { get; set; }
        public string TotalAmount { get; set; }
        public string DueAmountDate { get; set; }
        public string PurchaseDate { get; set; }
    }
}
