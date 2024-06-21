using Kolokwium.Data;
using Kolokwium.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<DatabaseContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddScoped<IDbService, DbService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

// dotnet tool install --global dotnet-ef
// dotnet ef migrations add Init 
// dotnet ef database update

//FrameworkCore 8.0.6
//FrameworkCore.Des  8.0.6
//FrameworkCore.SqlServer  8.0.6