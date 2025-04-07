using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GymManagementDb.Data;
using GymManagementDb.Areas.Identity.Data;
using GymManagementDb.Migrations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PeScheduleDB.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("GymManagementDbContextConnection") ?? throw new InvalidOperationException("Connection string 'GymManagementDbContextConnection' not found.");

builder.Services.AddDbContext<GymManagementDbContext>(options => options.UseSqlServer(connectionString));


builder.Services.AddDefaultIdentity<GymManagementDbUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<GymManagementDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
var GymManagementDbRoleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

if (!await GymManagementDbRoleManager.RoleExistsAsync("Manager"))
await GymManagementDbRoleManager.CreateAsync(new IdentityRole("Manager"));
}



    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
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
}
