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
        public float GrossAmount { get; set; }
        public float NetAmount { get; set; }
        public bool Paid { get; set; }
        public DateTime Date { get; set; }

    }
}
