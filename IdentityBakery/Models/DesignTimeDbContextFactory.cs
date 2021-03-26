using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace IdentityBakery.Models
{
  public class IdentityBakeryContextFactory : IDesignTimeDbContextFactory<IdentityBakeryContext>
  {

    IdentityBakeryContext IDesignTimeDbContextFactory<IdentityBakeryContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<IdentityBakeryContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new IdentityBakeryContext(builder.Options);
    }
  }
}