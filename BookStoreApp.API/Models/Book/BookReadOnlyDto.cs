using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.Book
{
    public class BookReadOnlyDto : BaseDto
    {
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Image { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]
        public string AuthorName { get; set; }
    }
}
