using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class ExpenseLine
    {
        public ExpenseLine()
        {
            this.CreatedDateTime = DateTime.Now;
        }
        public ExpenseLine(int expenseId, int lineNumber)
        {
            this.ExpenseId = expenseId;
            this.Line = lineNumber;
            this.CreatedDateTime = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }
        public int ExpenseId { get; set; }
        public int Line { get; set; }
        [Required]
        public string Description { get; set; }
        public int VATCategory { get; set; }
        public Decimal GrossAmount { get; set; }
        [Required]
        public Decimal NetAmount { get; set; }
        public Decimal VATRate { get; set; }
        public Decimal VATAmount { get; set; }
        public bool VATExempt { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? EditDateTime { get; set; }
    }
}
