using Microsoft.EntityFrameworkCore;
using StudentLance.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<StudentLanceDataContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("StudentLanceDataContext")));

builder.Services.AddControllersWithViews();
builder.Services.AddDataProtection();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Users}/{action=Login}/{Id?}");

app.Run();
