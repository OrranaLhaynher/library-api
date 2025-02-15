namespace MyFirstAPI.Entities
{
    public enum GenreEnum
    {
        Fiction, Romance, Horror, Comedy, Scifi, Business, Thriller
    }
    public class Book
    {
        public Guid ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
