using Microsoft.EntityFrameworkCore;

namespace IdentityBakery.Models
{
  public class IdentityBakeryContext : DbContext
  {
    public virtual DbSet<Flavor> Flavors {get; set;}
    public DbSet<Treat> Treats {get; set;}
    public DbSet<TreatFlavor> TreatFlavor {get; set;}

    public IdentityBakeryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}