using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentGradingSystem.Models;

namespace StudentGradingSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            
        {            
        }
        public DbSet<GroupModule> GroupModule { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<ModuleDetails> ModuleDetails { get; set; }
        public DbSet<Questionnaire> Questionnaire { get; set; }
        public DbSet<QuestionnaireAnswers> QuestionnaireAnswers { get; set; }
        public DbSet<QuestionnaireCategories> QuestionnaireCategories { get; set; }
        public DbSet<QuestionnaireQuestions> QuestionnaireQuestions { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.HasDefaultSchema("StudentGradingSystem");
            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "AspNetUser", schema: "Security");
                entity.Property(e => e.Id).HasColumnName("AspNetUserId");

            });
            builder.Entity<IdentityRole<int>>(entity =>
            {
                entity.ToTable(name: "AspNetRole", schema: "Security");
                entity.Property(e => e.Id).HasColumnName("AspNetRoleId");

            });

            builder.Entity<IdentityUserClaim<int>>(entity =>
            {
                entity.ToTable("AspNetUserClaim", "Security");
                entity.Property(e => e.UserId).HasColumnName("AspNetUserId");
                entity.Property(e => e.Id).HasColumnName("AspNetUserClaimId");

            });

            builder.Entity<IdentityUserLogin<int>>(entity =>
            {
                entity.ToTable("AspNetUserLogin", "Security");
                entity.Property(e => e.UserId).HasColumnName("AspNetUserId");

            });

            builder.Entity<IdentityRoleClaim<int>>(entity =>
            {
                entity.ToTable("AspNetRoleClaim", "Security");
                entity.Property(e => e.Id).HasColumnName("AspNetRoleClaimId");
                entity.Property(e => e.RoleId).HasColumnName("AspNetRoleId");
            });

            builder.Entity<IdentityUserRole<int>>(entity =>
            {
                entity.ToTable("AspNetUserRole", "Security");
                entity.Property(e => e.UserId).HasColumnName("AspNetUserId");
                entity.Property(e => e.RoleId).HasColumnName("AspNetRoleId");

            });


            builder.Entity<IdentityUserToken<int>>(entity =>
            {
                entity.ToTable("AspNetUserToken", "Security");
                entity.Property(e => e.UserId).HasColumnName("AspNetUserId");

            });
            //builder.Entity<GroupModule>()
            //    .HasKey(c => new { c.ModuleDetail, c.GroupID });
            //builder.Entity<Module>()
            //    .HasKey(c => new { c.ModuleID });
            //builder.Entity<ModuleDetails>()
            //    .HasKey(c => new { c.ModuleID, c.CourseNumber });
            //builder.Entity<Questionnaire>()
            //    .HasKey(c => new { c.QuestionnaireID });
            //builder.Entity<QuestionnaireAnswers>()
            //    .HasKey(c => new { c.Question, c.AnswerID });
            //builder.Entity<QuestionnaireCategories>()
            //    .HasKey(c => new { c.QuestionnaireID, c.CategoryID });
            //builder.Entity<QuestionnaireQuestions>()
            //    .HasKey(c => new { c.QuestionnaireCategory, c.QuestionID });
            //builder.Entity<StudentCourse>()
            //    .HasKey(c => new { c.Course, c.UserNameStudent });
        }
    }
}
