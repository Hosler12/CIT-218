using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GetItDone",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetItDone", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "GetItDone",
                columns: new[] { "ID", "CreatedDate", "Description" },
                values: new object[] { 1, new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "Do CIT228 Homework" });

            migrationBuilder.InsertData(
                table: "GetItDone",
                columns: new[] { "ID", "CreatedDate", "Description" },
                values: new object[] { 2, new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "Take a nap" });

            migrationBuilder.InsertData(
                table: "GetItDone",
                columns: new[] { "ID", "CreatedDate", "Description" },
                values: new object[] { 3, new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "Work Out" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetItDone");
        }
    }
}
