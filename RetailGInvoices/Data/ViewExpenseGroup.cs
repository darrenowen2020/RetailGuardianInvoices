using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class ViewExpenseGroup
    {
        public decimal ExpenseGross { get; set; }
        public decimal ExpenseVAT { get; set; }
        public decimal ExpenseNet { get; set; }
        [Key]
        public int ExpensePaymentId { get; set; }
        public int ExpenseCompanyId { get; set; }
    }
}
