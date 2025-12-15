using Pustok.Mvc2.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pustok.Mvc2.ViewModels
{
    public class BookDetailVm
    {

        public string Name { get; set; }

        public decimal Price { get; set; }
        public string Code { get; set; }
        public bool InStock { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsNew { get; set; }
        public string Description { get; set; }
        public decimal DiscountPercent { get; set; }
        public string MainImageUrl { get; set; }
        public string HoverImageUrl { get; set; }
        public List<string> TagNames { get; set; }
        public List<string> BookImageUrls { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
