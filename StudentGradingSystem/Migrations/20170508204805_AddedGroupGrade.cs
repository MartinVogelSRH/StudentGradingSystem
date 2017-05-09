using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentGradingSystem.Migrations
{
    public partial class AddedGroupGrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionnaireCategories_Questionnaire_QuestionnaireID1",
                schema: "StudentGradingSystem",
                table: "QuestionnaireCategories");

            migrationBuilder.AlterColumn<bool>(
                name: "GroupGradeOK",
                schema: "StudentGradingSystem",
                table: "StudentCourse",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<double>(
                name: "GroupGrade",
                schema: "StudentGradingSystem",
                table: "StudentCourse",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Weighting",
                schema: "StudentGradingSystem",
                table: "QuestionnaireCategories",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "QuestionnaireID1",
                schema: "StudentGradingSystem",
                table: "QuestionnaireCategories",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionnaireCategories_Questionnaire_QuestionnaireID1",
                schema: "StudentGradingSystem",
                table: "QuestionnaireCategories",
                column: "QuestionnaireID1",
                principalSchema: "StudentGradingSystem",
                principalTable: "Questionnaire",
                principalColumn: "QuestionnaireID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionnaireCategories_Questionnaire_QuestionnaireID1",
                schema: "StudentGradingSystem",
                table: "QuestionnaireCategories");

            migrationBuilder.DropColumn(
                name: "GroupGrade",
                schema: "StudentGradingSystem",
                table: "StudentCourse");

            migrationBuilder.AlterColumn<int>(
                name: "GroupGradeOK",
                schema: "StudentGradingSystem",
                table: "StudentCourse",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Weighting",
                schema: "StudentGradingSystem",
                table: "QuestionnaireCategories",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QuestionnaireID1",
                schema: "StudentGradingSystem",
                table: "QuestionnaireCategories",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionnaireCategories_Questionnaire_QuestionnaireID1",
                schema: "StudentGradingSystem",
                table: "QuestionnaireCategories",
                column: "QuestionnaireID1",
                principalSchema: "StudentGradingSystem",
                principalTable: "Questionnaire",
                principalColumn: "QuestionnaireID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
