using GymManagementDb.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GymManagementDb.Models;

namespace GymManagementDb.Data;

public class GymManagementDbContext : IdentityDbContext<GymManagementDbUser>
{
    public GymManagementDbContext(DbContextOptions<GymManagementDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<GymManagementDb.Models.Member> Member { get; set; } = default!;

public DbSet<GymManagementDb.Models.Bookings> Bookings { get; set; } = default!;

public DbSet<GymManagementDb.Models.MembershipType> MembershipType { get; set; } = default!;

public DbSet<GymManagementDb.Models.Trainers> Trainers { get; set; } = default!;

public DbSet<GymManagementDb.Models.TrainerSpecialty> TrainerSpecialty { get; set; } = default!;

public DbSet<GymManagementDb.Models.Workouts> Workouts { get; set; } = default!;
}
