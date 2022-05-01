using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KORDAL.Models
{
    public partial class Invoice
    {
        public long Id { get; set; }
        public string BillNo { get; set; }
        public int DueAmount { get; set; }
        public int SubmitAmount { get; set; }
        public int TotalAmount { get; set; }
        public string ReturnDueAmountDate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public long? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
