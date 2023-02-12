using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Library.DomainData.Migrations
{
    public partial class ManagerStudentDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    IDClass = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NameClass = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.IDClass);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    IDStudent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NameStudent = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    IDClassStudent = table.Column<int>(type: "int", nullable: false),
                    T_ClassIDClass = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.IDStudent);
                    table.ForeignKey(
                        name: "FK_Students_Classes_IDClassStudent",
                        column: x => x.IDClassStudent,
                        principalTable: "Classes",
                        principalColumn: "IDClass");
                    table.ForeignKey(
                        name: "FK_Students_Classes_T_ClassIDClass",
                        column: x => x.T_ClassIDClass,
                        principalTable: "Classes",
                        principalColumn: "IDClass",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "IDClass", "NameClass" },
                values: new object[,]
                {
                    { 1, "11B" },
                    { 2, "10B" },
                    { 3, "12B" },
                    { 4, "11A" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "IDStudent", "IDClassStudent", "NameStudent", "T_ClassIDClass" },
                values: new object[,]
                {
                    { 1, 1, "Marry", null },
                    { 5, 1, "Messis", null },
                    { 2, 2, "Jsen", null },
                    { 3, 3, "Cherry", null },
                    { 4, 4, "Leon", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_IDClassStudent",
                table: "Students",
                column: "IDClassStudent");

            migrationBuilder.CreateIndex(
                name: "IX_Students_T_ClassIDClass",
                table: "Students",
                column: "T_ClassIDClass");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
