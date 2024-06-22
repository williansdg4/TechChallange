namespace Core.OutputDtos
{
    public class ContactOutputDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public int Ddd {  get; set; }
        public required string PhoneNumber { get; set; }
    }
}
