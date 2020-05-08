﻿// <auto-generated />
using System;
using DigiMoallem.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DigiMoallem.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Accounting.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("PaymentDate");

                    b.Property<int>("TeacherId");

                    b.HasKey("PaymentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(750);

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsDelete");

                    b.Property<int?>("ParentId");

                    b.Property<bool>("ReadByAdmin");

                    b.Property<int>("UserId");

                    b.HasKey("CommentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("ParentId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.CommentQA", b =>
                {
                    b.Property<int>("CommentQAId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(750);

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsDelete");

                    b.Property<int?>("ParentId");

                    b.Property<bool>("ReadByAdmin");

                    b.Property<int>("UserId");

                    b.HasKey("CommentQAId");

                    b.HasIndex("CourseId");

                    b.HasIndex("ParentId");

                    b.HasIndex("UserId");

                    b.ToTable("CommentQAs");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseLevelId");

                    b.Property<int>("CourseStatusId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Demo")
                        .HasMaxLength(200);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool>("DisplayComment");

                    b.Property<int>("GroupId");

                    b.Property<string>("ImageName")
                        .HasMaxLength(200);

                    b.Property<bool>("IsCheckedByAdmin");

                    b.Property<bool?>("IsFavorite");

                    b.Property<bool>("IsHidden");

                    b.Property<bool>("Off");

                    b.Property<byte?>("OffPercent");

                    b.Property<int>("Price");

                    b.Property<int?>("PriceAfterOff");

                    b.Property<int?>("SubGroupId");

                    b.Property<string>("Tags")
                        .HasMaxLength(350);

                    b.Property<int>("TeacherId");

                    b.Property<int?>("TeacherPercent");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int?>("TotalIncome");

                    b.Property<int?>("TotalInstitutePayment");

                    b.Property<int?>("TotalPayment");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("CourseId");

                    b.HasIndex("CourseLevelId");

                    b.HasIndex("CourseStatusId");

                    b.HasIndex("GroupId");

                    b.HasIndex("SubGroupId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.CourseEpisode", b =>
                {
                    b.Property<int>("CourseEpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<string>("EpisodeFileName")
                        .HasMaxLength(350);

                    b.Property<TimeSpan>("EpisodeLength");

                    b.Property<bool>("IsCheckedByAdmin");

                    b.Property<bool>("IsFree");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(350);

                    b.HasKey("CourseEpisodeId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseEpisodes");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.CourseInCourseType", b =>
                {
                    b.Property<int>("CourseInCourseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<int>("CourseTypeId");

                    b.HasKey("CourseInCourseTypeId");

                    b.HasIndex("CourseId");

                    b.HasIndex("CourseTypeId");

                    b.ToTable("CourseInCoursetypes");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.CourseLevel", b =>
                {
                    b.Property<int>("CourseLevelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("CourseLevelId");

                    b.ToTable("CourseLevels");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.CourseStatus", b =>
                {
                    b.Property<int>("CourseStatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("CourseStatusId");

                    b.ToTable("CourseStatuses");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.CourseType", b =>
                {
                    b.Property<int>("CourseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("CourseTypeId");

                    b.ToTable("CourseTypes");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageName")
                        .HasMaxLength(200);

                    b.Property<bool>("IsDelete");

                    b.Property<int?>("ParentId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("GroupId");

                    b.HasIndex("ParentId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.LikeCourse", b =>
                {
                    b.Property<int>("LikeCourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<bool>("Like");

                    b.Property<int>("UserId");

                    b.HasKey("LikeCourseId");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("LikeCourses");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.RateCourse", b =>
                {
                    b.Property<int>("RateCourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<byte?>("Rate");

                    b.Property<int>("UserId");

                    b.HasKey("RateCourseId");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("RateCourses");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.UserCourse", b =>
                {
                    b.Property<int>("UserCourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<int>("UserId");

                    b.HasKey("UserCourseId");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("UserCourses");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.General.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("IsChecked");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("SubmitDate");

                    b.HasKey("ContactId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.General.Setting", b =>
                {
                    b.Property<int>("SettingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutUs")
                        .IsRequired()
                        .HasMaxLength(4500);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("ContributeDigiMoallem")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Files")
                        .IsRequired();

                    b.Property<string>("Footer")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("PolicySymbols")
                        .HasMaxLength(4500);

                    b.Property<string>("ProductionRules")
                        .IsRequired();

                    b.Property<string>("Rules")
                        .IsRequired();

                    b.HasKey("SettingId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.General.Standard", b =>
                {
                    b.Property<int>("StandardId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4500);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("StandardId");

                    b.ToTable("Standards");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.General.UploadLink", b =>
                {
                    b.Property<int>("UploadLinkId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileTitle")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("Url")
                        .HasMaxLength(200);

                    b.HasKey("UploadLinkId");

                    b.ToTable("UploadLinks");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.General.Work", b =>
                {
                    b.Property<int>("WorkId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarName");

                    b.Property<string>("CardNumber")
                        .HasMaxLength(200);

                    b.Property<string>("ContributionFields")
                        .HasMaxLength(1500);

                    b.Property<string>("CvTitle");

                    b.Property<string>("EducationalLevel")
                        .HasMaxLength(200);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Experiences")
                        .HasMaxLength(1500);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<bool>("Gender");

                    b.Property<bool>("IsChecked");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("Mobile")
                        .HasMaxLength(12);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(12);

                    b.Property<string>("Sheba")
                        .HasMaxLength(200);

                    b.Property<string>("Skills")
                        .HasMaxLength(1500);

                    b.Property<DateTime>("SubmitDate");

                    b.HasKey("WorkId");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Orders.Discount", b =>
                {
                    b.Property<int>("DiscountId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiscountCode")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int>("DiscountPercent");

                    b.Property<DateTime?>("EndDate");

                    b.Property<DateTime?>("StartDate");

                    b.Property<int?>("UsableCount");

                    b.HasKey("DiscountId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Orders.DiscountPerCourse", b =>
                {
                    b.Property<int>("DiscountPerCourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<string>("DiscountCode")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int>("DiscountPercent");

                    b.Property<DateTime?>("EndDate");

                    b.Property<DateTime?>("StartDate");

                    b.Property<int?>("UsableCount");

                    b.HasKey("DiscountPerCourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("DiscountPerCourses");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Orders.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsFinally");

                    b.Property<int>("TotalPrice");

                    b.Property<int>("UserId");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Orders.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<int>("CourseId");

                    b.Property<int>("OrderId");

                    b.Property<int>("Price");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("CourseId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Permissions.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ParentId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("PermissionId");

                    b.HasIndex("ParentId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Permissions.PermissionsInRole", b =>
                {
                    b.Property<int>("PermissionsInRoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PermissionId");

                    b.Property<int>("RoleId");

                    b.HasKey("PermissionsInRoleId");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("PermissionsInRole");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Transactions.Exchange", b =>
                {
                    b.Property<int>("ExchangeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<bool>("IsPay");

                    b.Property<DateTime>("TransactionDate");

                    b.Property<int>("TransactionTypeId");

                    b.Property<int>("UserId");

                    b.HasKey("ExchangeId");

                    b.HasIndex("TransactionTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Exchanges");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Transactions.TransactionType", b =>
                {
                    b.Property<int>("TransactionTypeId");

                    b.Property<string>("TypeTitle")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("TransactionTypeId");

                    b.ToTable("TransactionTypes");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Users.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Users.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivationCode")
                        .HasMaxLength(100);

                    b.Property<int?>("Balance");

                    b.Property<string>("CardNumber")
                        .HasMaxLength(200);

                    b.Property<string>("Description")
                        .HasMaxLength(1500);

                    b.Property<string>("EducationalLevel")
                        .HasMaxLength(200);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Experiences")
                        .HasMaxLength(1500);

                    b.Property<string>("FirstName")
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("LastName")
                        .HasMaxLength(200);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(12);

                    b.Property<DateTime>("RegisterDate");

                    b.Property<string>("ScientificField")
                        .HasMaxLength(200);

                    b.Property<string>("Sheba")
                        .HasMaxLength(200);

                    b.Property<string>("Skills")
                        .HasMaxLength(1500);

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("UserAvatar")
                        .HasMaxLength(100);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Users.UserDiscountCode", b =>
                {
                    b.Property<int>("UserDiscountCodeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscountId");

                    b.Property<int?>("DiscountPerCourseId");

                    b.Property<int>("UserId");

                    b.HasKey("UserDiscountCodeId");

                    b.HasIndex("DiscountId");

                    b.HasIndex("DiscountPerCourseId");

                    b.HasIndex("UserId");

                    b.ToTable("UserDiscountCodes");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Users.UserDiscountCodePerCourse", b =>
                {
                    b.Property<int>("UserDiscountCodePerCourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscountPerCourseId");

                    b.Property<int>("UserId");

                    b.HasKey("UserDiscountCodePerCourseId");

                    b.HasIndex("DiscountPerCourseId");

                    b.HasIndex("UserId");

                    b.ToTable("UserDiscountCodePerCourses");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Users.UserInRole", b =>
                {
                    b.Property<int>("UserInRoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.HasKey("UserInRoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserInRoles");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Accounting.Payment", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Courses.Course", "Course")
                        .WithMany("Payments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Users.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.Comment", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Courses.Course", "Course")
                        .WithMany("Comments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Courses.Comment")
                        .WithMany("Comments")
                        .HasForeignKey("ParentId");

                    b.HasOne("DigiMoallem.DAL.Entities.Users.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.CommentQA", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Courses.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Courses.CommentQA")
                        .WithMany("CommentQAs")
                        .HasForeignKey("ParentId");

                    b.HasOne("DigiMoallem.DAL.Entities.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.Course", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Courses.CourseLevel", "CourseLevel")
                        .WithMany("Courses")
                        .HasForeignKey("CourseLevelId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Courses.CourseStatus", "CourseStatus")
                        .WithMany("Courses")
                        .HasForeignKey("CourseStatusId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Courses.Group", "Group")
                        .WithMany("Courses")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Courses.Group", "SubGroup")
                        .WithMany("SubCourses")
                        .HasForeignKey("SubGroupId");

                    b.HasOne("DigiMoallem.DAL.Entities.Users.User", "User")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.CourseEpisode", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Courses.Course", "Course")
                        .WithMany("CourseEpisodes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.CourseInCourseType", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Courses.Course", "Course")
                        .WithMany("CourseInCourseTypes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Courses.CourseType", "CourseType")
                        .WithMany("CourseInCourseTypes")
                        .HasForeignKey("CourseTypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.Group", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Courses.Group")
                        .WithMany("Groups")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.LikeCourse", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Courses.Course", "Course")
                        .WithMany("LikeCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Users.User", "User")
                        .WithMany("LikeCourses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.RateCourse", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Courses.Course", "Course")
                        .WithMany("RateCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Users.User", "User")
                        .WithMany("RateCourses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Courses.UserCourse", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Courses.Course", "Course")
                        .WithMany("UserCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Users.User", "User")
                        .WithMany("UserCourses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Orders.DiscountPerCourse", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Courses.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Orders.Order", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Users.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Orders.OrderDetail", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Courses.Course", "Course")
                        .WithMany("OrderDetails")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Orders.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Permissions.Permission", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Permissions.Permission")
                        .WithMany("Permissions")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Permissions.PermissionsInRole", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Permissions.Permission", "Permission")
                        .WithMany("PermissionsInRoles")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Users.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Transactions.Exchange", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Transactions.TransactionType", "TransactionType")
                        .WithMany("Exchanges")
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Users.User", "User")
                        .WithMany("Exchanges")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Users.UserDiscountCode", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Orders.Discount", "Discount")
                        .WithMany("UserDiscountCodes")
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Orders.DiscountPerCourse")
                        .WithMany("UserDiscountCodes")
                        .HasForeignKey("DiscountPerCourseId");

                    b.HasOne("DigiMoallem.DAL.Entities.Users.User", "User")
                        .WithMany("UserDiscountCodes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Users.UserDiscountCodePerCourse", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Orders.DiscountPerCourse", "DiscountPerCourse")
                        .WithMany()
                        .HasForeignKey("DiscountPerCourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiMoallem.DAL.Entities.Users.UserInRole", b =>
                {
                    b.HasOne("DigiMoallem.DAL.Entities.Users.Role", "Role")
                        .WithMany("UserInRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiMoallem.DAL.Entities.Users.User", "User")
                        .WithMany("UserInRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
