using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class Period
    {
        public Period()
        {
            YearNo = int.Parse(DateTime.Today.ToString("yy"));
            StartDate = DateTime.Today;
            EndDate = DateTime.Today;
        }

        [Key]
        public string PeriodKey { get; set; }
        public int PeriodNo { get; set; }
        public int YearNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
