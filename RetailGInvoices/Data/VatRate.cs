using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class VatRate
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public float Rate { get; set; }
    }
}
