var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/*var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSwaggerDoc(|"v1", new OpenApiInfo { Title = "Teste API Samuel", Description = "Testando tudo"})
});

var app = builder.Build();

if(app.Environment.IsDevelopment())*/

app.MapGet("/", () => "Hello World!");



app.Run();
