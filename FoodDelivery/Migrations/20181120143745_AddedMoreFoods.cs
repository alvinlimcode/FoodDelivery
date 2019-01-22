using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDelivery.Migrations
{
    public partial class AddedMoreFoods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 20, 22, 37, 44, 574, DateTimeKind.Local), new DateTime(2018, 11, 20, 22, 37, 44, 576, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 20, 22, 37, 44, 576, DateTimeKind.Local), new DateTime(2018, 11, 20, 22, 37, 44, 576, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 20, 22, 37, 44, 576, DateTimeKind.Local), new DateTime(2018, 11, 20, 22, 37, 44, 576, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 20, 22, 37, 44, 576, DateTimeKind.Local), new DateTime(2018, 11, 20, 22, 37, 44, 576, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 20, 22, 37, 44, 576, DateTimeKind.Local), new DateTime(2018, 11, 20, 22, 37, 44, 576, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 20, 22, 37, 44, 576, DateTimeKind.Local), new DateTime(2018, 11, 20, 22, 37, 44, 576, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "FoodTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 7L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 576, DateTimeKind.Local), "Roast", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 576, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "FoodTypeId", "ImageUrl", "LongDescription", "Name", "Price", "RestaurantId", "ShortDescription", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 5L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 1L, "asian-food-bowl-cuisine-699953.jpg", "We use only fresh big prawns and ingredients to cook the best prawn noodle in the town.", "Prawn Noodle", 6.00m, 1L, "Fresh prawn and ingredients", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 7L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 1L, "barbecue-bbq-cooking-111131.jpg", "", "Skewed Meat", 7.00m, 1L, "Juicy skewed meat with secret sauce", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 11L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 1L, "bowl-cooking-cuisine-698549.jpg", "", "Chasiu Noodle", 5.00m, 1L, "A normal Chasiu Noodle", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 17L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 1L, "chicken-close-up-crispy-60616.jpg", "", "Crispy Fried Chicken", 5.00m, 1L, "Crispy Fried Chicken", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 19L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 1L, "chopsticks-cuisine-dinner-46247.jpg", "", "Pad Thai", 5.00m, 1L, "Pad Thai", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) }
                });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), "Authentic Asian Food Restaurant", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "ImageUrl", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 2L, null, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), null, "Western Food Restaurant", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "FoodTypeId", "ImageUrl", "LongDescription", "Name", "Price", "RestaurantId", "ShortDescription", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 2L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 5L, "appetizer-bowl-breakfast-280018.jpg", null, "Healthy Breakfast Wrap", 8.00m, 2L, "A healthy simple breakfast for wrap lover!", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 3L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 3L, "appetizer-chicken-chicken-dippers-1059943.jpg", "Something you cannot miss as an appetizer", "Chicken Dipper", 4.00m, 2L, "Delicious snack fried chicken dipper with mayonnaise sauce", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 4L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 3L, "appetizer-close-up-cucumber-406152.jpg", "Good for vegan", "Vegetables Salad", 5.00m, 2L, "Only vegetables", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 6L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 4L, "bakery-baking-blueberries-291528.jpg", "Delicious blueberry chocolate cake for birthday and any party occassions.", "Blueberry Chocolate Cake", 30.00m, 2L, "Baked with love!", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 8L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 3L, "basil-close-up-cooking-725997.jpg", "", "Tomato Prawn Spaghetti", 13.00m, 2L, "Spaghetti with tomato sauce and prawns", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 9L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 2L, "beef-bread-burger-156114.jpg", "", "Big beef cheeseburger", 15.00m, 2L, "A full big beef cheeseburger for dinner", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 10L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 5L, "blur-breakfast-close-up-376464.jpg", "", "Pancake", 4.00m, 2L, "Just a pancake", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 12L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 5L, "bread-breakfast-bun-461382.jpg", "", "Ham Sandwich", 7.00m, 2L, "Ham Sandwich", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 13L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 5L, "breakfast-chocolate-cream-264727.jpg", "", "Crepe", 7.00m, 2L, "Colorful Crepe for breakfast", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 14L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 5L, "burrito-chicken-close-up-461198.jpg", "", "Buritto Chicken", 6.00m, 2L, "Buritto Chicken", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 15L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 6L, "cheese-close-up-crust-1146760.jpg", "", "Pizza", 13.00m, 2L, "Pizza lover", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 16L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 3L, "chicken-chips-delicious-7782.jpg", "", "Chicken & Chips", 5.00m, 2L, "Chicken & Chips", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 18L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 7L, "chicken-dinner-dish-236781.jpg", "", "Roast Chicken with Potatoes", 12.00m, 2L, "Roast Chicken with Potatoes", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 20L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 7L, "close-up-cooking-dinner-46239.jpg", "", "Baked Salmon", 9.00m, 2L, "Baked Salmon", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) },
                    { 21L, "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local), 4L, "cream-dessert-glass-8382.jpg", "", "Strawberry Yogurt", 8.00m, 2L, "Strawberry Yogurt", "seed", new DateTime(2018, 11, 20, 22, 37, 44, 577, DateTimeKind.Local) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2L);

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

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 10, 22, 24, 16, 104, DateTimeKind.Local), new DateTime(2018, 11, 10, 22, 24, 16, 104, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 10, 22, 24, 16, 104, DateTimeKind.Local), "Authentic Korean Food Restaurant", new DateTime(2018, 11, 10, 22, 24, 16, 104, DateTimeKind.Local) });
        }
    }
}
