using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int FK_VatRateID { get; set; }

    }
}
