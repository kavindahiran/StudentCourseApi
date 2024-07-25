using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentCourseApi.Migrations
{
    /// <inheritdoc />
    public partial class initialcommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Employees_StudentId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_StudentId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Course");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CourseId",
                table: "Employees",
                column: "CourseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Course_CourseId",
                table: "Employees",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Course_CourseId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CourseId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Course_StudentId",
                table: "Course",
                column: "StudentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Employees_StudentId",
                table: "Course",
                column: "StudentId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
