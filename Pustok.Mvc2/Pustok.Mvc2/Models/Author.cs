using Pustok.Mvc2.Models.Common;

namespace Pustok.Mvc2.Models;

public class Author:BaseEntity
{
    public string FullName { get; set; }
    public List<Book> Books { get; set; }
}
