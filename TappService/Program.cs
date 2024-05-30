using DAL;
using DAL.Interfaces.Repositories;
using DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Logging.AddConsole();

builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<ITaakRepository, TaakRepository>();
builder.Services.AddScoped<IContactpersoonRepository, ContactpersoonRepository>();

builder.Services.AddDbContext<EFTappContext>();

//var test = builder.Configuration.GetConnectionString("EFTapp");

var app = builder.Build();

app.UseCors(
    builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
    );

var logger = app.Services.GetRequiredService<ILogger<Program>>();

try
{
    // Your existing code...

    logger.LogInformation("Application started.");
}
catch (Exception ex)
{
    logger.LogError(ex, "An error occurred while starting the application.");
    throw;
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();  //Map alles controller routes
});

app.Run();