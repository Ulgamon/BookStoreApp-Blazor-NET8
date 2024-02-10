using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.Book
{
    public class BookDetailsDto: BaseDto
    {
        public string Title { get; set; }
        public int Year { get; set; }

        public string Isbn { get; set; } = null!;

        public string Summary { get; set; } = null!;

        public string Image { get; set; } = null!;

        public decimal Price { get; set; }

        public int AuthorId { get; set; }

        public string AuthorName { get; set; }

    }
}
