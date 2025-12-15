using Pustok.Mvc2.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pustok.Mvc2.Models;

public class Book : BaseEntity
{
    [Required]
    public string Name { get; set; }
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    public string Code { get; set; }
    public bool InStock { get; set; }
    public bool IsFeatured { get; set; }
    public bool IsNew { get; set; }
    public string Description { get; set; }
    public int DiscountPercent { get; set; }
    public string MainImageUrl { get; set; }
    public string HoverImageUrl { get; set; }
    public List<BookTag> BookTags { get; set; }
    public List<BookImage> BookImages { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
}
