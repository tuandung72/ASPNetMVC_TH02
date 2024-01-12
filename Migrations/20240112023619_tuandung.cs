using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.Net_MVC_Core.Migrations
{
    public partial class tuandung : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_STUDENT_MARK_Subject_subjectid",
                table: "D_STUDENT_MARK");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "D_SUBJECT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_D_SUBJECT",
                table: "D_SUBJECT",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_STUDENT_MARK_D_SUBJECT_subjectid",
                table: "D_STUDENT_MARK",
                column: "subjectid",
                principalTable: "D_SUBJECT",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_STUDENT_MARK_D_SUBJECT_subjectid",
                table: "D_STUDENT_MARK");

            migrationBuilder.DropPrimaryKey(
                name: "PK_D_SUBJECT",
                table: "D_SUBJECT");

            migrationBuilder.RenameTable(
                name: "D_SUBJECT",
                newName: "Subject");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_STUDENT_MARK_Subject_subjectid",
                table: "D_STUDENT_MARK",
                column: "subjectid",
                principalTable: "Subject",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
