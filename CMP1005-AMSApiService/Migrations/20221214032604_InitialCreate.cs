using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMP1005_AMSApiService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gatherings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    GatheringDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GatheringLabel = table.Column<string>(type: "TEXT", nullable: false),
                    AttendeesCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gatherings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gatherings");
        }
    }
}
