using OrderProcessing.Customer.Models;

namespace OrderProcessing.Customer.Data
{
    public class CustomerRepository
    {
        public readonly List<Person> customers = new List<Person>();

        public CustomerRepository()
        {
            Person customer1 = new Person()
            {
                Id = Guid.NewGuid(),
                Name = "My BFF Rose",
                Address = "123 Friend St",
                PhoneNumber = "206-123-4567"
            };
            Person customer2 = new Person()
            {
                Id = Guid.NewGuid(),
                Name = "Rosie the Riveter",
                Address = "123 Mfr St",
                PhoneNumber = "908-123-4567"
            };
            Person customer3 = new Person()
            {
                Id = Guid.NewGuid(),
                Name = "Rosalind Franklin",
                Address = "123 DNA St",
                PhoneNumber = "312-123-4567"
            };
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
        }
    }
}
