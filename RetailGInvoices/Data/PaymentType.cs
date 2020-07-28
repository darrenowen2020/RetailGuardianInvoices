using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RetailGInvoices.Data
{
    public class PaymentType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string CardIssuer { get; set; }
        public string CardNumber { get; set; }
        public bool ReconcileFlag { get; set; }
    }
}
