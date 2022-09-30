using Microsoft.EntityFrameworkCore.Migrations;

namespace OnMyOwn.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Genre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Cost", "Genre", "Title", "Year" },
                values: new object[] { 1, 14.890000000000001, "Non-Fiction", "Banana: The Fate of the Fruit That Changed the World", 2008 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Cost", "Genre", "Title", "Year" },
                values: new object[] { 2, 18.0, "Non-Fiction", "Bananeras: Women Transforming the Banana Unions of Latin America", 2005 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Cost", "Genre", "Title", "Year" },
                values: new object[] { 3, 11.99, "Non-Fiction", "Banana Cultures: Agriculture, Consumption, and Environmental Change in Honuras and the United States", 2006 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
