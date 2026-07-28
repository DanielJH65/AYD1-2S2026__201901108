var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/", () => new
{
    message = "Api funcionando correctamente",
    version = app.Configuration["ApiSettings:Version"]
});

app.MapGet("/datos", () => new
{
    nombre = "Walter Daniel Jiménez Hernández",
    albúm = "4218"
});

app.Run();