using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Mvc2.Data;
using Pustok.Mvc2.ViewModels;

namespace Pustok.Mvc2.Controllers
{
    public class HomeController(AppDbContext appDbContext) : Controller
    {
        public IActionResult Index()
        {
            HomeVm homeVm = new HomeVm
            {
                Sliders = appDbContext.Sliders.ToList(),
                FeaturedBooks = appDbContext.Books
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                    .Where(b => b.IsFeatured)
                    .ToList(),
                NewBooks = appDbContext.Books.
                Include(x => x.BookImages).
                Include(x => x.Author)
                    .Where(b => b.IsNew)
                    .ToList(),
                DisCountBooks = appDbContext.Books.Include(x => x.BookImages)
                .Include(x => x.Author).Where(b => b.DiscountPercent > 0).ToList()
            };
            return View(homeVm);
        }


        public IActionResult Test()
        {
            var books = appDbContext.Books
                .Include(x => x.BookImages)
                .Include(x => x.Author)
                .Where(b => b.IsFeatured)
                .ToList();
            return PartialView("_BooksPartial",books);
        }
    }
}
