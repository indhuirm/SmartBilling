using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartBilling.Core.Contracts;
using SmartBilling.Core.Entities;

namespace SmartBilling.Application.Services
{
    public delegate void InvoiceGeneratorHandler(string InvoiceId);
    public class InvoiceService : IInvoiceService
    {
        public event InvoiceGeneratorHandler OnInvoiceGenerated;
        public readonly List<Invoice> _invoice = new List<Invoice>();
        public void AddInvoice(Invoice invoice)
        {
            _invoice.Add(invoice);
            OnInvoiceGenerated?.Invoke(invoice.Id.ToString());
        }
        public IEnumerable<Invoice> GetAllInvoice() => _invoice;
        public Invoice GetInvoiceById(int id) => _invoice.FirstOrDefault(i => i.Id == id);
        public void UpdateInvoice(int id, Invoice invoice)
        {
            var existing = _invoice.FirstOrDefault(i => i.Id == id);
            if (existing != null)
            {
                existing.InvoiceAmount = invoice.InvoiceAmount;
                existing.InvoiceDate = invoice.InvoiceDate;
            }
        }
    }
}
