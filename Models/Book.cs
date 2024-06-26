using System.Text.Json.Serialization;

namespace Web.Models
{
    public class Book
    {
        public int BookId { get; set; }
        
        public string? Title { get; set; }
        
        public string? Author { get; set; }
        
        public string? ISBN { get; set; }
        
        public int CategoryId { get; set; }

        [JsonIgnore]
        public Category? Category { get; set; }

        public int PublisherId { get; set; }

        [JsonIgnore]
        public Publisher? Publisher { get; set; }
    }
}
