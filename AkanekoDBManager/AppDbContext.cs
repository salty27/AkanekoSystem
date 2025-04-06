using AkanekoDBManager.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AkanekoSystem.core;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configurationBuilder = new ConfigurationBuilder();
        configurationBuilder.AddJsonFile("dbsettings.json");
        //Server=127.0.0.1;Port=5432;Database=postgres;User Id=postgres;Password=postgres
        var configuration = configurationBuilder.Build();
        string? connection = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseNpgsql(connection ?? "Host=postgres");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dish>()
            .HasMany(e => e.Ingredients)
            .WithMany(e => e.Dishes)
            .UsingEntity<DishIngredient>();
        modelBuilder.Entity<Order>()
            .HasMany(e => e.Dishes)
            .WithMany()
            .UsingEntity<DishOrder>();
    }
    
    public DbSet<DeliveryInfo> DeliveryInfo { get; set; }
    public DbSet<Ingredient> Ingredient { get; set; }
    public DbSet<DeliveryData> DeliveryData { get; set; }
    public DbSet<Dish> Dish { get; set; }
    public DbSet<Order> Order { get; set; }
}