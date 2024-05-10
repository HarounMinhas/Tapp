
using Model.Entities;
using Model.Interfaces.Repositories;
using Model.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Logging.AddConsole();

builder.Services.AddScoped<IProjectRepository,ProjectRepository>();

builder.Services.AddDbContext<EFTappContext>();


var app = builder.Build();

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

app.UseEndpoints(endpoints => {  
    endpoints.MapControllers();  //Map alles controller routes
});


app.Run();