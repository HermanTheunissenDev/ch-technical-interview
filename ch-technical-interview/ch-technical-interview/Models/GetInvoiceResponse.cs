using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ch_technical_interview.Models
{
    public class GetInvoiceResponse
    {
        public List<Invoice> Invoices { get; set; }
        public decimal InvoicesTotal { get; set; }
    }
}