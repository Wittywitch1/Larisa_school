using Androne_Larisa_lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Androne_Larisa_lab2.Pages.BooksPages;

public class CreateModel : PageModel
{
    private readonly Androne_Larisa_lab2Context _context;

    public CreateModel(Androne_Larisa_lab2Context context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID",
"PublisherName");
        return Page();
    }

    [BindProperty]
    public Book Books { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Books.Add(Books);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
