using Microsoft.EntityFrameworkCore;
using MyPortfolioBlog.Models;

namespace MyPortfolioBlog.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}