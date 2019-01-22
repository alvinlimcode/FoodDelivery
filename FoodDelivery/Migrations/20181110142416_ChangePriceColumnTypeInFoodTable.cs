using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDelivery.Migrations
{
    public partial class ChangePriceColumnTypeInFoodTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Foods",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 10, 22, 24, 16, 102, DateTimeKind.Local), new DateTime(2018, 11, 10, 22, 24, 16, 103, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 10, 22, 24, 16, 103, DateTimeKind.Local), new DateTime(2018, 11, 10, 22, 24, 16, 103, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 10, 22, 24, 16, 103, DateTimeKind.Local), new DateTime(2018, 11, 10, 22, 24, 16, 103, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 10, 22, 24, 16, 103, DateTimeKind.Local), new DateTime(2018, 11, 10, 22, 24, 16, 103, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 10, 22, 24, 16, 103, DateTimeKind.Local), new DateTime(2018, 11, 10, 22, 24, 16, 103, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 10, 22, 24, 16, 103, DateTimeKind.Local), new DateTime(2018, 11, 10, 22, 24, 16, 103, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "ImageUrl", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1L, null, "seed", new DateTime(2018, 11, 10, 22, 24, 16, 104, DateTimeKind.Local), null, "Authentic Korean Food Restaurant", "seed", new DateTime(2018, 11, 10, 22, 24, 16, 104, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "FoodTypeId", "ImageUrl", "LongDescription", "Name", "Price", "RestaurantId", "ShortDescription", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1L, "seed", new DateTime(2018, 11, 10, 22, 24, 16, 104, DateTimeKind.Local), 1L, "egg-food-fried-rice-53121 (1).jpg", null, "Kimchi Fried Rice With Egg", 7.00m, 1L, "Spicy fragnance kimchi fried rice together with an egg good enough for a simple meal!", "seed", new DateTime(2018, 11, 10, 22, 24, 16, 104, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Foods",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 7, 22, 13, 28, 136, DateTimeKind.Local), new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local), new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local), new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local), new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local), new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local), new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) });
        }
    }
}
