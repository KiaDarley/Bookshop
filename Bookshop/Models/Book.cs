namespace Bookshop.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public double Price { get; set; }

        public Book(int id, string? title, string? author, double price)
        {
            Id = id;
            Title = title;
            Author = author;
            Price = price;
        }
    }
}
