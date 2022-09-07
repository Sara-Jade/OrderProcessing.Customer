using OrderProcessing.Customer.Models;

namespace OrderProcessing.Customer.Data
{
    public class CustomerRepository
    {
        public readonly List<Person> customers = new List<Person>();

        public CustomerRepository()
        {
            customers.Add(new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = "Rosalind",
                LastName = "Franklin",
                Address = "Hyderabad, India",
                Phone = "9999999999",
                EmailAddress = "dna@yahoo.com"
            });

            customers.Add(new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = "Rose",
                LastName = "McGowen",
                Address = "Calgary, Canada",
                Phone = "1111111111",
                EmailAddress = "cultbaby@gmail.com"
            });
        }

        public Task<List<Person>> GetAllCustomers()
        {
            return Task.FromResult(customers);
        }
    }
}
