using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GymManagementDb.Data;
using GymManagementDb.Areas.Identity.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("GymManagementDbContextConnection")
                        ?? throw new InvalidOperationException("Connection string 'GymManagementDbContextConnection' not found.");

builder.Services.AddDbContext<GymManagementDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<GymManagementDbUser>(options =>
   options.SignIn.RequireConfirmedAccount = true)
   .AddEntityFrameworkStores<GymManagementDbContext>();


builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();