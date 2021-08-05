using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class Library : DbContext
    {
        public Library(DbContextOptions<Library> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Lendings> Lendings { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
