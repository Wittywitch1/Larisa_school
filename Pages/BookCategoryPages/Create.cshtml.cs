using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Androne_Larisa_lab2.Models;
using Androne_Larisa_lab2;

namespace Androne_Larisa_lab2.Pages.BookCategoryPages;

public class CreateModel : PageModel
{
    private readonly Androne_Larisa_lab2Context _context;

    public CreateModel(Androne_Larisa_lab2Context context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public BookCategory BookCategory { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.BookCategory.Add(BookCategory);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
