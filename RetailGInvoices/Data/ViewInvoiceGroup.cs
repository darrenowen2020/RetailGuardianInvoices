using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class ViewInvoiceGroup
    {
        [Key]
        public string InvoiceDescription { get; set; }
        public decimal InvoiceGross { get; set; }
        public decimal InvoiceVAT { get; set; }
        public decimal InvoiceNet { get; set; }
    }
}
