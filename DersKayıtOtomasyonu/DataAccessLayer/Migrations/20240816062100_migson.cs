using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class migson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DersKaydi");

            migrationBuilder.DropTable(
                name: "lESSONS");

            migrationBuilder.DropTable(
                name: "TEACHERS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DersKaydi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentPeriod = table.Column<int>(type: "int", nullable: false),
                    StudentTel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersKaydi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TEACHERS",
                columns: table => new
                {
                    TeacherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherExpertise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    TeacherID = table.Column<int>(type: "int", nullable: false),
                    LessonLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LessonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LessonStatus = table.Column<bool>(type: "bit", nullable: false)
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
    }
}
