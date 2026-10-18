using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Androne_Larisa_lab2.Models;
using Androne_Larisa_lab2;

namespace Androne_Larisa_lab2.Pages.PublisherPages;

public class IndexModel : PageModel
{
    private readonly Androne_Larisa_lab2Context _context;

    public IndexModel(Androne_Larisa_lab2Context context)
    {
        _context = context;
    }

    public IList<Publisher> Publisher { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Publisher = await _context.Publisher.ToListAsync();
    }
}
