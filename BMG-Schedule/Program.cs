using BMG_Schedule.Data;
using BMG_Schedule.Shared;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using BMG_Schedule.Data.Models;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages()
                .AddNewtonsoftJson(cfg => cfg.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

builder.Services.AddServerSideBlazor();
builder.Services.AddDbContextFactory<EmployeeManagerDbContext>(
    options => options.UseSqlServer(
builder.Configuration.GetConnectionString("BMGEmployeeManagerDb")));

builder.Services.AddDefaultIdentity<IdentityUser<int>>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<EmployeeManagerDbContext>();

builder.Services.AddScoped<StateContainer>();

var app = builder.Build();

//To be used only for development, NOT in production!
await EnsureDatabaseIsMigrated(app.Services);

async Task EnsureDatabaseIsMigrated(IServiceProvider services)
{
    using var scope = services.CreateScope();
    using var context = scope.ServiceProvider.GetService<EmployeeManagerDbContext>();

    if (context is not null)
    {
        await context.Database.MigrateAsync();
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.UseAuthentication();;

app.Run();
