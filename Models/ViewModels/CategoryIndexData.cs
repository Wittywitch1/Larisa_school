using Androne_Larisa_lab2.Models;

namespace Androne_Larisa_lab2.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }
    }
}