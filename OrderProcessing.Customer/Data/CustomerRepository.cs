using OrderProcessing.Customer.Models;

namespace OrderProcessing.Customer.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Person> customers = new List<Person>();

        public CustomerRepository()
        {
            customers.Add(new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = "Kanika",
                LastName = "Kanjilal",
                Address = "Hyderabad, India",
                Phone = "9999999999",
                EmailAddress = "kanjilal@yahoo.com"
            });

            customers.Add(new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = "Jeanne",
                LastName = "Smith",
                Address = "Calgary, Canada",
                Phone = "1111111111",
                EmailAddress = "jsmith@gmail.com"
            });
        }
        public Task<List<Person>> GetAllCustomers()
        {
            return Task.FromResult(customers);
        }
    }
}
