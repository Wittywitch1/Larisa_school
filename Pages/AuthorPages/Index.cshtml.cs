using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Androne_Larisa_lab2.Models;
using Androne_Larisa_lab2;

namespace Androne_Larisa_lab2.Pages.AuthorPages;

public class IndexModel : PageModel
{
    private readonly Androne_Larisa_lab2Context _context;

    public IndexModel(Androne_Larisa_lab2Context context)
    {
        _context = context;
    }

    public IList<Author> Author { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Author = await _context.Authors.ToListAsync();
    }
}
