using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ch_technical_interview.Models
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public DateTime Created { get; set; }
    }
}