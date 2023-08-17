using System.ComponentModel.DataAnnotations;

namespace book_stor.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public User()
        {
            this.Books = new HashSet<Book>();
        }

    }
}
