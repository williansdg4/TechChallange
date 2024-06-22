namespace Core.Entities
{
    public class Regions
    {
        public required int Ddd { get; set; }
        public string? RegionName { get; set; }
        public ICollection<Contacts> Contacts { get; set; }
    }
}
