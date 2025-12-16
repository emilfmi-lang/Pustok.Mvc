using Microsoft.AspNetCore.Mvc;
using Pustok.Mvc2.Data;

namespace Pustok.Mvc2.Areas.Manage.Controllers;
[Area("Manage")]

public class AuthorController(AppDbContext appDbContext) : Controller
{
    public IActionResult Index()
    {

        var authors = appDbContext.Authors.ToList();
        return View(authors);
    }
}
