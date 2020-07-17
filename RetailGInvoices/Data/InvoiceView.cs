using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class InvoiceView
    {
        [Key]
        public int InvoiceId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string SupplierName { get; set; }
        public string SiteName { get; set; }
        public string InvoiceReference { get; set; }
        public string InvoiceDescription { get; set; }
        public decimal InvoiceGross { get; set; }
        public decimal InvoiceVAT { get; set; }
        public decimal InvoiceNet { get; set; }
        public string InvoicePaymentType { get; set; }
        public string InvoicePaymentDescription { get; set; }
        public bool InvoicePaid { get; set; }
        public DateTime InvoiceCreatedDate { get; set; }
        public DateTime InvoiceEditDate { get; set; }
        public string InvoicePeriod { get; set; }
        public int PeriodYearNo { get; set; }
        public string InvoiceHeading { get; set; }
        public int InvoiceHeadingId { get; set; }
        public int InvoicePaymentId { get; set; }
        public int InvoiceSupplierId { get; set; }
        public int InvoiceSiteId { get; set; }
        public string InvoiceNotes { get; set; }
    }
}
