namespace MagazineApp.Models
{
    public class Order
    {
        public int id { get; set; }
        public int Product_Id { get; set; }
        public DateTime Ordered_when { get; set; } = DateTime.Now;
        public int quantity { get; set; }
        public int price { get; set; }
        public int Order_by { get; set; }
    }
}

