using GymManagementDb.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GymManagementDb.Models;
using GymManagementDb.Areas.Identity.Data;

namespace GymManagementDb.Data;

public class GymManagementDbContext : IdentityDbContext<IdentityUser>
{
    private DbSet<MembershipType> membershipType = default!;

    public GymManagementDbContext(DbContextOptions<GymManagementDbContext> options)
        : base(options)
    {
    }
    public DbSet<GymManagementDb.Models.MembershipType> MembershipType { get ; set; } = default!;
    public DbSet<GymManagementDb.Models.Trainers> Trainers { get; set; } = default!;
    public DbSet<GymManagementDb.Models.TrainerSpecialty> TrainerSpecialty { get; set; } = default!;
    public DbSet<GymManagementDb.Models.Workouts> Workouts { get; set; } = default!;

    }
