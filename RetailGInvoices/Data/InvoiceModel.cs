using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class InvoiceModel
    {
        public InvoiceModel()
        {

        }
        public InvoiceModel(int companyId)
        {
            this.invoiceHead = new InvoiceHead();
            this.invoiceHead.InvoiceDate = DateTime.Now;
            this.invoiceHead.CreatedDateTime = DateTime.Now;
            this.invoiceHead.CompanyID = companyId;

            this.InvoiceLines = new List<InvoiceLine>();
        }
        public InvoiceModel(InvoiceHead invoiceHead)
        {
            this.invoiceHead = invoiceHead;
            this.invoiceHead.CreatedDateTime = DateTime.Now;
            this.InvoiceLines = new List<InvoiceLine>();
        }

        public InvoiceModel Clone()
        {
            InvoiceModel clone = (InvoiceModel)this.MemberwiseClone();
            return clone;
        }
        public InvoiceHead invoiceHead { get; set; }

        public List<InvoiceLine> InvoiceLines;
        public decimal TotalInvoice { get; set; }
    }
}
