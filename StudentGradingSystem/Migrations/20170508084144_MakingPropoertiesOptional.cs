using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentGradingSystem.Migrations
{
    public partial class MakingPropoertiesOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "SelfEvaluationGrade",
                schema: "StudentGradingSystem",
                table: "StudentCourse",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "ProfessorGuessGrade",
                schema: "StudentGradingSystem",
                table: "StudentCourse",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "Grade",
                schema: "StudentGradingSystem",
                table: "StudentCourse",
                nullable: true,
                oldClrType: typeof(double));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "SelfEvaluationGrade",
                schema: "StudentGradingSystem",
                table: "StudentCourse",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ProfessorGuessGrade",
                schema: "StudentGradingSystem",
                table: "StudentCourse",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Grade",
                schema: "StudentGradingSystem",
                table: "StudentCourse",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);
        }
    }
}
