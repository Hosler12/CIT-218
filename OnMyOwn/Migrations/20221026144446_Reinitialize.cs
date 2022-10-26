using Microsoft.EntityFrameworkCore.Migrations;

namespace OnMyOwn.Migrations
{
    public partial class Reinitialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    PhoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneName = table.Column<string>(nullable: true),
                    PhoneType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.PhoneId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(name: "Phone Number", nullable: false),
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    PhoneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customer_Phone_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phone",
                        principalColumn: "PhoneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Phone",
                columns: new[] { "PhoneId", "PhoneName", "PhoneType" },
                values: new object[,]
                {
                    { 1, "Mini-Phone", "Mobile" },
                    { 2, "Super-Phone", "Mobile" },
                    { 3, "Mega-Phone", "Lanline" },
                    { 4, "Multi-Phone", "Landline" },
                    { 5, "Classic-Phone", "Mobile" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "City", "Name", "Phone Number", "PhoneId", "State" },
                values: new object[,]
                {
                    { 1, "01 Fictional Road", "Traverse City", "Amanda Apple", "231-499-5412", 3, "MI" },
                    { 2, "23 Almost Real Drive", "Traverse City", "Barry Burro", "231-454-4545", 3, "MI" },
                    { 4, "67 Entirely False Boulevard", "Traverse City", "Danny Dacca", "231-458-5454", 4, "MI" },
                    { 5, "89 Something Witty Avenue", "Traverse City", "Emily ", "231-848-6842", 4, "MI" },
                    { 3, "45 Kind of Fake Street", "Traverse City", "Cindy Cavendish", "231-489-8474", 5, "MI" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_PhoneId",
                table: "Customer",
                column: "PhoneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Phone");
        }
    }
}
