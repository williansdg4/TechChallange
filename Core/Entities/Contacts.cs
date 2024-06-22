namespace Core.Entities
{
    public class Contacts
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required Regions Region { get; set; }
    }
}
