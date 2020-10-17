using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext mDatabase;

        public CreateModel(ApplicationDbContext database)
        {
            mDatabase = database;
        }

        public Book book { get; set; }

        public void OnGet()
        {
        }
    }
}
