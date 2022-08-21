namespace OrderProcessing.Customer.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = "OneFish";
        public string LastName { get; set; } = "TowFish";
        public string Address { get; set; } = "123 Test St.";
        public string Phone { get; set; } = "206-123-4567";
        public string EmailAddress { get; set; } = "RedFishBlueFish@gmail.com";
    }
}
