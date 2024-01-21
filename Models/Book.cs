using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streja_Raluca_Lab2.Models
    {
    public class Book
        {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public required string Title { get; set; }
        public int AuthorID { get; set; } // foreign key
        [Display(Name = "Author Name")]
        public Author? Author { get; set; } // navigation property
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Publishing Date")]
        public DateTime? PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        [Display(Name = "Publisher Name")]
        public Publisher? Publisher { get; set; } // navigation property
        }
    }
