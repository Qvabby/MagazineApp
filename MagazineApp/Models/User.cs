using System.Numerics;

namespace MagazineApp.Models
{
    public class User
    {
        public int id { get; set; }
        public string Name { get; set;}
        public string Lastname { get; set; }
        public string email { get; set;}
        public string password { get; set;}
        public string phone_Number { get; set;}
        public string username { get; set; }
        public long identity { get; set; }
        public float balnace { get; set; }
        public DateTime BirthDate { get; set; }
        public Role role { get;set;}
    } 
}
