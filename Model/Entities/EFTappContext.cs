using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Models.Entities;
public class EFTappContext : DbContext
{
    public static IConfigurationRoot Configuration;
    public DbSet<Contactpersoon> Contactpersonen { get; set; }
    public DbSet<Adres> Adressen { get; set; }
    public DbSet<DatumUur> DatumUren { get; set; }
    public DbSet<Label> Labels { get; set; }
    public DbSet<Organisatie> Organisaties { get; set; }
    public DbSet<OrganisatieType> OrganisatieTypes { get; set; }
    public DbSet<Project> Projecten { get; set; }
    public DbSet<Status> Statussen { get; set; }
    public DbSet<Taak> Taken { get; set; }
    public DbSet<ToDo> ToDos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.FullName)
            .AddJsonFile("appsettings.json", false).Build();

        var connectionString = Configuration.GetConnectionString("EFTapp");

        if(connectionString != null)
        {
            optionsBuilder.UseSqlServer(connectionString, options => options.MaxBatchSize(150));
        }
    }


}
