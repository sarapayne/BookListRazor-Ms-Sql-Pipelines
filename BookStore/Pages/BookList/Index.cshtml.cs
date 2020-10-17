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

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            Books = await mDb.Book.ToListAsync();
        }

       
        
    }
}
