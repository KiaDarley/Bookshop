namespace Bookshop.Components.Schemas
{
    /// <summary>
    /// A simple Book item, with a readonly ID property, a string Title property, a string Author property and a numeric double Price property.
    /// </summary>
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public double Price { get; set; }

        /// <summary>
        /// Creates and populates a new Book object
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="price"></param>
        public Book(int id, string? title, string? author, double price)
        {
            Id = id;
            Title = title;
            Author = author;
            Price = price;
        }
    }
}
