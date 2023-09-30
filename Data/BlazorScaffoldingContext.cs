using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorScaffolding.Models;

namespace BlazorScaffolding.Data
{
    public class BlazorScaffoldingContext : DbContext
    {
        public BlazorScaffoldingContext (DbContextOptions<BlazorScaffoldingContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorScaffolding.Models.Movie> Movie { get; set; } = default!;
    }
}
