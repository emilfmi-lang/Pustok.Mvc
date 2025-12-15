using Pustok.Mvc2.Models.Common;

namespace Pustok.Mvc2.Models;

public class BookImage:BaseEntity
{
    public string ImageUrl { get; set; }

    public int BookId { get; set; }
    public Book Book { get; set; }
}
