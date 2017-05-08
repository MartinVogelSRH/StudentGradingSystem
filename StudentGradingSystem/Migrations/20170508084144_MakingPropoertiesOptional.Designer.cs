using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using StudentGradingSystem.Data;

namespace StudentGradingSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170508084144_MakingPropoertiesOptional")]
    partial class MakingPropoertiesOptional
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasDefaultSchema("StudentGradingSystem")
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AspNetRoleId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRole","Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AspNetRoleClaimId");

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId")
                        .HasColumnName("AspNetRoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaim","Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AspNetUserClaimId");

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId")
                        .HasColumnName("AspNetUserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaim","Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId")
                        .HasColumnName("AspNetUserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogin","Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnName("AspNetUserId");

                    b.Property<int>("RoleId")
                        .HasColumnName("AspNetRoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRole","Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnName("AspNetUserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserToken","Security");
                });

            modelBuilder.Entity("StudentGradingSystem.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AspNetUserId");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUser","Security");
                });

            modelBuilder.Entity("StudentGradingSystem.Models.GroupModule", b =>
                {
                    b.Property<int>("GroupModuleID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GroupName");

                    b.Property<int?>("ModuleDetailsID");

                    b.HasKey("GroupModuleID");

                    b.HasIndex("ModuleDetailsID");

                    b.ToTable("GroupModule");
                });

            modelBuilder.Entity("StudentGradingSystem.Models.Module", b =>
                {
                    b.Property<int>("ModuleID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("TemplateQuestionnaireIDQuestionnaireID");

                    b.HasKey("ModuleID");

                    b.HasIndex("TemplateQuestionnaireIDQuestionnaireID");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("StudentGradingSystem.Models.ModuleDetails", b =>
                {
                    b.Property<int>("ModuleDetailsID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseNumber");

                    b.Property<DateTime>("EndTime");

                    b.Property<int?>("ModuleID1");

                    b.Property<int?>("QuestionnaireID1");

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("UserNameProfessor");

                    b.HasKey("ModuleDetailsID");

                    b.HasIndex("ModuleID1");

                    b.HasIndex("QuestionnaireID1");

                    b.ToTable("ModuleDetails");
                });

            modelBuilder.Entity("StudentGradingSystem.Models.Questionnaire", b =>
                {
                    b.Property<int>("QuestionnaireID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("QuestionnaireID");

                    b.ToTable("Questionnaire");
                });

            modelBuilder.Entity("StudentGradingSystem.Models.QuestionnaireAnswers", b =>
                {
                    b.Property<int>("QuestionnaireAnswersID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnswerID");

                    b.Property<int?>("QuestionnaireQuestionsID");

                    b.Property<double>("Score");

                    b.HasKey("QuestionnaireAnswersID");

                    b.HasIndex("QuestionnaireQuestionsID");

                    b.ToTable("QuestionnaireAnswers");
                });

            modelBuilder.Entity("StudentGradingSystem.Models.QuestionnaireCategories", b =>
                {
                    b.Property<int>("QuestionnaireCategoriesID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<string>("CategoryName");

                    b.Property<int?>("QuestionnaireID1");

                    b.Property<double>("Weighting");

                    b.HasKey("QuestionnaireCategoriesID");

                    b.HasIndex("QuestionnaireID1");

                    b.ToTable("QuestionnaireCategories");
                });

            modelBuilder.Entity("StudentGradingSystem.Models.QuestionnaireQuestions", b =>
                {
                    b.Property<int>("QuestionnaireQuestionsID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BadReference");

                    b.Property<string>("Description");

                    b.Property<string>("GoodReference");

                    b.Property<int>("QuestionID");

                    b.Property<int?>("QuestionnaireCategoryQuestionnaireCategoriesID");

                    b.Property<double>("Weighting");

                    b.HasKey("QuestionnaireQuestionsID");

                    b.HasIndex("QuestionnaireCategoryQuestionnaireCategoriesID");

                    b.ToTable("QuestionnaireQuestions");
                });

            modelBuilder.Entity("StudentGradingSystem.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentCourseID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnswerID");

                    b.Property<int?>("CourseModuleDetailsID");

                    b.Property<double?>("Grade");

                    b.Property<int>("GroupGradeOK");

                    b.Property<int?>("GroupModuleID");

                    b.Property<double?>("ProfessorGuessGrade");

                    b.Property<double?>("SelfEvaluationGrade");

                    b.Property<int>("SelfEvaluationID");

                    b.Property<string>("UserNameStudent");

                    b.HasKey("StudentCourseID");

                    b.HasIndex("CourseModuleDetailsID");

                    b.HasIndex("GroupModuleID");

                    b.ToTable("StudentCourse");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole<int>")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("StudentGradingSystem.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("StudentGradingSystem.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole<int>")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentGradingSystem.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentGradingSystem.Models.GroupModule", b =>
                {
                    b.HasOne("StudentGradingSystem.Models.ModuleDetails", "ModuleDetail")
                        .WithMany("Group")
                        .HasForeignKey("ModuleDetailsID");
                });

            modelBuilder.Entity("StudentGradingSystem.Models.Module", b =>
                {
                    b.HasOne("StudentGradingSystem.Models.Questionnaire", "TemplateQuestionnaireID")
                        .WithMany("Module")
                        .HasForeignKey("TemplateQuestionnaireIDQuestionnaireID");
                });

            modelBuilder.Entity("StudentGradingSystem.Models.ModuleDetails", b =>
                {
                    b.HasOne("StudentGradingSystem.Models.Module", "ModuleID")
                        .WithMany("Courses")
                        .HasForeignKey("ModuleID1");

                    b.HasOne("StudentGradingSystem.Models.Questionnaire", "QuestionnaireID")
                        .WithMany("ModuleDetails")
                        .HasForeignKey("QuestionnaireID1");
                });

            modelBuilder.Entity("StudentGradingSystem.Models.QuestionnaireAnswers", b =>
                {
                    b.HasOne("StudentGradingSystem.Models.QuestionnaireQuestions", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionnaireQuestionsID");
                });

            modelBuilder.Entity("StudentGradingSystem.Models.QuestionnaireCategories", b =>
                {
                    b.HasOne("StudentGradingSystem.Models.Questionnaire", "QuestionnaireID")
                        .WithMany("QuestionnaireCategories")
                        .HasForeignKey("QuestionnaireID1");
                });

            modelBuilder.Entity("StudentGradingSystem.Models.QuestionnaireQuestions", b =>
                {
                    b.HasOne("StudentGradingSystem.Models.QuestionnaireCategories", "QuestionnaireCategory")
                        .WithMany("QuestionnaireQuestions")
                        .HasForeignKey("QuestionnaireCategoryQuestionnaireCategoriesID");
                });

            modelBuilder.Entity("StudentGradingSystem.Models.StudentCourse", b =>
                {
                    b.HasOne("StudentGradingSystem.Models.ModuleDetails", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseModuleDetailsID");

                    b.HasOne("StudentGradingSystem.Models.GroupModule", "Group")
                        .WithMany("StudentCourse")
                        .HasForeignKey("GroupModuleID");
                });
        }
    }
}
