using Pustok.Mvc2.Models.Common;

namespace Pustok.Mvc2.Models;

public class Slider:BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public string ButtonText { get; set; }
    public string ButtonUrl { get; set; }
    public int Order { get; set; }
}
