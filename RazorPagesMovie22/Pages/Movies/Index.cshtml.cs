using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie22.Models;

namespace RazorPagesMovie22.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie22.Data.RazorPagesMovie22Context _context;

        public IndexModel(RazorPagesMovie22.Data.RazorPagesMovie22Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
