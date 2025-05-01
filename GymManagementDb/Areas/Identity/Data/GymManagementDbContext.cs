using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GymManagementDb.Models;
using System.Reflection.Emit;

namespace GymManagementDb.Areas.Identity.Data;

public class GymManagementDbContext : IdentityDbContext<GymManagementDbUser>
{
   public GymManagementDbContext(DbContextOptions<GymManagementDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<MembershipType>().ToTable("MembershipType");
        builder.Entity<Trainers>().ToTable("Trainers");
        builder.Entity<TrainerSpecialty>().ToTable("TrainerSpecialty");
        builder.Entity<Workouts>().ToTable("Workouts");
    }
    private DbSet<MembershipType> membershipType = default!;
    public DbSet<GymManagementDb.Areas.Identity.Data.GymManagementDbUser> GymManagementDbUser { get; set; } = default!;
    public DbSet<GymManagementDb.Models.MembershipType> MembershipType { get; set; } = default!;
    public DbSet<GymManagementDb.Models.Trainers> Trainers { get; set; } = default!;
    public DbSet<GymManagementDb.Models.TrainerSpecialty> TrainerSpecialty { get; set; } = default!;
    public DbSet<GymManagementDb.Models.Workouts> Workouts { get; set; } = default!;

}