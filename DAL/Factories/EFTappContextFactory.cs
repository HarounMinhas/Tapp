using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DAL;

namespace DAL.Factories;
public class EFTappContextFactory : IDesignTimeDbContextFactory<EFTappContext>
{
    public EFTappContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  // Ensure this path is correct in your environment
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

        var optionsBuilder = new DbContextOptionsBuilder<EFTappContext>();
        var connectionString = configuration.GetConnectionString("EFTapp");
        optionsBuilder.UseSqlServer(connectionString, options => options.MaxBatchSize(150));

        return new EFTappContext(optionsBuilder.Options);
    }
}
