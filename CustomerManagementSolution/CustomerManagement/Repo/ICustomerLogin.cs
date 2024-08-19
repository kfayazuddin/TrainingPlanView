using CustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Repo
{
    public interface ICustomerLogin
    {
        public Customer ValidateUser(int id, string name);
        public List<Customer> GetCustomers();
        public Customer GetByID(int id);
        public void Add(Customer customer);
        public void Delete(int id);
        public void UpdateCustomer(Customer customer);
    }
}
