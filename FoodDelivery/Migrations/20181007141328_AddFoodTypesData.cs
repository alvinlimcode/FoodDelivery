using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDelivery.Migrations
{
    public partial class AddFoodTypesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FoodTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, "seed", new DateTime(2018, 10, 7, 22, 13, 28, 136, DateTimeKind.Local), "Asian Foods", "seed", new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) },
                    { 2L, "seed", new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local), "Burgers", "seed", new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) },
                    { 3L, "seed", new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local), "Appetizers", "seed", new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) },
                    { 4L, "seed", new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local), "Desserts", "seed", new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) },
                    { 5L, "seed", new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local), "Breakfast", "seed", new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) },
                    { 6L, "seed", new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local), "Pizzas", "seed", new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 6L);
        }
    }
}
