using System.ComponentModel.DataAnnotations;

namespace book_stor.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Author { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int PublishYear { get; set; }
        public virtual ICollection<User> Users { get; set; } 

        public Book()
        {
            this.Users = new HashSet<User>();
        }


    }
}
