using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace test.Models
{
    internal class LibraryContext:DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Book> Books { get; set; }
                    
        public virtual DbSet<Member> Members { get; set; }

        public virtual DbSet<Borrowing> Borrowings { get; set; }

        public virtual DbSet<Logs> Logs { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer(@"Server=DESKTOP-JEJ8BBV\SQLEXPRESS;Database=Library;Trusted_Connection=True;TrustServerCertificate=True;");



        }



    }
}
