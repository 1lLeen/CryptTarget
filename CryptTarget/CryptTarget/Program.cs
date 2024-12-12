using CryptTarget.Models.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("DefaultConnection"); 
builder.Services.AddRazorPages();
builder.Configuration
.AddJsonFile($"appsettings.json", optional: false)
.AddJsonFile($"appsettings.Environment.json", optional: true)
.AddEnvironmentVariables()
.Build();

builder.Services.AddDbContext<CryptContext>(options => options.UseSqlServer(connString));
builder.Services.AddControllers();

var app = builder.Build();
 
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error"); 
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
