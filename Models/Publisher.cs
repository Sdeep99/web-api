namespace Web.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        
        public string? Name { get; set; }
        
        public string? PhoneNumber { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
