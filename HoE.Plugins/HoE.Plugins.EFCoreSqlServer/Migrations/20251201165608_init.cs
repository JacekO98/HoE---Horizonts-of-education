using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HoE.Plugins.EFCoreSqlServer.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kalendars",
                columns: table => new
                {
                    K_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kalendars", x => x.K_ID);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    T_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Klass = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Levels = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.T_ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    S_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.S_ID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    T_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.T_ID);
                });

            migrationBuilder.CreateTable(
                name: "TLevels",
                columns: table => new
                {
                    T_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    L_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLevels", x => x.T_ID);
                });

            migrationBuilder.CreateTable(
                name: "TAvaliables",
                columns: table => new
                {
                    T_ID = table.Column<int>(type: "int", nullable: false),
                    K_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAvaliables", x => new { x.T_ID, x.K_ID });
                    table.ForeignKey(
                        name: "FK_TAvaliables_Kalendars_K_ID",
                        column: x => x.K_ID,
                        principalTable: "Kalendars",
                        principalColumn: "K_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TAvaliables_Teachers_T_ID",
                        column: x => x.T_ID,
                        principalTable: "Teachers",
                        principalColumn: "T_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SummaryTables",
                columns: table => new
                {
                    T_ID = table.Column<int>(type: "int", nullable: false),
                    L_ID = table.Column<int>(type: "int", nullable: false),
                    S_ID = table.Column<int>(type: "int", nullable: false),
                    K_ID = table.Column<int>(type: "int", nullable: false),
                    TLevelsT_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SummaryTables", x => new { x.T_ID, x.L_ID, x.S_ID, x.K_ID });
                    table.ForeignKey(
                        name: "FK_SummaryTables_Kalendars_K_ID",
                        column: x => x.K_ID,
                        principalTable: "Kalendars",
                        principalColumn: "K_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SummaryTables_Levels_L_ID",
                        column: x => x.L_ID,
                        principalTable: "Levels",
                        principalColumn: "T_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SummaryTables_Students_S_ID",
                        column: x => x.S_ID,
                        principalTable: "Students",
                        principalColumn: "S_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SummaryTables_TLevels_TLevelsT_ID",
                        column: x => x.TLevelsT_ID,
                        principalTable: "TLevels",
                        principalColumn: "T_ID");
                    table.ForeignKey(
                        name: "FK_SummaryTables_Teachers_T_ID",
                        column: x => x.T_ID,
                        principalTable: "Teachers",
                        principalColumn: "T_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "T_ID", "Name", "Picture" },
                values: new object[,]
                {
                    { 1, "Katarzyna Sikora", "erg" },
                    { 2, "Magdalena Sikora", "erg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SummaryTables_K_ID",
                table: "SummaryTables",
                column: "K_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SummaryTables_L_ID",
                table: "SummaryTables",
                column: "L_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SummaryTables_S_ID",
                table: "SummaryTables",
                column: "S_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SummaryTables_TLevelsT_ID",
                table: "SummaryTables",
                column: "TLevelsT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TAvaliables_K_ID",
                table: "TAvaliables",
                column: "K_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SummaryTables");

            migrationBuilder.DropTable(
                name: "TAvaliables");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "TLevels");

            migrationBuilder.DropTable(
                name: "Kalendars");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
