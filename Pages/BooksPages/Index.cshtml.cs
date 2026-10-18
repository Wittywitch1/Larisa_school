using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Androne_Larisa_lab2.Models;

namespace Androne_Larisa_lab2.Pages.BooksPages;

public class IndexModel : PageModel
{
    private readonly Androne_Larisa_lab2Context _context;

    public IndexModel(Androne_Larisa_lab2Context context)
    {
        _context = context;
    }

    public IList<Book> Books { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Books = await _context.Books
            .Include(b => b.Publisher)
            .ToListAsync();
    }
}
