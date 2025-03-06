using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GymManagementDb.Data;
using GymManagementDb.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("GymManagementDbContextConnection") ?? throw new InvalidOperationException("Connection string 'GymManagementDbContextConnection' not found.");

builder.Services.AddDbContext<GymManagementDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<GymManagementDbUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<GymManagementDbContext>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
