using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laba4EF.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FirstTable",
                columns: table => new
                {
                    gameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    platform = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yearOfRelease = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criticScore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    criticCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userScore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    developer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rating = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstTable", x => x.gameID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FirstTable");
        }
    }
}
