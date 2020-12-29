using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class ExpenseModel
    {
        public ExpenseModel()
        {

        }
        public ExpenseModel(int companyId)
        {
            this.expenseHead = new ExpenseHead();
            this.expenseHead.ExpenseDate = DateTime.Now;
            this.expenseHead.CreatedDateTime = DateTime.Now;
            this.expenseHead.CompanyID = companyId;

            this.ExpenseLines = new List<ExpenseLine>();
        }
        public ExpenseModel(ExpenseHead expenseHead)
        {
            this.expenseHead = expenseHead;
            this.expenseHead.CreatedDateTime = DateTime.Now;
            this.ExpenseLines = new List<ExpenseLine>();
        }

        public ExpenseModel Clone()
        {
            ExpenseModel clone = (ExpenseModel)this.MemberwiseClone();
            return clone;
        }
        public ExpenseHead expenseHead { get; set; }

        public List<ExpenseLine> ExpenseLines;
        public decimal TotalExpense { get; set; }
    }
}
