using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie22.Models;

namespace RazorPagesMovie22.Data
{
    public class RazorPagesMovie22Context : DbContext
    {
        public RazorPagesMovie22Context (DbContextOptions<RazorPagesMovie22Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie22.Models.Movie> Movie { get; set; }
    }
}
