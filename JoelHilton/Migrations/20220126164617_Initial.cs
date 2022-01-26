using Microsoft.EntityFrameworkCore.Migrations;

namespace JoelHilton.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.ApplicationId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Family", "Ryan Little", true, "", "", "PG-13", "Forever Strong", "2008" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Family", "Jared Bush", false, "", "", "PG", "Encanto", "2021" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "Jon Watts", false, "", "", "PG-13", "Spiderman: No Way Home", "2021" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
