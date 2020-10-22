using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class ExpenseView
    {
        [Key]
        public int ExpenseId { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string SupplierName { get; set; }
        public string SiteName { get; set; }
        public string ExpenseReference { get; set; }
        public string ExpenseDescription { get; set; }
        public decimal ExpenseGross { get; set; }
        public decimal ExpenseVAT { get; set; }
        public decimal ExpenseNet { get; set; }
        public string ExpensePaymentType { get; set; }
        public string ExpensePaymentDescription { get; set; }
        public bool ExpensePaid { get; set; }
        public DateTime ExpenseCreatedDate { get; set; }
        public DateTime ExpenseEditDate { get; set; }
        public string ExpensePeriod { get; set; }
        public int PeriodYearNo { get; set; }
        public string Heading { get; set; }
        public int HeadingId { get; set; }
        public int ExpensePaymentId { get; set; }
        public int ExpenseSupplierId { get; set; }
        public int ExpenseSiteId { get; set; }
        public string ExpenseNotes { get; set; }
        public bool ExpensePaymentReconcile { get; set; }
        public int ExpenseCompanyId { get; set; }
        public int ExpenseVatCategory { get; set; }
        public string RowClass => (ExpenseNotes == null) ? null: "table-info";
    }
}
