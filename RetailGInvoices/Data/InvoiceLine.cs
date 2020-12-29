using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RetailGInvoices.Data
{
    public class InvoiceLine
    {
        public InvoiceLine()
        {
            this.CreatedDateTime = DateTime.Now;
        }
        public InvoiceLine(int expenseId, int lineNumber)
        {
            this.InvoiceID = expenseId;
            this.LineNo = lineNumber;
            this.CreatedDateTime = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }
        public int InvoiceID { get; set; }
        public int LineNo { get; set; }
        public string Description { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal VATAmount { get; set; }
        public decimal NetAmount { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime EditDateTime { get; set; }
    }
}
