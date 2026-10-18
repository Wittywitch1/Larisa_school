using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Androne_Larisa_lab2.Models;

namespace Androne_Larisa_lab2.Pages.BooksPages;

public class EditModel : PageModel
{
    private readonly Androne_Larisa_lab2Context _context;

    public EditModel(Androne_Larisa_lab2Context context)
    {
        _context = context;
    }

    [BindProperty]
    public Books Books { get; set; } = default!;

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
        Books = books;
        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(Books).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!BooksExists(Books.ID))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Index");
    }

    private bool BooksExists(int id)
    {
        return _context.Books.Any(e => e.ID == id);
    }
}
