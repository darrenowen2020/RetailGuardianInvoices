using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace RetailGInvoices.Data
{
    public class SurveySite
    {
        [Key]
        public int FAD { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
