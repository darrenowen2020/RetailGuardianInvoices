using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailGInvoices.Data
{
    public static class DebugReport
    {
        public static void ReportError(string text)
        {
            System.Diagnostics.Debug.WriteLine(System.Environment.StackTrace + " ** Error: " + text);
        }
    }
}
