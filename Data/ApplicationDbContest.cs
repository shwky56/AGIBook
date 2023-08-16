using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using book_stor.Models;
using Microsoft.Data.SqlClient;

namespace book_stor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categorys { get; set; }
  
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "test1", DisplayOrdaer = 1, Description = "sdf" },
                new Category { Id = 2, Name = "test2", DisplayOrdaer = 2, Description = "sdf"} 
            );
        }
    }
}