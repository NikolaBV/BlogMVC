using BlogMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogMVC.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
    }
}
