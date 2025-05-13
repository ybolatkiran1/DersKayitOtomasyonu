using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "STUDENTS",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentPeriod = table.Column<int>(type: "int", nullable: false),
                    StudentStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STUDENTS", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "TEACHERS",
                columns: table => new
                {
                    TeacherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherExpertise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEACHERS", x => x.TeacherID);
                });

            migrationBuilder.CreateTable(
                name: "lESSONS",
                columns: table => new
                {
                    LessonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LessonLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LessonStatus = table.Column<bool>(type: "bit", nullable: false),
                    TeacherID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lESSONS", x => x.LessonId);
                    table.ForeignKey(
                        name: "FK_lESSONS_TEACHERS_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "TEACHERS",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lESSONS_TeacherID",
                table: "lESSONS",
                column: "TeacherID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lESSONS");

            migrationBuilder.DropTable(
                name: "STUDENTS");

            migrationBuilder.DropTable(
                name: "TEACHERS");
        }
    }
}
