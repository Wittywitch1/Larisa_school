using Androne_Larisa_lab2.Models;
using Androne_Larisa_lab2.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Androne_Larisa_lab2.Pages.CategoryPages
{
    public class IndexModel : PageModel
    {
        private readonly Androne_Larisa_lab2Context _context;

        public IndexModel(Androne_Larisa_lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get; set; } = default!;

        public CategoryIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }

        public async Task OnGetAsync(int? id)
        {
            CategoryData = new CategoryIndexData();
            CategoryData.Categories = await _context.Category
                .Include(c => c.BookCategories)
                    .ThenInclude(bc => bc.Book)
                        .ThenInclude(b => b.Author)
                .OrderBy(c => c.CategoryName)
                .ToListAsync();

            if (id != null)
            {
                CategoryID = id.Value;
                Category category = CategoryData.Categories
                    .Where(i => i.ID == id.Value).Single();
                CategoryData.BookCategories = category.BookCategories;
            }
        }
    }
}