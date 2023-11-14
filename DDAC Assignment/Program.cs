using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DDAC_Assignment.Data;
using DDAC_Assignment.Areas.Identity.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DDAC_AssignmentContextConnection") ?? throw new InvalidOperationException("Connection string 'DDAC_AssignmentContextConnection' not found.");

builder.Services.AddDbContext<DDAC_AssignmentContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<DDAC_AssignmentUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<DDAC_AssignmentContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
