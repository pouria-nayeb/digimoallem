using DigiMoallem.DAL.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace DigiMoallem.DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        #region Users - Roles - UserInRoles
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }
        #endregion
    }
}
