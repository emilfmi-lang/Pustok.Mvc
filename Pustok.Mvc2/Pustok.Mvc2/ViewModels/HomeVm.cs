using Pustok.Mvc2.Models;

namespace Pustok.Mvc2.ViewModels;

public class HomeVm
{
    public List<Slider> Sliders { get; set; }
    public List<Book> FeaturedBooks { get; set; }
    public List<Book> NewBooks { get; set; }
    public List<Book> DisCountBooks { get; set; }
}
