using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Mvc2.Data;
using Pustok.Mvc2.ViewModels;

namespace Pustok.Mvc2.Controllers
{
    public class BooksController(AppDbContext appDbContext) : Controller
    {
        public IActionResult Details(int id)
        {
            var book = appDbContext.Books
                .Include(x => x.BookImages)
                .Include(x => x.Author)
                .FirstOrDefault(b => b.Id == id);
            if (book == null) 
                return NotFound();
            BookVm bookVm = new BookVm
            {
                Book = book
            };
            return View(bookVm);
        }
    }
}
