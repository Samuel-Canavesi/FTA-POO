using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using SushiStore.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddDbContext<SushiDb>(FileOptions => FileOptions.UseInMemoryDatabase("items"));
builder.Services.AddDbContext<SushiDb>(options => options.UseInMemoryDatabase("items"));

builder.Services.AddSwaggerGen(c => 
{
    c.SwaggerDoc("v1", new OpenApiInfo{
        
        Title = "SushiStore API",
        Description = "Making a sushi and sashimi with cream cheese",
        Version = "v1"
    });
});

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI(c => 
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "SushiStore API V1");
});

app.MapGet("/", () => "Hello World!");

app.Mapget("/sushi", async (SushiDb db) => await db.Sushis.ToListAsync());

app.Run();
