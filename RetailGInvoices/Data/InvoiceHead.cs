using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RetailGInvoices.Data
{
    public class InvoiceHead
    {
        [Key]
        public int Id { get; set; }
        public int SupplierID { get; set; }
        public int CompanyID { get; set; }
        public int SiteID { get; set; }
        public string Reference { get; set; }
        public string PeriodNo { get; set; }
        public int PeriodID { get; set; }
        public string Notes { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime EditDateTime { get; set; }
        public int PaymentTypeID { get; set; }
        public bool Paid { get; set; }
        public int HeadingID { get; set; }
    }
}
