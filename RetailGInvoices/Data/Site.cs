﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public class Site
    {
        public Site()
        {
            SiteName = "";
            Address1 = "";
            Address2 = "";
            Address3 = "";
            Address4 = "";
            Postcode = "";
            VATCode = "";
            FK_CompanyId = 1;
        }

        [Key]
        public int Id { get; set; }
        public string SiteName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Postcode { get; set; }
        public int FK_CompanyId { get; set; }
        public string VATCode { get; set; }
    }
}
