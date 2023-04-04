namespace MagazineApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string CreatedAT { get; set; }
        public DateTime CreatedDate { get; set;}
        public string Creator { get; set; }
    }
}
