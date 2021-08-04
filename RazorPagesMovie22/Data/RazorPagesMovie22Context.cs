using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie22.Data
{
    public class RazorPagesMovie22Context : DbContext
    {
        public RazorPagesMovie22Context (DbContextOptions<RazorPagesMovie22Context> options)
            : base(options)
        {
        }

        public DbSet<Models.Movie> Movie { get; set; }
    }
}
