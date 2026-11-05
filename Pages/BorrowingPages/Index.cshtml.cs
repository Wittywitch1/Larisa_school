using Androne_Larisa_lab2.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Androne_Larisa_lab2.Pages.BorrowingPages
{
    public class IndexModel : PageModel
    {
        private readonly Androne_Larisa_lab2Context _context;

        public IndexModel(Androne_Larisa_lab2Context context)
        {
            _context = context;
        }

        public IList<Borrowing> Borrowing { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Borrowing != null)
            {
                Borrowing = await _context.Borrowing
                    .Include(b => b.Book)
                        .ThenInclude(b => b.Author)
                    .Include(b => b.Member).ToListAsync();
            }
        }
    }
}