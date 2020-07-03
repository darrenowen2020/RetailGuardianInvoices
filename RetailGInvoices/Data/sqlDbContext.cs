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

        public DbSet<RetailGInvoices.Data.Company> Company { get; set; }
        public DbSet<RetailGInvoices.Data.Site> Site { get; set; }
        public DbSet<RetailGInvoices.Data.Invoice> Invoice { get; set; }
        public DbSet<RetailGInvoices.Data.Category> Category { get; set; }
        public DbSet<RetailGInvoices.Data.VatRate> VatRate { get; set; }
        public DbSet<RetailGInvoices.Data.Supplier> Supplier { get; set; }
        public DbSet<RetailGInvoices.Data.PaymentType> PaymentType { get; set; }

    }
}
