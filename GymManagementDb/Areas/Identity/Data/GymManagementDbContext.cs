
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GymManagementDb.Models;
using static System.Net.Mime.MediaTypeNames;

namespace GymManagementDb.Data;

public class GymManagementDbContext : IdentityDbContext<GymManagementDbUser>
{
   public GymManagementDbContext(DbContextOptions<GymManagementDbContext> options)
        : base(options)
    {
    }
    private DbSet<MembershipType> membershipType = default!;
    public virtual DbSet<GymManagementDbUser> ApplicationUser { get; set; }
    public DbSet<GymManagementDb.Models.MembershipType> MembershipType { get; set; } = default!;
    public DbSet<GymManagementDb.Models.Trainers> Trainers { get; set; } = default!;
    public DbSet<GymManagementDb.Models.TrainerSpecialty> TrainerSpecialty { get; set; } = default!;
    public DbSet<GymManagementDb.Models.Workouts> Workouts { get; set; } = default!;

}