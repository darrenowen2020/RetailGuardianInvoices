﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailGInvoices.Data;
using RetailGExpenses.Data;

namespace RetailGInvoices.Data
{
    public class SqlDbContext: DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options):base(options)
        {

        }

        public DbSet<RetailGInvoices.Data.Company> Company { get; set; }
        public DbSet<RetailGInvoices.Data.Site> Site { get; set; }
        public DbSet<RetailGInvoices.Data.Invoice> Invoice { get; set; }
        public DbSet<RetailGInvoices.Data.Category> Category { get; set; }
        public DbSet<RetailGInvoices.Data.VatRate> VatRate { get; set; }
        public DbSet<RetailGInvoices.Data.Supplier> Supplier { get; set; }
        public DbSet<RetailGInvoices.Data.PaymentType> PaymentType { get; set; }
        public DbSet<RetailGInvoices.Data.InvoiceView> InvoiceView { get; set; }
        public DbSet<RetailGInvoices.Data.InvoiceHeading> InvoiceHeading { get; set; }
        public DbSet<RetailGInvoices.Data.Period> Period { get; set; }
        public DbSet<RetailGInvoices.Data.ViewInvoiceGroup> viewInvoiceGroup { get; set; }
        public DbSet<RetailGInvoices.Data.ViewPeriodYears> ViewPeriodYears { get; set; }
        public DbSet<RetailGInvoices.Data.PeriodCount> PeriodCounts { get; set; }
        public DbSet<RetailGExpenses.Data.Expense> Expense { get; set; }
    }
}
