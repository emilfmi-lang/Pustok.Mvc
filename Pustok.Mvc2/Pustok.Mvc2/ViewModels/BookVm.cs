using Pustok.Mvc2.Models;

namespace Pustok.Mvc2.ViewModels
{
    public class BookVm
    {
        public Book Book { get; set; }
        public List<Book> RelatedBooks { get; set; }
    }
}
