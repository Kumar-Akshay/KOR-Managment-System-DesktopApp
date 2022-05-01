using System;
using System.Collections.Generic;
using System.Text;

namespace KORInventory.Model
{
    public class InvoiceViewModel
    {
        public string BillNo { get; set; }
        public string DueAmount { get; set; }
        public string TotalAmount { get; set; }
        public string SubmitAmount { get; set; }
        public string ReturnDueAmountDate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int _DueAmount { get; set; }
        public int _TotalAmount { get; set; }
        public int _SubmitAmount { get; set; }
    }
}
