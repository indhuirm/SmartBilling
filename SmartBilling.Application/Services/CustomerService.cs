using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartBilling.Core.Contracts;
using SmartBilling.Core.Entities;

namespace SmartBilling.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly List<Customer> _customer;
        public void AddCustomer(Customer customer)
        {
            customer.Id = _customer.Count + 1;
            _customer.Add(customer);
        }

        public IEnumerable<Customer> GetAllCustomer(int id) => _customer;

        public Customer GetIdByCustomer(int id) => _customer.FirstOrDefault(i => i.Id == id);

        public void UpdateCustomer(int id, Customer customer)
        {
            var existing = _customer.FirstOrDefault(i => i.Id == id);
            if (existing != null)
            {
                existing.Name = customer.Name;
                existing.Email = customer.Email;
            }
        }
    }
}
