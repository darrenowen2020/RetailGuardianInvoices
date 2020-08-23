using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class ViewExpenseGroup
    {
        public string Heading { get; set; }
        public int HeadingId { get; set; }
        public decimal ExpenseGross { get; set; }
        public decimal ExpenseVAT { get; set; }
        public decimal ExpenseNet { get; set; }
        public int ExpensePaymentId { get; set; }
        [Key]
        public string ViewGroupID { get; set; }
        public int ExpenseCompanyId { get; set; }
    }
}
