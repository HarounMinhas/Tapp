using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tapp.Configuration;
using Model.Entities;
namespace DAL;

public class EFTappContext : DbContext
{
    public static IConfiguration Configuration;
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

    public EFTappContext(DbContextOptions<EFTappContext> options) : base(options) { }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //BELANGRIJK, EFTappContextFactory geimplementeerd voor gebruik van EF CORE TOOLS

        var namespaceName = Assembly.GetExecutingAssembly().GetName().Name;
        //hier kan ook statisch geopteerd worden voor "DAL", maar maakt het wat onafhankelijker van elkaar
        Configuration = ConfigurationHelper.BuildConfigurationAppSettings(namespaceName);


        var connectionString = Configuration.GetConnectionString("EFTapp");

        if (connectionString != null)
        {
            optionsBuilder.UseSqlServer(connectionString, options => options.MaxBatchSize(150));
        }
    }

    public void ConfigureServices(IServiceCollection services)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory()) // or another consistent directory
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        var connectionString = configuration.GetConnectionString("EFTapp");
        services.AddDbContext<EFTappContext>(options =>
            options.UseSqlServer(connectionString, sqlOptions => sqlOptions.MaxBatchSize(150)));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Instellen actie bij verwijderen
        modelBuilder.Entity<Taak>()
       .HasOne<Project>(t => t.Project)
       .WithMany(p => p.Taken)
       .HasForeignKey(t => t.ProjectId)
       .OnDelete(DeleteBehavior.SetNull);

        // Verwijder alle todo's als een taak wordt verwijderd
        modelBuilder.Entity<Taak>()
            .HasMany(t => t.ToDos)
            .WithOne(td => td.Taak)
            .HasForeignKey(td => td.TaakId)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuratie voor Taken en hun Labels
        modelBuilder.Entity<Taak>()
            .HasOne(t => t.Label)  // Navigatie eigenschap in Taak klasse
            .WithMany(l => l.Taken)  // Navigatie collectie in Label klasse
            .HasForeignKey(t => t.LabelId)  // Foreign key eigenschap in Taak klasse
            .OnDelete(DeleteBehavior.Restrict);  // Stel de LabelId in op null als het Label wordt verwijderd

        // Zorg ervoor dat andere relaties verstandig zijn ingesteld om cycli te vermijden
        // Bijvoorbeeld, voor Taken en Status:
        modelBuilder.Entity<Taak>()
            .HasOne(t => t.Status)
            .WithMany(s => s.Taken)
            .HasForeignKey(t => t.StatusId)
            .OnDelete(DeleteBehavior.ClientSetNull);  // Voorkom dat cascade delete de logica breekt

        modelBuilder.Entity<ToDo>()
            .HasOne<Taak>(td => td.Taak)
            .WithMany(t => t.ToDos)
            .HasForeignKey(td => td.TaakId)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Contactpersoon>()
            .HasOne<Organisatie>(cp => cp.Organisatie)
            .WithOne(o => o.Contactpersoon)
            .HasForeignKey<Contactpersoon>(cp => cp.OrganisatieId)
            .OnDelete(DeleteBehavior.Restrict);
        // Verwijder alle taken als een project wordt verwijderd
        modelBuilder.Entity<Project>()
            .HasMany(p => p.Taken)
            .WithOne(t => t.Project)
            .HasForeignKey(t => t.ProjectId)
            .OnDelete(DeleteBehavior.Cascade);

        // Als een todo wordt verwijderd, blijft de taak bestaan
        modelBuilder.Entity<ToDo>()
            .HasOne(td => td.Taak)
            .WithMany(t => t.ToDos)
            .HasForeignKey(td => td.TaakId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        // Configuratie voor ToDo's en hun Labels
        modelBuilder.Entity<ToDo>()
            .HasOne(td => td.Label)  // Navigatie eigenschap in ToDo klasse
            .WithMany(l => l.ToDos)  // Navigatie collectie in Label klasse
            .HasForeignKey(td => td.LabelId)  // Foreign key eigenschap in ToDo klasse
            .OnDelete(DeleteBehavior.NoAction);  // Stel de LabelId in op null als het Label wordt verwijderd

        // Bij het verwijderen van een adres, contactpersoon, datumuur, label, organisatietype, of status
        // behoud de verwijzende rij maar zet de foreign key op null
        //niet geimplementeerd

        // Seeding van OrganisatieTypes
        modelBuilder.Entity<OrganisatieType>().HasData(
            new { OrganisatieTypeId = 1, Naam = "BVBA" },
            new { OrganisatieTypeId = 2, Naam = "NV" },
            new { OrganisatieTypeId = 3, Naam = "Freelancer" },
            new { OrganisatieTypeId = 4, Naam = "VZW" },
            new { OrganisatieTypeId = 5, Naam = "Unief" }
        );

        // Seeding van Adressen
        modelBuilder.Entity<Adres>().HasData(
            new { AdresId = 1, Straatnaam = "Tech Park", Straatnummer = "21A", Postcode = "9000", Gemeente = "Gent", Provincie = "Oost-Vlaanderen", Land = "België" },
            new { AdresId = 2, Straatnaam = "Greenway", Straatnummer = "42B", Postcode = "3001", Gemeente = "Leuven", Provincie = "Vlaams-Brabant", Land = "België" },
            new { AdresId = 3, Straatnaam = "Ocean Drive", Straatnummer = "88C", Postcode = "8400", Gemeente = "Oostende", Provincie = "West-Vlaanderen", Land = "België" },
            new { AdresId = 4, Straatnaam = "Quantum Leap", Straatnummer = "101D", Postcode = "2000", Gemeente = "Antwerpen", Provincie = "Antwerpen", Land = "België" },
            new { AdresId = 5, Straatnaam = "Orbit Road", Straatnummer = "360E", Postcode = "3500", Gemeente = "Hasselt", Provincie = "Limburg", Land = "België" }
        );

        // Seeding van Organisaties met OrganisatieTypes
        modelBuilder.Entity<Organisatie>().HasData(
            new { OrganisatieId = 1, Naam = "NovaTech Solutions", BTWNummer = "BE100200300", Rekeningnummer = "BE68 1234 5678 9012", AdresId = 1, OrganisatieTypeId = 1 },
            new { OrganisatieId = 2, Naam = "EcoSynthetix Inc.", BTWNummer = "BE400500600", Rekeningnummer = "BE68 2345 6789 0123", AdresId = 2, OrganisatieTypeId = 2 },
            new { OrganisatieId = 3, Naam = "Hydra Renewables", BTWNummer = "BE700800900", Rekeningnummer = "BE68 3456 7890 1234", AdresId = 3, OrganisatieTypeId = 3 },
            new { OrganisatieId = 4, Naam = "Quantum Intelligence", BTWNummer = "BE101112131", Rekeningnummer = "BE68 4567 8901 2345", AdresId = 4, OrganisatieTypeId = 4 },
            new { OrganisatieId = 5, Naam = "Orbit Innovations", BTWNummer = "BE141516171", Rekeningnummer = "BE68 5678 9012 3456", AdresId = 5, OrganisatieTypeId = 5 }
        );

        // Seeding van Contactpersonen
        modelBuilder.Entity<Contactpersoon>().HasData(
            new { ContactpersoonId = 1, Voornaam = "Jan", Familienaam = "De Vries", Email = "jan.devries@novatechsolutions.com", TelefoonNummer = "092342567", GSMNummer = "0479123456", OrganisatieId = 1 },
            new { ContactpersoonId = 2, Voornaam = "Sara", Familienaam = "Peeters", Email = "sara.peeters@ecosynthetixinc.com", GSMNummer = "0478123456", OrganisatieId = 2 },
            new { ContactpersoonId = 3, Voornaam = "Lucas", Familienaam = "Maes", Email = "lucas.maes@hydrarenewables.com", GSMNummer = "0477223456", OrganisatieId = 3 },
            new { ContactpersoonId = 4, Voornaam = "Emma", Familienaam = "Jacobs", Email = "emma.jacobs@quantumintelligence.com", GSMNummer = "0476323456", OrganisatieId = 4 },
            new { ContactpersoonId = 5, Voornaam = "Tom", Familienaam = "Janssens", Email = "tom.janssens@orbitinnovations.com", GSMNummer = "0475423456", OrganisatieId = 5 }
        );

        // Seeding van DatumUren
        modelBuilder.Entity<DatumUur>().HasData(
            new { DatumUurId = 1, BeginDatumUur = DateTime.Now },
            new { DatumUurId = 2, BeginDatumUur = DateTime.Now.AddDays(-1), EindDatumUur = DateTime.Now.AddDays(1) },
            new { DatumUurId = 3, BeginDatumUur = DateTime.Now.AddHours(-2) },
            new { DatumUurId = 4, BeginDatumUur = DateTime.Now.AddMonths(-1), EindDatumUur = DateTime.Now.AddMonths(1) },
            new { DatumUurId = 5, BeginDatumUur = DateTime.Now.AddDays(-10), EindDatumUur = DateTime.Now },
            new { DatumUurId = 6, BeginDatumUur = DateTime.Now.AddDays(2) },
            new { DatumUurId = 7, BeginDatumUur = DateTime.Now.AddMonths(-2), EindDatumUur = DateTime.Now.AddMonths(-1) }
        );

        // Seeding van Projectens
        modelBuilder.Entity<Project>().HasData(
            new { ProjectId = 1, OrganisatieId = 1, StatusId = 1, Naam = "Software Development", Beschrijving = "Developing a new piece of software", DatumUurId = 1 },
            new { ProjectId = 2, OrganisatieId = 2, StatusId = 1, Naam = "Renewable Resources", Beschrijving = "Exploring renewable resources", DatumUurId = 2 },
            new { ProjectId = 3, OrganisatieId = 3, StatusId = 1, Naam = "Market Analysis", Beschrijving = "Analyzing current market trends", DatumUurId = 3 },
            new { ProjectId = 4, OrganisatieId = 4, StatusId = 1, Naam = "AI Development", Beschrijving = "Working on AI technologies", DatumUurId = 4 },
            new { ProjectId = 5, OrganisatieId = 5, StatusId = 3, Naam = "Educational Program", Beschrijving = "Developing new educational programs", DatumUurId = 5 }
        );

        // Seeding van Taken
        modelBuilder.Entity<Taak>().HasData(
            new { TaakId = 1, ProjectId = 1, StatusId = 1, Titel = "UI Design", Beschrijving = "Designing user interfaces", DatumUurId = 6, LabelId = 2 },
            new { TaakId = 2, ProjectId = 1, StatusId = 1, Titel = "Backend Development", Beschrijving = "Creating backend services", DatumUurId = 7, LabelId = 1 },
            new { TaakId = 3, ProjectId = 2, StatusId = 1, Titel = "Resource Planning", Beschrijving = "Planning resource allocation", DatumUurId = 1, LabelId = 1 },
            new { TaakId = 4, ProjectId = 3, StatusId = 1, Titel = "Data Collection", Beschrijving = "Collecting market data", DatumUurId = 2, LabelId = 2 },
            new { TaakId = 5, ProjectId = 4, StatusId = 3, Titel = "Algorithm Optimization", Beschrijving = "Optimizing existing algorithms", DatumUurId = 3, LabelId = 4 },
            new { TaakId = 6, ProjectId = 2, StatusId = 3, Titel = "Legal Review", Beschrijving = "Reviewing environmental regulations", DatumUurId = 4, LabelId = 3 },
            new { TaakId = 7, ProjectId = 2, StatusId = 3, Titel = "Public Outreach", Beschrijving = "Developing community outreach programs", DatumUurId = 5, LabelId = 3 },
            new { TaakId = 8, ProjectId = 3, StatusId = 2, Titel = "Market Forecasting", Beschrijving = "Forecasting future market trends", DatumUurId = 6, LabelId = 2 },
            new { TaakId = 9, ProjectId = 4, StatusId = 2, Titel = "Neural Network Training", Beschrijving = "Training neural networks for better performance", DatumUurId = 7, LabelId = 5 },
            new { TaakId = 10, ProjectId = 5, StatusId = 1, Titel = "Curriculum Development", Beschrijving = "Developing new curriculum for upcoming courses", DatumUurId = 1, LabelId = 4 }
        );

        // Seeding van ToDo's
        modelBuilder.Entity<ToDo>().HasData(
            new { ToDoId = 1, TaakId = 1, StatusId = 1, Titel = "Sketch Initial Designs", Beschrijving = "Sketching the initial designs for the UI", DatumUurId = 4, LabelId = 1 },
            new { ToDoId = 2, TaakId = 2, StatusId = 1, Titel = "Setup Server", Beschrijving = "Setting up the server environment", DatumUurId = 5, LabelId = 1 },
            new { ToDoId = 3, TaakId = 3, StatusId = 1, Titel = "Draft Resource Report", Beschrijving = "Drafting a report on resources", DatumUurId = 6, LabelId = 2 },
            new { ToDoId = 4, TaakId = 4, StatusId = 1, Titel = "Analyze Collected Data", Beschrijving = "Analyzing the collected data", DatumUurId = 7, LabelId = 3 },
            new { ToDoId = 5, TaakId = 5, StatusId = 3, Titel = "Review Algorithms", Beschrijving = "Reviewing the algorithms for optimization", DatumUurId = 1, LabelId = 5 },
            new { ToDoId = 6, TaakId = 6, StatusId = 3, Titel = "Consult Legal Advisors", Beschrijving = "Consulting with legal advisors regarding compliance", DatumUurId = 2, LabelId = 4 },
            new { ToDoId = 7, TaakId = 7, StatusId = 3, Titel = "Prepare Outreach Materials", Beschrijving = "Preparing materials for public outreach", DatumUurId = 3, LabelId = 3 },
            new { ToDoId = 8, TaakId = 8, StatusId = 2, Titel = "Compile Data Reports", Beschrijving = "Compiling reports from collected market data", DatumUurId = 4, LabelId = 5 },
            new { ToDoId = 9, TaakId = 9, StatusId = 2, Titel = "Optimize Network Parameters", Beschrijving = "Optimizing parameters for better accuracy", DatumUurId = 5, LabelId = 5 },
            new { ToDoId = 10, TaakId = 10, StatusId = 2, Titel = "Validate Curriculum", Beschrijving = "Validating the developed curriculum with stakeholders", DatumUurId = 6, LabelId = 4 }
        );

        // Seeding van Labels
        modelBuilder.Entity<Label>().HasData(
            new { LabelId = 1, Titel = "Urgent", Beschrijving = "Tasks that need immediate attention" },
            new { LabelId = 2, Titel = "High Priority", Beschrijving = "Tasks that are of high priority but not urgent" },
            new { LabelId = 3, Titel = "Medium Priority", Beschrijving = "Tasks with a medium level of importance" },
            new { LabelId = 4, Titel = "Low Priority", Beschrijving = "Tasks that can be deferred" },
            new { LabelId = 5, Titel = "Optional", Beschrijving = "Tasks that are optional and can be skipped if needed" }
        );
        // Seeding van Status
        modelBuilder.Entity<Status>().HasData(
            new { StatusId = 1, Titel = "Actief", Beschrijving = "Project is momenteel actief" },
            new { StatusId = 2, Titel = "Niet actief", Beschrijving = "Project is niet langer actief" },
            new { StatusId = 3, Titel = "In revisie", Beschrijving = "Project is in revisie voor verbeteringen" }
        );
    }
}