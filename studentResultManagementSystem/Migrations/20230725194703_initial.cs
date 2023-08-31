using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentResultManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    symbol_no = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_no = table.Column<long>(type: "bigint", maxLength: 10, nullable: false),
                    gender = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.symbol_no);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    subject_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    subject_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.subject_id);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    std_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    sub_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    theory_marks = table.Column<int>(type: "int", nullable: false),
                    assignment_marks = table.Column<int>(type: "int", nullable: false),
                    practical_marks = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<int>(type: "int", nullable: false),
                    result_obt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => new { x.std_id, x.sub_id });
                    table.ForeignKey(
                        name: "FK_Results_Student_std_id",
                        column: x => x.std_id,
                        principalTable: "Student",
                        principalColumn: "symbol_no",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Results_Subject_sub_id",
                        column: x => x.sub_id,
                        principalTable: "Subject",
                        principalColumn: "subject_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Results_sub_id",
                table: "Results",
                column: "sub_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Subject");
        }
    }
}
