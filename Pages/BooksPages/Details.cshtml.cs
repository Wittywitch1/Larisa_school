using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Androne_Larisa_lab2.Models;

namespace Androne_Larisa_lab2.Pages.BooksPages;

public class DetailsModel : PageModel
{
    private readonly Androne_Larisa_lab2Context _context;
    public DetailsModel(Androne_Larisa_lab2Context context)
    {
        _context = context;
    }

    public Book Books { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var books = await _context.Books.FirstOrDefaultAsync(m => m.ID == id);
        if (books is null)
        {
            return NotFound();
        }
        else
        {
            Books = books;
        }

        return Page();
    }
}
