using Buturlinskoe.EF;
using Buturlinskoe.EF.Repositories;
using Buturlinskoe.EF.Repositories.Abstract;
using Buturlinskoe.EF.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<UserService>();


var connectionStringEF = builder.Configuration.GetConnectionString("NpgsqlConnectionString");

builder.Services.AddDbContext<PostgreeContext>(
    options => options.UseNpgsql(connectionStringEF));

builder.Services.AddScoped<IUserRepository, UserEFPostgreeRepository>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
