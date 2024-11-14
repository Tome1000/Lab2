using Lab2.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
