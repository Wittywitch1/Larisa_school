using Microsoft.EntityFrameworkCore;

namespace Androne_Larisa_lab2
{
    public class Androne_Larisa_lab2Context : DbContext
    {
        public Androne_Larisa_lab2Context(DbContextOptions<Androne_Larisa_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Androne_Larisa_lab2.Models.Books> Books { get; set; } = default!;
    }
}
