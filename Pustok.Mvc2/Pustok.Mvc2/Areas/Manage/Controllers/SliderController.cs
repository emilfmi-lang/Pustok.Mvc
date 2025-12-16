using Microsoft.AspNetCore.Mvc;
using Pustok.Mvc2.Data;

namespace Pustok.Mvc2.Areas.Manage.Controllers;
[Area("Manage")]


public class SliderController(AppDbContext appDbContext) : Controller
{
    public IActionResult Index()
    {
        var sliders = appDbContext.Sliders.ToList();
        return View(sliders);
    }
}
