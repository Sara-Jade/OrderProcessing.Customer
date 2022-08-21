using OrderProcessing.Customer.Models;

namespace OrderProcessing.Customer.Data
{
    public interface ICustomerRepository
    {
        Task<List<Person>> GetAllCustomers();
    }
}
