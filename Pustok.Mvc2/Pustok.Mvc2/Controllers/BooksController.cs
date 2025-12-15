using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Mvc2.Data;
using Pustok.Mvc2.Services;
using Pustok.Mvc2.ViewModels;

namespace Pustok.Mvc2.Controllers
{
    public class BooksController(AppDbContext appDbContext ) : Controller
    {
        public IActionResult Details(int id)
        {
            var book = appDbContext.Books
                .Include(x => x.BookImages)
                .Include(x => x.Author)
                .Include(x => x.BookTags)
                    .ThenInclude(bt => bt.Tag)
                .FirstOrDefault(b => b.Id == id);
            if (book == null) 
                return NotFound();
            BookVm bookVm = new BookVm
            {
                Book = book,
                RelatedBooks = appDbContext.Books
                .Include (x => x.Author)
                .Include(x => x.BookImages)
                .Where(b => b.AuthorId == book.AuthorId && b.Id != book.Id)
                .Take(4)
                .ToList()

            };
            return View(bookVm);
        }

        public IActionResult BookModal(int id)
        {
            var book = appDbContext.Books
                .Include(x => x.BookImages)
                .Include(x => x.Author)
                .Include(x => x.BookTags)
                    .ThenInclude(bt => bt.Tag)
                .FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();
            return PartialView("_BookModalPartial", book);
        }

    }
}
