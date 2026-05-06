using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBilling.Core.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal InvoiceAmount { get; set; } 
        public DateTime InvoiceDate { get; set; } 
    }
}
