using Pustok.Mvc2.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace Pustok.Mvc2.Models;

public class Author:BaseEntity
{
    [Required]
    [MaxLength(20)]
    public string FullName { get; set; }
    public List<Book>? Books { get; set; }
    //public Author()
}
