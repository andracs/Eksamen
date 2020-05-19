using Microsoft.EntityFrameworkCore.Migrations;

namespace Eksamen.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductImage",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductImageId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Path" },
                values: new object[,]
                {
                    { 1, "/images/products/hjelm1.jpg" },
                    { 2, "/images/products/hjelm2.jpg" },
                    { 3, "/images/products/hjelm3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "ProductImageId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "ProductImageId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ProductImageId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductImage",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "ProductImage",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "ProductImage",
                value: 1);
        }
    }
}
