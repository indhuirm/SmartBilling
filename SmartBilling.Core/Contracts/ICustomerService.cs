using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartBilling.Core.Entities;

namespace SmartBilling.Core.Contracts
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        void UpdateCustomer(int Id, Customer customer);
        Customer GetIdByCustomer(int id); 
        IEnumerable<Customer> GetAllCustomer();

    }
}
