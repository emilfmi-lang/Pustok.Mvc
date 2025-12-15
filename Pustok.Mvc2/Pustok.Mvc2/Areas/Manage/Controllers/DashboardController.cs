using Microsoft.AspNetCore.Mvc;

namespace Pustok.Mvc2.Areas.Manage.Controllers;
[Area("Manage")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
