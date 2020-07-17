using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class ViewInvoiceGroup
    {
        public string InvoiceHeading { get; set; }
        [Key]
        public int InvoiceHeadingId { get; set; }
        public decimal InvoiceGross { get; set; }
        public decimal InvoiceVAT { get; set; }
        public decimal InvoiceNet { get; set; }
        public int InvoicePaymentId { get; set; }
    }
}
