using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ch_technical_interview.Models
{
    public class InvoiceItem
    {
        public Guid InvoiceItemId { get; set; }
        public Guid InvoiceId { get; set; }
        public Item Item { get; set; }
    }
}