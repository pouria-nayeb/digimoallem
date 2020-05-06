using DigiMoallem.DAL.Entities.Accounting;
using DigiMoallem.DAL.Entities.Courses;
using DigiMoallem.DAL.Entities.General;
using DigiMoallem.DAL.Entities.Orders;
using DigiMoallem.DAL.Entities.Permissions;
using DigiMoallem.DAL.Entities.Transactions;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DigiMoallem.DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        #region Payments
        public DbSet<Payment> Payments { get; set; }
        #endregion

        #region Users - Roles - UserInRoles
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }
        public DbSet<UserDiscountCode> UserDiscountCodes { get; set; }
        public DbSet<UserDiscountCodePerCourse> UserDiscountCodePerCourses { get; set; }
        #endregion

        #region Permissions - PermissionsInRole
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionsInRole> PermissionsInRole { get; set; }
        #endregion

        #region General
        public DbSet<Contact> Messages { get; set; }

        public DbSet<Work> Works { get; set; }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<Standard> Standards { get; set; }
        #endregion

        #region Comments - CommentQAs - Courses - Episodes - Levels - Statuses - Types - Groups - Like - Rate - UserCourse
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentQA> CommentQAs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseEpisode> CourseEpisodes { get; set; }
        public DbSet<CourseLevel> CourseLevels { get; set; }
        public DbSet<CourseStatus> CourseStatuses { get; set; }
        public DbSet<CourseType> CourseTypes { get; set; }
        public DbSet<CourseInCourseType> CourseInCoursetypes { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<LikeCourse> LikeCourses { get; set; }
        public DbSet<RateCourse> RateCourses { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }
        #endregion

        #region Orders - OrderDetails - Discounts
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<DiscountPerCourse> DiscountPerCourses { get; set; }
        #endregion

        #region Transactions - TransactionTypes
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        #endregion

        #region QueryFilter
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }

            // display just users who is not deleted
            modelBuilder.Entity<User>()
                .HasQueryFilter(u => !u.IsDelete);

            // display just roles that is not deleted
            modelBuilder.Entity<Role>()
                .HasQueryFilter(r => !r.IsDelete);

            // display just groups that is not deleted
            modelBuilder.Entity<Group>()
               .HasQueryFilter(g => !g.IsDelete);

            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
