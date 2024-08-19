using CustomerManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerManagement.Repo
{
    public class CustomerLogin : ICustomerLogin
    {
        private readonly CustomermngContext _context;

        public CustomerLogin(CustomermngContext context)
        {
            _context = context;
        }

        public Customer GetByID(int id)
        {
            return _context.Customers.FirstOrDefault(u => u.Id == id);
        }

        public void Delete(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        public void UpdateCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            var existingCustomer = _context.Customers.Find(customer.Id);
            if (existingCustomer == null)
            {
                throw new InvalidOperationException("Customer not found.");
            }

            // Update the existing customer with the new values
            _context.Entry(existingCustomer).CurrentValues.SetValues(customer);

            _context.SaveChanges();
        }

        public Customer ValidateUser(int id, string name)
        {
            return _context.Customers.FirstOrDefault(u => u.Id == id && u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
    }
}



 
