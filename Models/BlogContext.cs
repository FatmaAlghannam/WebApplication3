using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blog { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("data source=MyDB.DATABase");
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }

}
