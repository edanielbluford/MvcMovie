using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MovieMvc.Models
{
    public class MovieMvcContext : DbContext
    {
        public MovieMvcContext (DbContextOptions<MovieMvcContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
