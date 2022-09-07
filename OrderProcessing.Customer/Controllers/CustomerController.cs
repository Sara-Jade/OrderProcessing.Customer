using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Customer.Data;
using OrderProcessing.Customer.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderProcessing.Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerRepository _customerRepository;

        public CustomerController(CustomerRepository customerRespository)
        {
            _customerRepository = customerRespository;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public List<Person> Get()
        {
            // return new string[] { "value1", "value2" };
            return _customerRepository.customers;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
