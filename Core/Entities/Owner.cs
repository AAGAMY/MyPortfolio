namespace Core.Entities
{
    public class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public Address address { get; set; }

    }

}
