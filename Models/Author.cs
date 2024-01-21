using System.ComponentModel.DataAnnotations;

namespace Streja_Raluca_Lab2.Models
    {
    public class Author
        {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public required string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public required string LastName { get; set; }
        public ICollection<Book>? Books { get; set; } //navigation property

        public string FullName => $"{FirstName} {LastName}";
        }
    }
