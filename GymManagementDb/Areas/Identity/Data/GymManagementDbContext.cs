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
    }

    public DbSet<GymManagementDb.Models.Member> Member { get; set; } = default!;

public DbSet<GymManagementDb.Models.MembershipType> MembershipType { get; set; } = default!;

public DbSet<GymManagementDb.Models.Trainers> Trainers { get; set; } = default!;

public DbSet<GymManagementDb.Models.TrainerSpecialty> TrainerSpecialty { get; set; } = default!;

public DbSet<GymManagementDb.Models.Workouts> Workouts { get; set; } = default!;
}
