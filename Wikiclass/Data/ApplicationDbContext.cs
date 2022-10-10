using Microsoft.EntityFrameworkCore;
using Wikiclass.Models;

namespace Wikiclass.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Categoria> categoria { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> tags { get; set; }
    }
}
