using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class ApplicationDbContext: DbContext
    {
        private DbSet<Book> mBook;

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Book
        {
            get { return this.mBook; }
            set { this.mBook = value; }
        }
    }
}
