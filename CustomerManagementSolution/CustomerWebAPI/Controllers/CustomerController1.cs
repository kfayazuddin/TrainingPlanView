using CustomerManagement.Models;
using CustomerManagement.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController1 : ControllerBase
    {
        private readonly ICustomerLogin _ifl;

        public CustomerController1(ICustomerLogin context)
        {
            _ifl = context;
        }

        // GET: api/CustomerController1
        [HttpGet]
        public ActionResult<List<Customer>> GetCustomers()
        {
            var customers = _ifl.GetCustomers();
            if (customers == null || customers.Count == 0)
            {
                return NotFound();
            }
            return Ok(customers);
        }

        // GET api/CustomerController1/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            var customer = _ifl.GetByID(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        // POST api/CustomerController1
        [HttpPost]
        public ActionResult<Customer> Post([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("Customer is null.");
            }

            _ifl.Add(customer);
            return CreatedAtAction(nameof(Get), new { id = customer.Id }, customer);
        }

        // PUT api/CustomerController1/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Customer customer)
        {
            if (customer == null || customer.Id != id)
            {
                return BadRequest("Customer ID mismatch.");
            }

            var existingCustomer = _ifl.GetByID(id);
            if (existingCustomer == null)
            {
                return NotFound();
            }

            _ifl.UpdateCustomer(customer);
            return NoContent();
        }

        // DELETE api/CustomerController1/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var customer = _ifl.GetByID(id);
            if (customer == null)
            {
                return NotFound();
            }

            _ifl.Delete(id);
            return NoContent();
        }
    }
}

