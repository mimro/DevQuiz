using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevQuiz.Api.Migrations
{
    public partial class PopulateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "Name", "QuizLevel", "QuizTopic" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"), "Test 1", 0, 1 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "QuestionText", "QuizId" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"), "TestQuestion", new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314") });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerText", "IsCorrectAnswer", "QuestionId" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea123"), "TestAnswer", true, new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea123"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"));
        }
    }
}
