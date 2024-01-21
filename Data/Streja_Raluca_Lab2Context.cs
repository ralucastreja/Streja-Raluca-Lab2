using Microsoft.EntityFrameworkCore;
using Streja_Raluca_Lab2.Models;

namespace Streja_Raluca_Lab2.Data
    {
    public class Streja_Raluca_Lab2Context(DbContextOptions<Streja_Raluca_Lab2Context> options) : DbContext(options)
        {
        public DbSet<Book> Book { get; set; } = default!;
        public DbSet<Author> Author { get; set; } = default!;
        public DbSet<Publisher> Publisher { get; set; } = default!;
        }
    }
