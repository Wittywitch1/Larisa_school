using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Androne_Larisa_lab2.Models;
using Androne_Larisa_lab2;

namespace Androne_Larisa_lab2.Pages.BookCategoryPages;

public class DetailsModel : PageModel
{
    private readonly Androne_Larisa_lab2Context _context;
    public DetailsModel(Androne_Larisa_lab2Context context)
    {
        _context = context;
    }

    public BookCategory BookCategory { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var bookcategory = await _context.BookCategory.FirstOrDefaultAsync(m => m.ID == id);
        if (bookcategory is null)
        {
            return NotFound();
        }
        else
        {
            BookCategory = bookcategory;
        }

        return Page();
    }
}
