
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataInfruStructure.DbContextFolder;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Product> products { get; set; }
    public DbSet<Category> categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Product>().HasKey(p => p.Id);
        modelBuilder.Entity<Category>().HasKey(c => c.Id);

        base.OnModelCreating(modelBuilder);
    }


}
