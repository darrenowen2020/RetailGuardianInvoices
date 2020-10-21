using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class VatCategory
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; }
        public int VatRate { get; set; }
    }
}
