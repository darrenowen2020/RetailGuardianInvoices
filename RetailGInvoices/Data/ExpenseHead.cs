using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class ExpenseHead
    {
        [Key]
        public int Id { get; set; }
        public int SupplierID { get; set; }
        public int CompanyID { get; set; }
        public int SiteID { get; set; }
        public string ExpenseReference { get; set; }
        public int PaymentTypeID { get; set; }
        public string PeriodNo { get; set; }
        public int PeriodId { get; set; }
        public string Notes { get; set; }
        public DateTime ExpenseDate { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? EditDateTime { get; set; }
        public int HeadingID { get; set; }
    }
}
