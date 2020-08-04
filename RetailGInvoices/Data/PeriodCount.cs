using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class PeriodCount
    {
        [Key]
        public int CompanyId { get; set; }
        public int Count { get; set; }
    }
}
