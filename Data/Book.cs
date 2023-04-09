using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace BPC.Data
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]

        public string Name { get; set; }

        public Decimal Price { get; set; }

        [Range(0, 500)]
        [Display(Name = "Page Count")]
        public int PageCount { get; set; }

        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }

        public int? PublisherId { get; set; }

        public virtual Publisher? Publisher { get; set; }

        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }

        public Buy? Buy { get; set; }

    }

    public class Publisher
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        //ICollection da yapabilirdik 
        public virtual List<Book>? Books { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Book>? Books { get; set; }
    }
    public class Buy
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public int CardNumber { get; set; }
        public virtual Book? Name { get; set; }

        public virtual Book? Price { get; set; }

        public int BookId { get; set; }
        public virtual ICollection<Book>? Books { get; set; }
    }
}
