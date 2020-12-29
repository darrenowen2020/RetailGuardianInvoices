using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class Invoice {
        public Invoice(int companyId)
        {
            this.CompanyID = companyId;
        }
        public Invoice()
        {

        }
        [Key]
        public int ID { get; set; }
        public int LineNo { get; set; }
        public string Reference { get; set; }
        [Required]
        public int SupplierID { get; set; }
        public int CompanyID { get; set; }
        public int SiteID { get; set; }
        public string InvoiceReference { get; set; }
        [Required]
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public Decimal GrossAmount { get; set; }
        [Required]
        public Decimal NetAmount { get; set; }
        public bool Paid { get; set; }
        public DateTime Date { get; set; }
        public Decimal VATRate { get; set; }
        public Decimal VATAmount { get; set; }
        public int VATExempt { get; set; }
        public int PaymentTypeID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EditDate { get; set; }
        public string Notes { get; set; }
        public string PeriodNo { get; set; }
        public int Heading { get; set; }
        public int PeriodId { get; set; }
    }
}
