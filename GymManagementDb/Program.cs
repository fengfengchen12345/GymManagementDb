using Microsoft.EntityFrameworkCore;
using GymManagementDb.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("GymManagementDbContextConnection") ?? throw new InvalidOperationException("Connection string 'GymManagementDbContextConnection' not found.");

builder.Services.AddDbContext<GymManagementDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<GymManagementDbUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<GymManagementDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var roles = new[] { "Admin", "User" };

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
            await roleManager.CreateAsync(new IdentityRole(role));

    }
}

using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<GymManagementDbUser>>();

    string adminEmail = "admin@gmail.com";
    string adminPassword = "Password123!";

    if (await userManager.FindByEmailAsync(adminEmail) == null)
    {
        var user = new GymManagementDbUser();
        user.UserName = adminEmail;
        user.Email = adminEmail;
        user.FirstName = "Test";
        user.LastName = "Admin";
        user.Phone = "1234567890";
        user.WorkoutID = 1;

        await userManager.CreateAsync(user, adminPassword);
        await userManager.AddToRoleAsync(user, "Admin");
    }
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
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();