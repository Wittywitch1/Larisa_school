using Microsoft.EntityFrameworkCore;
using Androne_Larisa_lab2.Models;

namespace Androne_Larisa_lab2
{
    public class Androne_Larisa_lab2Context : DbContext
    {
        public Androne_Larisa_lab2Context(
            DbContextOptions<Androne_Larisa_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Publisher> Publisher { get; set; } = default!;

        public DbSet<Book> Books { get; set; } = default!;

        public DbSet<Author> Authors { get; set; } = default!;
    }
}