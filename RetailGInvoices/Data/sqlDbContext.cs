using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailGInvoices.Data;

namespace RetailGInvoices.Data
{
    public class SqlDbContext: DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options):base(options)
        {

        }

        public DbSet<Company> Company { get; set; }
        public DbSet<Site> Site { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<VatRate> VatRate { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<InvoiceView> InvoiceView { get; set; }
        public DbSet<InvoiceHeading> InvoiceHeading { get; set; }
        public DbSet<Period> Period { get; set; }
        public DbSet<ViewInvoiceGroup> viewInvoiceGroup { get; set; }
        public DbSet<ViewPeriodYears> ViewPeriodYears { get; set; }
        public DbSet<PeriodCount> PeriodCounts { get; set; }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<ExpenseView> ExpenseView { get; set; }
        public DbSet<ViewExpenseGroup> ViewExpenseGroup { get; set; }
        public DbSet<VatCategory> VatCategory { get; set; }
    }
}
