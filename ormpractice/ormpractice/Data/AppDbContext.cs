using Microsoft.EntityFrameworkCore;
using ormpractice.Models;

namespace ormpractice.Data;

public class AppDbContext: DbContext
{
    public DbSet<Order> Orders { get; set; }
    
    public DbSet<User> Users { get; set; }
    
    public DbSet<OrderItem> OrderItems { get; set; }
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ConsoleAppDb2;User Id=sa;Password=CodeWithArjun123;TrustServerCertificate=True;");
    }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
    
    
}