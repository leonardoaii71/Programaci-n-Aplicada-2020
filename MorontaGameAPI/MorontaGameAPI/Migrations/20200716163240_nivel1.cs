using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MorontaGameAPI.Migrations
{
    public partial class nivel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nivel1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    PlayerName = table.Column<string>(fixedLength: true, maxLength: 255, nullable: false),
                    Score = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nivel1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nivel2",
                columns: table => new
                {
                    PlayerName = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "S3scoreController",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(maxLength: 50, nullable: true),
                    Score = table.Column<int>(nullable: false),
                    CreacionDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S3scoreController", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nivel1");

            migrationBuilder.DropTable(
                name: "Nivel2");

            migrationBuilder.DropTable(
                name: "S3scoreController");
        }
    }
}
