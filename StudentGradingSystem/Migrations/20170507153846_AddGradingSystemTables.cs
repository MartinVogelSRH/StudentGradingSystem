using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudentGradingSystem.Migrations
{
    public partial class AddGradingSystemTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "StudentGradingSystem");

            migrationBuilder.CreateTable(
                name: "Questionnaire",
                schema: "StudentGradingSystem",
                columns: table => new
                {
                    QuestionnaireID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaire", x => x.QuestionnaireID);
                });

            migrationBuilder.CreateTable(
                name: "Module",
                schema: "StudentGradingSystem",
                columns: table => new
                {
                    ModuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    TemplateQuestionnaireIDQuestionnaireID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.ModuleID);
                    table.ForeignKey(
                        name: "FK_Module_Questionnaire_TemplateQuestionnaireIDQuestionnaireID",
                        column: x => x.TemplateQuestionnaireIDQuestionnaireID,
                        principalSchema: "StudentGradingSystem",
                        principalTable: "Questionnaire",
                        principalColumn: "QuestionnaireID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionnaireCategories",
                schema: "StudentGradingSystem",
                columns: table => new
                {
                    QuestionnaireCategoriesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryID = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true),
                    QuestionnaireID1 = table.Column<int>(nullable: true),
                    Weighting = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionnaireCategories", x => x.QuestionnaireCategoriesID);
                    table.ForeignKey(
                        name: "FK_QuestionnaireCategories_Questionnaire_QuestionnaireID1",
                        column: x => x.QuestionnaireID1,
                        principalSchema: "StudentGradingSystem",
                        principalTable: "Questionnaire",
                        principalColumn: "QuestionnaireID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModuleDetails",
                schema: "StudentGradingSystem",
                columns: table => new
                {
                    ModuleDetailsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseNumber = table.Column<int>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    ModuleID1 = table.Column<int>(nullable: true),
                    QuestionnaireID1 = table.Column<int>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    UserNameProfessor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleDetails", x => x.ModuleDetailsID);
                    table.ForeignKey(
                        name: "FK_ModuleDetails_Module_ModuleID1",
                        column: x => x.ModuleID1,
                        principalSchema: "StudentGradingSystem",
                        principalTable: "Module",
                        principalColumn: "ModuleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ModuleDetails_Questionnaire_QuestionnaireID1",
                        column: x => x.QuestionnaireID1,
                        principalSchema: "StudentGradingSystem",
                        principalTable: "Questionnaire",
                        principalColumn: "QuestionnaireID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionnaireQuestions",
                schema: "StudentGradingSystem",
                columns: table => new
                {
                    QuestionnaireQuestionsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BadReference = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GoodReference = table.Column<string>(nullable: true),
                    QuestionID = table.Column<int>(nullable: false),
                    QuestionnaireCategoryQuestionnaireCategoriesID = table.Column<int>(nullable: true),
                    Weighting = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionnaireQuestions", x => x.QuestionnaireQuestionsID);
                    table.ForeignKey(
                        name: "FK_QuestionnaireQuestions_QuestionnaireCategories_QuestionnaireCategoryQuestionnaireCategoriesID",
                        column: x => x.QuestionnaireCategoryQuestionnaireCategoriesID,
                        principalSchema: "StudentGradingSystem",
                        principalTable: "QuestionnaireCategories",
                        principalColumn: "QuestionnaireCategoriesID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupModule",
                schema: "StudentGradingSystem",
                columns: table => new
                {
                    GroupModuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(nullable: true),
                    ModuleDetailsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupModule", x => x.GroupModuleID);
                    table.ForeignKey(
                        name: "FK_GroupModule_ModuleDetails_ModuleDetailsID",
                        column: x => x.ModuleDetailsID,
                        principalSchema: "StudentGradingSystem",
                        principalTable: "ModuleDetails",
                        principalColumn: "ModuleDetailsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionnaireAnswers",
                schema: "StudentGradingSystem",
                columns: table => new
                {
                    QuestionnaireAnswersID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnswerID = table.Column<int>(nullable: false),
                    QuestionnaireQuestionsID = table.Column<int>(nullable: true),
                    Score = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionnaireAnswers", x => x.QuestionnaireAnswersID);
                    table.ForeignKey(
                        name: "FK_QuestionnaireAnswers_QuestionnaireQuestions_QuestionnaireQuestionsID",
                        column: x => x.QuestionnaireQuestionsID,
                        principalSchema: "StudentGradingSystem",
                        principalTable: "QuestionnaireQuestions",
                        principalColumn: "QuestionnaireQuestionsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourse",
                schema: "StudentGradingSystem",
                columns: table => new
                {
                    StudentCourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnswerID = table.Column<int>(nullable: false),
                    CourseModuleDetailsID = table.Column<int>(nullable: true),
                    Grade = table.Column<double>(nullable: false),
                    GroupGradeOK = table.Column<int>(nullable: false),
                    GroupModuleID = table.Column<int>(nullable: true),
                    ProfessorGuessGrade = table.Column<double>(nullable: false),
                    SelfEvaluationGrade = table.Column<double>(nullable: false),
                    SelfEvaluationID = table.Column<int>(nullable: false),
                    UserNameStudent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse", x => x.StudentCourseID);
                    table.ForeignKey(
                        name: "FK_StudentCourse_ModuleDetails_CourseModuleDetailsID",
                        column: x => x.CourseModuleDetailsID,
                        principalSchema: "StudentGradingSystem",
                        principalTable: "ModuleDetails",
                        principalColumn: "ModuleDetailsID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentCourse_GroupModule_GroupModuleID",
                        column: x => x.GroupModuleID,
                        principalSchema: "StudentGradingSystem",
                        principalTable: "GroupModule",
                        principalColumn: "GroupModuleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupModule_ModuleDetailsID",
                schema: "StudentGradingSystem",
                table: "GroupModule",
                column: "ModuleDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Module_TemplateQuestionnaireIDQuestionnaireID",
                schema: "StudentGradingSystem",
                table: "Module",
                column: "TemplateQuestionnaireIDQuestionnaireID");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleDetails_ModuleID1",
                schema: "StudentGradingSystem",
                table: "ModuleDetails",
                column: "ModuleID1");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleDetails_QuestionnaireID1",
                schema: "StudentGradingSystem",
                table: "ModuleDetails",
                column: "QuestionnaireID1");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionnaireAnswers_QuestionnaireQuestionsID",
                schema: "StudentGradingSystem",
                table: "QuestionnaireAnswers",
                column: "QuestionnaireQuestionsID");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionnaireCategories_QuestionnaireID1",
                schema: "StudentGradingSystem",
                table: "QuestionnaireCategories",
                column: "QuestionnaireID1");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionnaireQuestions_QuestionnaireCategoryQuestionnaireCategoriesID",
                schema: "StudentGradingSystem",
                table: "QuestionnaireQuestions",
                column: "QuestionnaireCategoryQuestionnaireCategoriesID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_CourseModuleDetailsID",
                schema: "StudentGradingSystem",
                table: "StudentCourse",
                column: "CourseModuleDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_GroupModuleID",
                schema: "StudentGradingSystem",
                table: "StudentCourse",
                column: "GroupModuleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionnaireAnswers",
                schema: "StudentGradingSystem");

            migrationBuilder.DropTable(
                name: "StudentCourse",
                schema: "StudentGradingSystem");

            migrationBuilder.DropTable(
                name: "QuestionnaireQuestions",
                schema: "StudentGradingSystem");

            migrationBuilder.DropTable(
                name: "GroupModule",
                schema: "StudentGradingSystem");

            migrationBuilder.DropTable(
                name: "QuestionnaireCategories",
                schema: "StudentGradingSystem");

            migrationBuilder.DropTable(
                name: "ModuleDetails",
                schema: "StudentGradingSystem");

            migrationBuilder.DropTable(
                name: "Module",
                schema: "StudentGradingSystem");

            migrationBuilder.DropTable(
                name: "Questionnaire",
                schema: "StudentGradingSystem");
        }
    }
}
