using System.Security.Cryptography.X509Certificates;

namespace OrderProcessing.Customer.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
