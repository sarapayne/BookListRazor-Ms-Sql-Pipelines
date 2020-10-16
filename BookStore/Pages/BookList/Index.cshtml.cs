using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStore.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext mDb;

        public IndexModel(ApplicationDbContext db)
        {
            mDb = db;
        }

        private IEnumerable<Book> mBooks;

        public async Task OnGet()
        {
            mBooks = await mDb.Book.ToListAsync();
        }

        public IEnumerable<Book> Books
        {
            get { return mBooks; }
            set { this.mBooks = value; }
        }
    }
}
