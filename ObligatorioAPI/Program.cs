using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Agregar configuraciones, como la cadena de conexión
builder.Configuration.AddJsonFile("appsettings.json");

// Configurar servicios, incluido el DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Configurar middleware y endpoints aquí

app.Run();
