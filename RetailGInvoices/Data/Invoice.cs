using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class Invoice { 
        public int ID { get; set; }
        public string Reference { get; set; }
        public int SupplierID { get; set; }
        public int CompanyID { get; set; }
        public int SiteID { get; set; }
        public string InvoiceReference { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public Decimal GrossAmount { get; set; }
        public Decimal NetAmount { get; set; }
        public int Paid { get; set; }
        public DateTime Date { get; set; }
        public Decimal VATRate { get; set; }
        public Decimal VATAmount { get; set; }
        public int VATExempt { get; set; }
        public int PaymentTypeID { get; set; }
        

    }
}
