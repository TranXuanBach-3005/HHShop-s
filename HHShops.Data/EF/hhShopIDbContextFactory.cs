using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HHShops.Data.EF
{
    public class hhShopIDbContextFactory : IDesignTimeDbContextFactory<hhShopDbContext>
    {
        public hhShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("hhShopDb");
            var optionsBuiler = new DbContextOptionsBuilder<hhShopDbContext>();
            optionsBuiler.UseSqlServer(connectionString);
            return new hhShopDbContext(optionsBuiler.Options);
        }
    }
}
