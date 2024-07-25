using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentCourseApi.Migrations
{
    /// <inheritdoc />
    public partial class initialcommits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Course_CourseId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CourseId",
                table: "Employees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
