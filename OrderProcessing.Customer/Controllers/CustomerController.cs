using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Customer.Data;
using OrderProcessing.Customer.Models;

namespace OrderProcessing.Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet("GetAllCustomers")]
        public async Task<List<Person>> GetAllCustomers()
        {
            return await _customerRepository.GetAllCustomers();
        }
    }
}
