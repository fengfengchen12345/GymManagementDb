using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GymManagementDb.Models;
using GymManagementDb.Areas.Identity.Data;
namespace GymManagementDb.Data
{
    public class GymManagementDbContext : IdentityDbContext<GymManagementDbUser>
    {
        public GymManagementDbContext(DbContextOptions<GymManagementDbContext> options)
            : base(options)
        {
        }
        public DbSet<MembershipType> MembershipType { get; set; }
        public DbSet<Trainers> Trainers { get; set; }
        public DbSet<TrainerSpecialty> TrainerSpecialty { get; set; }
        public DbSet<Workouts> Workouts { get; set; }
    }
}