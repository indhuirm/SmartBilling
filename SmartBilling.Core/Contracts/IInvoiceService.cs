using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartBilling.Core.Entities;

namespace SmartBilling.Core.Contracts
{
    public interface IInvoiceService
    {
        void AddInvoice(Invoice invoice);
        void UpdateInvoice(int Id, Invoice invoice);
        Invoice GetInvoiceById(int Id); 
        IEnumerable<Invoice> GetAllInvoice();
    }
}
