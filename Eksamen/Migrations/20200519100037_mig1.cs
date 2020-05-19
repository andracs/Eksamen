using Microsoft.EntityFrameworkCore.Migrations;

namespace Eksamen.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "ProductImage" },
                values: new object[] { -1, "Helmet", "En god hjelm til billige penge", "HJC C70", 899m, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "ProductImage" },
                values: new object[] { -2, "Helmet", "ECE-godkendt", "Scorpion X", 500m, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "ProductImage" },
                values: new object[] { 1, "Helmet", "En god hjelm til billige penge", "HJC C70", 899m, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "ProductImage" },
                values: new object[] { 2, "Helmet", "En god hjelm til billige penge", "Bum", 500m, 2 });
        }
    }
}
