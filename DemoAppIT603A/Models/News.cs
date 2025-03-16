namespace DemoAppIT603A.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public decimal Price { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public int CreatedById { get; set; } //UserId
    }
}
