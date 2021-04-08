using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookTalk.Data;
using BookTalk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookTalk.Pages
{
    public class StoreModel : PageModel
    {
        public string Name { get; private set; }

        public List<Book> Books { get; private set; }

        private Context _context;

        public StoreModel(Context context)
        {
            _context = context;
            Books = _context.Books.ToList();
        }

        public void OnGet()
        {

        }

        public void OnPostAddToCart(string bookId)
        {
            CustomerCart.AddToCart(bookId);
        }


    }
}
