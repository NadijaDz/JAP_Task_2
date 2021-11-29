using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Infrastructure.Migrations
{
    public partial class Newmigrationwithnewseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "UnitQuantity",
                table: "RecipesIngredients",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitQuantity",
                table: "Ingredients",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "Ingredients",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostIngredient",
                table: "Ingredients",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice" },
                values: new object[] { 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "salt", 6m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice" },
                values: new object[] { 5m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "sugar", 5m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 10000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, "butter", 10m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 3m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "black pepper", 3m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 10000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "onion", 10m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, "eggs", 9m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 1, "all-purpose flour", 1m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitQuantity" },
                values: new object[] { 2m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "water", 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "olive oil", 6m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 4m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "pepper", 4m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 5000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, "milk", 5m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 7m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "garlic cloves", 7m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "unsalted butter", 8m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, "vegetable oil", 6m, 1m });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[,]
                {
                    { 75, 9000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 1, "strawberries", 9m, 1m },
                    { 80, 3m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "egg yolks", 3m, 1m },
                    { 18, 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "lemon juice", 1m, 1m },
                    { 79, 2000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "zucchini", 2m, 1m },
                    { 84, 7m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "balsamic vinegar", 7m, 1m },
                    { 65, 5000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 1, "orange juice", 5m, 1m },
                    { 38, 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "garlic powder", 9m, 1m },
                    { 66, 8m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "dried oregano", 8m, 1m },
                    { 39, 10000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 1, "cornstarch", 10m, 1m },
                    { 60, 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "dijon mustard", 9m, 1m },
                    { 49, 2m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "cinnamon", 2m, 1m },
                    { 48, 7000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "heavy cream", 7m, 1m },
                    { 45, 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "ground cumin", 9m, 1m },
                    { 28, 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "green onions", 6m, 1m },
                    { 33, 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "cream cheese", 1m, 1m },
                    { 94, 4000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "chicken", 4m, 1m },
                    { 16, 3m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "brown sugar", 3m, 1m },
                    { 99, 2m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "chicken breasts", 2m, 1m },
                    { 81, 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 1, "fresh basil", 1m, 1m },
                    { 29, 10m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "large eggs", 10m, 1m },
                    { 86, 8m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "juice", 8m, 1m },
                    { 89, 4000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "ground ginger", 4m, 1m },
                    { 47, 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "fresh lemon juice", 6m, 1m },
                    { 87, 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "apples", 1m, 1m },
                    { 54, 4m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "fresh cilantro", 4m, 1m },
                    { 58, 3m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "red bell pepper", 3m, 1m },
                    { 25, 5m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "tomatoes", 5m, 1m },
                    { 34, 4m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "granulated sugar", 4m, 1m }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[,]
                {
                    { 46, 9000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "soy sauce", 9m, 1m },
                    { 55, 4m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "potatoes", 4m, 1m },
                    { 91, 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "chopped pecans", 9m, 1m },
                    { 68, 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "shredded cheddar cheese", 9m, 1m },
                    { 98, 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "red pepper", 6m, 1m },
                    { 63, 4000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "powdered sugar", 4m, 1m },
                    { 88, 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "chopped walnuts", 9m, 1m },
                    { 23, 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "flour", 9m, 1m },
                    { 36, 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "chicken broth", 9m, 1m },
                    { 19, 8m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "vanilla extract", 8m, 1m },
                    { 24, 10m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "baking soda", 10m, 1m },
                    { 21, 3000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "carrots", 3m, 1m },
                    { 35, 4000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 1, "red onion", 4m, 1m },
                    { 72, 6000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "sea salt", 6m, 1m },
                    { 67, 2m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "scallions", 2m, 1m },
                    { 93, 1m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "buttermilk", 1m, 1m },
                    { 52, 7m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "paprika", 7m, 1m },
                    { 26, 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "kosher salt", 9m, 1m },
                    { 69, 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "cooking spray", 6m, 1m },
                    { 50, 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 1, "margarine", 1m, 1m },
                    { 17, 1m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "baking powder", 1m, 1m },
                    { 73, 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "shrimp", 6m, 1m },
                    { 53, 3m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "shallots", 3m, 1m },
                    { 85, 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "parmesan cheese", 1m, 1m },
                    { 32, 10m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "honey", 10m, 1m },
                    { 82, 5m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "garlic", 5m, 1m },
                    { 77, 9000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 1, "spinach", 9m, 1m },
                    { 96, 2m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "light brown sugar", 2m, 1m },
                    { 78, 8000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "ground nutmeg", 8m, 1m },
                    { 56, 10m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "chili powder", 10m, 1m },
                    { 43, 4m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "white sugar", 4m, 1m },
                    { 27, 2000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 1, "ground cinnamon", 2m, 1m },
                    { 40, 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "oil", 6m, 1m },
                    { 42, 2000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "minced garlic", 2m, 1m },
                    { 74, 4000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "diced tomatoes", 4m, 1m },
                    { 97, 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "lime juice", 9m, 1m },
                    { 20, 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "freshly ground pepper", 6m, 1m },
                    { 22, 4000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "cloves garlic", 4m, 1m },
                    { 64, 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "lemon", 6m, 1m },
                    { 59, 5m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "canola oil", 5m, 1m },
                    { 15, 1m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "extra-virgin olive oil", 1m, 1m },
                    { 100, 7000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "raisins", 7m, 1m }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[,]
                {
                    { 90, 6000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "semisweet chocolate", 6m, 1m },
                    { 83, 5m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 2, "dry white wine", 5m, 1m },
                    { 31, 1m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "sour cream", 1m, 1m },
                    { 57, 5000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 1, "worcestershire sauce", 5m, 1m },
                    { 95, 1m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "fresh ginger", 1m, 1m },
                    { 76, 2m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "melted butter", 2m, 1m },
                    { 30, 10000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "vanilla", 10m, 1m },
                    { 70, 5000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 3, "cayenne pepper", 5m, 1m },
                    { 92, 1m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "chicken stock", 1m, 1m },
                    { 44, 7m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 5, "mayonnaise", 7m, 1m },
                    { 37, 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "fresh parsley", 6m, 1m },
                    { 41, 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 1, "grated parmesan cheese", 1m, 1m },
                    { 71, 5000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 1, "ground beef", 5m, 1m },
                    { 61, 3m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "egg whites", 3m, 1m },
                    { 51, 8000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 1, "celery", 8m, 1m },
                    { 62, 7m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), false, 4, "bacon", 7m, 1m }
                });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "RecipeCategory_Id", "UserId" },
                values: new object[,]
                {
                    { 29, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "1. In a pot that covers the potatoes with water, bring to a boil. The sweet potatoes are done when they are fork tender.\r\n2. Mash the potatoes with a hand mixer (or fork or masher) and slowly add in butter and milk until potatoes are creamy and mashed to your preferred consistency. Add a touch of cinnamon for added flavour.", false, "Sweet Mashed Potatoes", 3, null },
                    { 125, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Cook rice if not already done.\r\n\r\nMeanwhile, in a large saucepan or Dutch oven, heat oil over medium heat. Add onion and cook, stirring frequently, until tender, about 5 minutes. Add garlic and mushrooms and cook, stirring occasionally, until mushrooms are tender, about 5 minutes. Add broth and rosemary; bring to a boil.\r\n\r\nStir cooked rice and chickpeas into the broth; return to a boil. Reduce to a simmer, cover, and continue cooking for 5 more minutes to allow flavors to blend.\r\n\r\nStir in spinach and cook, uncovered, until just wilted, about 1 minute. Season with salt and pepper. Garnish with cheese; serve immediately.", false, "Hearty spinach and chickpea soup", 4, null },
                    { 126, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Prepare an ice-water bath; set aside. Bring a medium pot of water to a boil; stir in 1 tablespoon salt. Add chervil. Return to a boil; cook until bright green, about 30 seconds. Using a slotted spoon, immediately transfer to ice-water bath. Drain, and chop coarsely.\r\n\r\nProcess chervil with 1/4 cup cold water in a food processor until very finely chopped. Pour through a fine-mesh sieve; discard liquid. Whip cream in a medium bowl until thick and fluffy but still pourable; stir in chervil, and season with salt.", false, "Chervil cream", 11, null },
                    { 127, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Cover dried mushrooms with 2 cups boiling water in a heatproof bowl; let stand until soft, about 30 minutes. Using a slotted spoon, transfer mushrooms to a cutting board, and finely chop; set aside. Strain soaking liquid; set aside.\r\n\r\nMelt butter in a large saucepan over medium heat. Add leeks; cook, stirring occasionally, until soft but not browned, 10 to 15 minutes. Stir in flour; cook 2 minutes. Add sherry; whisk until smooth. Whisk in stock, thyme, and reserved soaking liquid; bring to a boil. Reduce heat; simmer 5 minutes. Stir in dried and fresh mushrooms. Remove from heat.\r\n\r\nPour into a large bowl. Working in 3 batches, puree soup in a food processor, making sure there are no remaining mushroom pieces; return to pan. Bring to a simmer; cook, stirring occasionally, 15 minutes. Season with salt and pepper.\r\n\r\nStir in cream; bring just to a simmer. Season with salt. Stir in milk; cook until just heated through. Serve immediately, or refrigerate, covered, up to 3 days; reheat before serving. To serve, divide among bowls; spoon about 2 teaspoons chervil cream into each center, and sprinkle with croutons.", false, "Mushroom soup", 8, null },
                    { 128, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Preheat oven to 400 degrees. Place pumpkin halves, cut sides down, on a rimmed baking sheet. Bake until soft, about 50 minutes. Scoop out flesh, and puree in a food processor (you should have 2 cups).\r\nMelt 1 tablespoon butter in a small saucepan over medium-high heat. Add reserved seeds and fibers from pumpkin, and cook for 4 minutes. Add stock, water, and thyme, and bring to a gentle simmer. Cook for 9 to 10 minutes.\r\n\r\nMeanwhile, melt remaining 5 tablespoons butter in a large saucepan over medium-high heat. Add pumpkin puree, parsnip, potato, and turnip, and cook for 5 minutes. Add shallots, and cook until soft, about 4 minutes. Add wine, and cook until liquid has reduced by half.\r\n\r\nStrain pumpkin-seed mixture, reserving broth and discarding solids. Add broth to pumpkin-wine mixture. Bring to a simmer; cook 20 minutes. Let cool.\r\n\r\nPass soup through a food mill into a clean saucepan, or puree in a food processor in small batches until smooth. (If soup does not reach desired consistency using a food processor, press it through a fine sieve to remove any remaining lumps.) Heat soup in a saucepan over medium-high heat. Stir in cream, sugar, salt, and pepper, and serve", false, "Harvest pumpkin soup", 6, null },
                    { 129, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Preheat oven to 400 degrees. Spread tomatoes in a single layer on 2 rimmed baking sheets. Drizzle each sheet with 1 tablespoon oil; sprinkle each with 1/2 teaspoon thyme, and season with salt and pepper. Bake until tomatoes have softened, about 20 minutes. (Leave oven on.)\r\n\r\nProcess bread in a food processor until coarse crumbs form. Melt 1 tablespoon butter with remaining tablespoon oil in amedium skillet over medium heat. Add breadcrumbs, and toss to coat. Season with salt and pepper; set aside.\r\n\r\nBring a large pot of water to a boil over high heat. Add 1 tablespoon salt and the pasta. Cook pasta until almost al dente, about 5 minutes. Drain, and run under cold water to stop cooking. Transfer to a large bowl; set aside.\r\n\r\nWhisk 1/2 cup stock into the flour in a medium bowl; set aside. Melt remaining tablespoon butter in a medium saucepan over medium heat. Stir in nutmeg, cayenne, remaining 1/2 teaspoon thyme, and 1 teaspoon salt. Add milk and remaining 1 1/2 cups stock. Whisk in flour mixture. Bring to a boil, whisking frequently. Reduce to a simmer. Cook 8 minutes, whisking frequently. Add cheeses; cook, stirring, until melted. Pour over macaroni, stirring to combine.\r\n\r\nPut eight 4 1/2-by-1 1/4-inch ramekins on a baking sheet. Put 2 tomato slices in bottom of each ramekin. Divide macaroni mixture evenly among ramekins. Top each with a tomato slice. Sprinkle with breadcrumbs and thyme sprigs. Bake until bubbling and golden brown, about 30 minutes. Serve immediately.", false, "Lighter macaroni and cheese", 14, null },
                    { 130, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Preheat oven to 325 degrees. Coat an 8-inch square baking pan with cooking spray. Line with two crisscrossed pieces of parchment or wax paper, spraying between sheets. Spray lined pan; set aside.\r\n\r\nProcess cookies in a food processor until finely ground. Gently press crumbs into bottom of prepared pan (do not rinse processor bowl).\r\n\r\nBlend cream cheese and sour cream in food processor until smooth, scraping down sides of bowl as needed. Add cocoa, cornstarch, sugar, egg, and egg white; process until smooth. Pour into pan; sprinkle with chocolate chips.\r\n\r\nBake until just set, 35 to 40 minutes; cool completely in pan. Refrigerate at least 1 hour. Invert onto a tray; peel off paper, and reinvert crust side down. Cut into 9 squares.", false, "Chocolate cheesecake squares", 14, null },
                    { 124, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Melt 4 tablespoons butter in a large saucepan over medium heat. Add leeks, garlic, shallots, and half of the onions. Cook, stirring occasionally, until vegetables are very soft and translucent, about 10 minutes. Reduce the heat to medium-low, and cook, stirring occasionally, until vegetables are deep golden brown, about 25 minutes.\r\n\r\nAdd vermouth, stock, and 1 teaspoon salt. Bring to a boil. Reduce heat to medium-low. Simmer, stirring occasionally, 15 minutes. Let cool. Puree onion mixture in batches in a blender until smooth, about 3 minutes per batch. Set aside.\r\n\r\nMeanwhile, melt remaining 2 tablespoons butter in a medium skillet over medium-low heat. Add remaining onion. Cook, stirring occasionally, until onion is very soft and golden brown, about 45 minutes. Cover, and set aside.\r\n\r\nReturn onion puree to saucepan. Stir in cream. Reheat over medium heat, stirring, until heated through but not boiling. Season with salt, if desired. Serve, topped with caramelized onions.", false, "Creamy caramelized onion soup", 14, null },
                    { 131, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Whisk cornstarch, sugar, cocoa powder, cinnamon, and salt in a medium saucepan. Add milks, whisking. Bring to a boil over medium-high heat, whisking constantly. Cook until thickened, about 1 minute. Whisk in chocolate; cook until chocolate has melted, about 1 minute.\r\n\r\nDivide evenly among six 4-ounce cups. To prevent a skin from forming, press plastic wrap onto surface of pudding. Refrigerate until set, at least 1 hour and up to overnight. Serve garnished with chocolate shavings and cinnamon sticks.", false, "Chocolate cinnamon pudding", 11, null },
                    { 133, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Combine blood orange juice and liqueur in a large pitcher. Refrigerate for at least 30 minutes. Pour into test tubes (indigo.com) or small glasses.\r\n\r\nMake ahead: Cocktails can be refrigerated in pitcher overnight. Stir before using.", false, "Blood orange cocktails", 11, null },
                    { 134, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Season salmon with salt and set aside.\r\n\r\nCombine marinade ingredients, except lemon slices, in a small saucepan and bring to a boil. Remove from heat and allow to cool to room temperature. Add lemon and pour cooled marinade over fish and marinate refrigerated for 2 to 4 hours. Turn fish occasionally.\r\n\r\nTo serve: Grill or broil on both sides until just done, approximately 4 to 5 minutes per side. Be careful not to overcook. Salmon should still be translucent in the center. Serve with Soba Noodle Salad on the side.", false, "Japanese style grilled salmon", 1, null },
                    { 135, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "In a medium stock pot, boil water, add salt and cook noodles. When finished, place noodles in an ice water bath to cool. Drain and set aside.\r\n\r\nIn a medium bowl combine, sesame oil, vinegar, soy sauce, hot chili oil, hoisin and extra-virgin olive oil. Mix thoroughly and then combine prepared vegetables and noodles.\r\n\r\nGarnish with sesame seeds and peanuts.", false, "Dang cold Asian noodle salad", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "RecipeCategory_Id", "UserId" },
                values: new object[,]
                {
                    { 136, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Combine all of the marinade ingredients in a resealable plastic bag. Add the salmon, seal the bag and refrigerate for at least 30 minutes, or up to 1 hour.\r\n\r\nCombine all of the tomatoes and onions ingredients in a large bowl and set aside until ready to assemble the gyros.\r\n\r\nCombine all of the ingredients for the dill cucumber sauce in a small bowl. Cover and refrigerate until ready to serve, at least 30 minutes, or up to 12 hours.\r\n\r\nPreheat the grill if using outdoors, or preheat indoor stovetop grill pan over medium-low heat.\r\n\r\nRemove salmon from the marinade and grill until cooked through, about 3 to 4 minutes per side. Remove from the grill to a plate and keep warm.\r\n\r\nPut the pita bread on grill to heat through.\r\n\r\nServe by cutting pitas in half, filling them with salmon, and topping them with the tomato mixture and the cucumber dill sauce. Add iceberg lettuce, if desired, and serve.", false, "Grilled salmon gyros", 14, null },
                    { 137, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "In a bowl, combine all the ingredients and stir until the sugar dissolves. Store in a covered container in the refrigerator; it will keep for up to 1 month.", false, "Homemade ponzu sauce", 1, null },
                    { 138, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Place the rice in a bowl. Add cold water to cover and wash the rice well by rubbing it between your hands, then drain. Repeat twice more. Pour the rice into a strainer to drain.\r\n\r\nPlace the rinsed rice and the 2 cups water in a 2 to 3-quart saucepan. Bring to a boil over high heat, reduce the heat to low, cover and cook for 20 minutes. Turn off the heat and let the rice stand for 10 minutes.\r\n\r\nIn a small pan, heat the vinegar, sugar, mirin and salt over medium heat until the sugar dissolves. Remove from the heat.\r\n\r\nTurn out the cooked rice into a large wooden or plastic bowl, and pour the vinegar mixture evenly over the rice. Fold the liquid in with a wooden rice paddle. At the same time, fan the rice to bring out the luster of the grains. Continue fanning and folding until the rice absorbs all the liquid. Cover with a damp cloth and let stand until ready to use. It will hold at room temperature for up to 4 hours.\r\n\r\nYield: about 4 cups", false, "Sushi rice", 1, null },
                    { 132, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "1. Preheat oven to 350F. Make the cake: Coat two 9-inch cake pans with cooking spray. Line bottoms with parchment, and coat with spray. Dust with all-purpose flour, tapping out excess. Whisk together flours, baking soda, and 3/4 teaspoon salt.\r\n2. Beat butter and sugar with a mixer on medium0high speed until pale and fluffy. Add eggs, 1 at a time, beating well after each addition. Beat in vanilla. Reduce speed to low. Beat in flour mixture in 3 additions, alternating with buttermilk, beginning and ending with flour. Beat in melted chocolate. Divide batter between pans, and smooth tops using an offset spatula.\r\n3. Bake cakes until a toothpick inserted into the centers comes out clean, 25 to 30 minutes. Turn out cakes onto racks, remove parchment, and let cool completely.\r\n4. Make the ganache: Bring cream to a gentle simmer in a small saucepan over medium-high heat. Pour over chopped chocolates and butter in a bowl. Let stand for 5 minutes. Whisk until smooth and shiny. Let stand until thickened, about 40 minutes. Transfer 1 3/4 cups ganache to a bowl, and fold in malt balls; reserve remaining ganache.\r\n5. Transfer 1 cake to a serving platter (top side up). Spread ganache-malt ball filling on top, and top with remaining cake (top side up). Refrigerated until set, about 15 minutes. Cut a large wedge from cake to serve on another plate. Pour remaining ganache (reheat if necessary) over cake and wedge, and let drip down sides and into cut center of cake. Garnish cake and platter with rubber cockroaches.\r\n\r\nStorage: Decorated cake can be refrigerated for up to 3 days, but the ganache with not be as shiny,. Bring to room temperature before serving.", false, "Creepy crawly cake", 7, null },
                    { 123, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Heat oil in a large (3-quart) saucepan over medium-low heat. Add ginger, garlic, and pepper flakes; cook, stirring, until fragrant, about 1 minute. Add carrots, coconut milk, and 3 cups water. In a small bowl, mix cornstarch and water until smooth; add to pot. Bring to a boil.\r\n\r\nBreak pasta in half; add to pot. Return to a boil, reduce heat to medium, and simmer until pasta is al dente and carrots are just tender, 3 to 4 minutes.\r\n\r\nAdd shrimp; stir until opaque, about 1 minute. Remove pot from heat, and stir in lime juice; season with salt. Ladle into serving bowls, and garnish with scallions.", false, "Coconut shrimp soup", 11, null },
                    { 122, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Heat oil in a large pot over medium heat until hot but not smoking. Add onion, garlic, and broccoli stems; cover, and cook, stirring occasionally, until vegetables are soft, about 15 minutes. Add stock and salt; cover, raise heat to medium-high, and bring to a boil. Add broccoli florets; reduce heat, and simmer, uncovered, until florets are just tender, about 10 minutes.\r\n\r\nRemove soup from heat, and let cool, about 10 minutes. Fill a blender no more than halfway to puree soup in batches until smooth. Return soup to pot; stir in milk and cayenne. Cook over medium heat until heated through (do not boil).\r\n\r\nHeat broiler. Divide cheese among bread slices; toast under broiler until melted and golden brown, 45 to 60 seconds. Divide soup among bowls. Top each bowl with a cheese toast, and serve.", false, "Broccoli soup with cheddar toasts", 2, null },
                    { 121, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "In a large saucepan, heat 1 tablespoon butter over medium. Add scallion whites, and cook, stirring, until softened, 1 to 2 minutes. Add peas, broth, and water. Bring to a boil; reduce heat to a simmer. Cook until peas are tender, about 5 minutes; set aside.\r\n\r\nIn a medium bowl, toss cheddar with scallion greens. Make 4 sandwiches with cheddar mixture and bread.\r\n\r\nIn a large skillet, heat 1 tablespoon butter over medium-low. Place sandwiches in skillet, and cook until golden, 3 to 4 minutes per side, adding remaining tablespoon butter to skillet to cook second side.\r\n\r\nWorking in batches, puree soup in a blender until smooth (filling blender only halfway to prevent spattering). If necessary, adjust consistency with a little bit of water. Season with salt, pepper, and lemon juice. Slice each panini into four \"fingers, and serve with soup.", false, "Green pea soup with cheddar scallion panini", 13, null },
                    { 106, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Preheat the oven to 350 degrees.\r\n\r\nIn a small bowl, using your fingers, combine the orange zest with the sugar � rubbing the grains as if you were playing with sand to release the orange oils into the sugar.\r\nUsing an electric mixer, beat the oil with the orange sugar until well mixed. In a separate bowl, sift the flour with the baking powder, baking soda and salt.\r\n\r\nAdd the orange juice and brandy to mixer and mix well.\r\n\r\nSlowly incorporate the flour cup by cup until the mixture forms a dough that is not too loose but not quite firm either. It will be dense and wet but not sticky. Once the flour is incorporated fully stop mixing.\r\n\r\nTo roll cookies, pinch a portion of dough off about the size of a walnut. Shape in your palms into a smooth oblong shape, almost like a small egg. Place on an ungreased cookie sheet. Shape and roll cookies until the sheet is filled.\r\n\r\nPress the tines of a large fork in a crosshatch pattern in the center of each cookie. This will flatten them slightly in the center. The cookies should resemble lightly flattened ovals when they go in the oven.\r\n\r\nBake in a preheated 350-degree oven for 25 � 30 minutes until lightly browned. (The cookies will darken when submerged in syrup.)\r\n\r\nWhile the cookies are baking, prepare the syrup.\r\n\r\nIn a saucepan, combine the honey, sugar, water, cinnamon, cloves, and lemon rind. Bring the mixture to a boil then lower the heat and simmer uncovered for about 10 to 15 minutes. Remove the cinnamon, cloves, and lemon rind and stir in lemon juice.\r\n\r\nPlace the ground walnuts in a shallow plate or bowl next to the stove top. When the cookies come out of the oven and while they are still very warm, carefully float the cookies in the syrup and allow the cookies to absorb syrup on both sides.\r\n\r\nUsing a fork or small spatula, remove the cookie from the syrup and place on a platter or plate. Press ground walnuts lightly into the tops of the cookies (syrup will help it adhere) and sprinkle lightly with ground cinnamon.\r\n\r\nDo not refrigerate Melomakarona as they will harden. Store in an airtight container at room temperature.", false, "Melomakarona - Honey Cookies with Walnuts", 6, null },
                    { 107, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Prepare the dough\r\n\r\nIn a large bowl:\r\n\r\nWhisk the dry ingredients together (sugar, baking powder, flour).\r\nAdd the oil, mixing with a spoon or hands.\r\nStir in the strained yogurt and eggs and mix with spoon until the dough begins to stiffen, adding the brandy to soften the dough as needed.\r\nKnead the dough in the bowl for approximately 10 minutes until smooth, and set aside to rest.\r\nPrepare the filling\r\n\r\nIn a separate bowl, mix the cheese, cinnamon, sugar, egg yolk, orange peel, and flour together until well blended.\r\n\r\nTo bake\r\n\r\nPreheat the oven to 350�F (180�C). Lightly grease a baking sheet.\r\n\r\nMake the pastry\r\n\r\nOn a floured surface with a rolling pin, roll a piece of dough out to a thickness of about 1/8th of an inch. Using a 3-4 inch cutter or saucer as a guide, cut out circles. (Alternatively, take a piece of dough the size of an unshelled walnut and roll it out to a circle about 3-4 inches across.)\r\n\r\nPlace a spoonful of the cheese mixture into the center of the circle and spread out close to the edges. Raise the rim of the dough up around the cheese and, with wet fingers, pinch the edges to pull the dough in around the cheese, leaving the center open so the cheese shows.\r\n\r\nRepeat using all the dough and filling. Place the kalitsounia on the baking sheet and brush lightly with beaten egg to glaze. Bake at 350�F (180�C) for approximately 20 minutes until lightly browned (see photo). Sprinkle lightly with cinnamon.\r\n\r\nAllow to cool on the baking sheet. Kalitsounia will keep well, covered, in the refrigerator.\r\n\r\nTo fry\r\n\r\nPlace a teaspoonful of cheese mix into the center of the circle, fold the circle over into a half-moon shape. With wet fingers, crimp the edges to close securely. Preheat 1 cup of olive oil over medium heat and fry until golden on both sides. Drain on paper towels. Sprinkle with confectioner's sugar or drizzle with honey.\r\n\r\nYield: 30-36 pieces", false, "Kalitsounia Kritis: Sweet Cheese Pastries from Crete", 8, null },
                    { 108, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "1) Beat the butter, sugars, vanilla and salt till fluffy.\r\n\r\n2) Beat in the eggs one at a time, being sure to scrape down the sides and bottom of the bowl midway through to make sure everything is well combined.\r\n\r\n3) Whisk together the flour or flour blend, xanthan gum, baking powder, and baking soda.\r\n\r\n4) Beat the dry ingredients into the butter mixture, then blend in the chocolate chips and nuts. Again, scrape the bottom and sides of the bowl to be sure everything is well blended.\r\n\r\n5) Cover the bowl and refrigerate for 1 hour, or for up to 2 days.\r\n\r\n6) Preheat the oven to 350�F. Lightly grease a couple of baking sheets, or line with parchment.\r\n\r\n7) Scoop tablespoon-sized balls of dough onto the prepared baking sheets; a tablespoon cookie scoop works well here. Leave space between the cookies so they can spread.\r\n\r\n8) Bake the cookies for 9 to 11 minutes, until golden brown. Remove from the oven and let rest on the baking sheets for 5 minutes, to set, before transferring to racks to cool completely. Or allow them to cool right on the baking sheets.\r\n\r\nYield: 3 dozen cookies", false, "Gluten-free chocolate chips cookies", 2, null },
                    { 109, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Preheat the oven to 200 degrees. Oil two large baking sheets, a bench scraper, and kitchen shears or a sharp knife. Lay a piece of parchment paper or a Silpat on the counter where the canes can dry. Move one of the baking sheets to the warm oven.\r\n\r\nMeanwhile, in a straight-sided deep saucepan off heat, combine the sugar, corn syrup, water, cream of tartar, and salt and stir them together well. Clip a candy thermometer to the side of the pot and move it onto medium-high heat. Without stirring, let the syrup come up to 305 degrees. Using a pastry brush or a paint brush dedicated to culinary use, wash down any stray sugar crystals from the side of the pot. Ready the peppermint oil, food coloring, measuring spoons, and vegetable oil. Glove thyself with either heat-retardant gloves or snug mittens covered with disposable gloves.\r\n\r\nOnce the syrup has reached temperature, pour it out onto the room temperature baking sheet. Drizzle the peppermint oil on top, and using the bench scraper, scrape the hot candy up from the bottom and fold it over onto itself to stir it through. Once it has cooled slightly, mix in the vanilla as well. Note that the peppermint scent in the air will be strong.\r\n\r\nContinuously scrape up and stir the syrup to cool it until it becomes a pliable dough. Cut the dough in half and move one piece to the baking sheet inside the warm oven. (First, we�ll �pull� the white half of the candy cane. Then we�ll color the red half.)\r\n\r\nQuickly oil your gloved hands, as it�s now time to pull the candy. Scrape up the candy dough into one piece and, working as quickly and as continuously as you can, pull it out into a rope, double it over onto itself, and twist it together. Pull it, double it, and twist it again. Keep on going this way at a quick clip, and you�ll notice that the candy will start to take on a ribbon-y sheen. This is how the candy will turn white, so keep going until the color is pure. Embrace the upper body workout. Note that anytime the candy becomes too stiff, simply warm it up again in the oven to soften.\r\n\r\nDon�t let the candy get too hard. When it�s reached a nice white color, place it onto its baking sheet and move it to the warm oven. Re-oil your bench scraper. Take out the second tray of candy dough and pour on the red food coloring -- about a third of one of those tiny bottles for a good rich color. Use your scraper fold the candy onto itself to incorporate the color completely. Note that this side of the candy cane does not need to be pulled. Move both candy cane trays to the oven and let them warm through for about 5 minutes until pliant.\r\n\r\nOnce warm and squishy enough to work with, take both pieces of candy from the oven and roll them into logs as long as the baking sheet. Cut each log into four equal pieces. Hang on to one red piece and one white piece, moving the rest of the candy back into the oven to keep warm.\r\n\r\nOn the countertop, line the red and white logs alongside one another and begin to twist from one end, stretching as you go, making the candy canes as thin or as thick as you like. Use your oiled shears or knife to cut the length of each cane. Shape the hook of the cane, and press down on the ends to taper. Set the canes aside to cool. (Know, of course, that you could also cut into sticks, rounds, or individual peppermint sucking candy). Admire the individual quality of your handiwork.\r\n\r\nRepeat this process with the remaining 3/4 of the candy, one piece of each color at a time.\r\n\r\nAllow candy to cool until completely hard; about 15 minutes. Wrap each cane in plastic wrap to keep it from sticking. Store in an airtight jar for several months.", false, "Homemade candy canes", 11, null },
                    { 110, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Melt butter and combine with flour and corn starch.  Stir until well blended.  Combine sugar with butter mixture in sauce pan and boil for 3 minutes.  Let cool to about 120 degrees.\r\n\r\nBeat eggs and combine vanilla, cinnamon, and salt.  Blend well.\r\n\r\nComine all ingredients and blend well.  This may require a mixer since the sugar mixture will be thick.  Fold in pecans and pour into medium unbaked pastry shell.\r\n\r\nBake on cookie sheet at 350 degrees for 50 minutes.", false, "Pecan Pie", 13, null },
                    { 111, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "In a small bowl, whisk together sugar, vinegar, salt and black pepper; set aside.\r\n\r\nPeel and julienne carrot and cucumber. Chop bell pepper and green onion.\r\n\r\nAdd carrot, cucumber, bell pepper and green onion to dressing mixture. Toss vegetables to coat. Serve immediately.", false, "Asian Salad", 4, null },
                    { 112, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "1. Preheat oven to 400F. Heat oil in a small skillet over medium heat. Cook bacon until crisp, about 8 minutes. Transfer to paper towels using a slotted spoon. Reserve drippings.\r\n2. Toss sweet potato, onion, and cauliflower with reserved drippings. Season with salt and pepper. Roast on a rimmed baking sheet, tossing halfway through, until tender and caramelized, about 35 minutes.\r\n3. Meanwhile, cook pasta in a large pot of salted water until al dente. Drain, reserving 1 cup cooking water. Return pasta to pot with cooking water, and toss with grated cheese and vegetables. Stir in parsley. Sprinkle bacon over top. Garnish with shaved cheese.", false, "Pasta with roasted vegetables and bacon", 4, null },
                    { 113, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "1. Preheat oven to 325F. Coat a 4 1/4-by-13 1/2-inch fluted tart pan with a removable bottom with cooking spray. Line bottom with parchment.\r\n2. Pulse 1 3/4 cups pretzels in a food processor until powdery. Transfer 1/2 cup to a bowl; discard any remaining pretzel powder. Stir in flour and baking powder. Transfer remaining 1 1/2 cups pretzels to food processor and pulse a few times until coarsely chopped.\r\n3. Beat butter and sugar with a mixer on medium speed until pale and fluffy, about 5 minutes. Reduce speed to low, and beat in egg yolk, then pretzel-flour mixture, until combined. Mix in 1/2 cup chopped pretzels.\r\n4. Press dough evenly into pan. Top dough with 1/4 cup chopped pretzels, pressing slightly; discard any remaining pretzels.\r\n5. Bake shortbread until pale brown and firm in the center, 25 to 30 minutes. Transfer pan to a wire rack, and let shortbread cool for 1 hour. Remove shortbread from pan, and cut into 1/2-inch wide rectangles using a serrated knife.", false, "Pretzel shortbread bar", 12, null },
                    { 114, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Bring sugar and water to a boil in a small saucepan over high heat. Cook, stirring, until sugar dissolves, Let cool. Yields 1 cup.\r\n\r\nStorage: Can be refrigerated up to 1 month.", false, "Simple syrup", 8, null },
                    { 115, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Bring Nocello, whiskey, simple syrup, and lemon juice to a simmer in a medium saucepan. Divide among 4 mugs, and garnish each with a cinnamon stick.", false, "Hot and nutty whiskey sours", 5, null },
                    { 116, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "1. Preheat oven to 375F. Butter 10 mini (1 cup) pie plates or a 9x13-inch baking dish. Melt 2 tbsp butter in a small saucepan over medium heat. Add breadcrumbs, and toast, stirring occasionally, until golden brown, about 5 minutes.\r\n2. Warm milk in a medium saucepan over medium heat. Meanwhile melt remaining 6 tablespoons butter in a large high-sided skillet over medium heat. Cook until butter is bubbling. Add flour. Cook, stirring, for 1 minute.\r\n3. Gradually pour warm milk into butter mixture, whisking constantly, until mixture bubbles and thickens, about 5 minutes. Remove from heat, and stir in 3 cups cheddar, 1 cup Gruyere, 1 cup fontina, 1/2 teaspoon salt, 1/4 teaspoon black pepper, the nutmeg, paprika, and cayenne pepper.\r\n4. Bring a large pot of water to a boil. Cook pasta until al dente. Drain, and transfer past to cheese sauce. Stir to coat. Divide mixture among mini  pie plates or to baking dish. Scatter remaining cup of cheddar, 1/2 cup Gruyere, and 1/2 cup fontina over top, and sprinkle with toasted breadcrumbs. Bake until cheese is melted and pasta is warmed through, about 15 minutes. Transfer to a wire rack and let cool for 5 minutes before serving.", false, "Three cheese macaroni", 10, null },
                    { 117, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "1. Preheat oven to 350F. Make the cupcakes: line cupcake tins with baking cups. Sift flour, baking powder, cinnamon, nutmeg, and 3/4 teaspoon salt into a medium bowl. Combine milk and vanilla in a measuring cup.\r\n2. Beat butter with a mixer on medium-high speed until pale and fluffy. Reduce speed to medium, and gradually add granulated sugar in a slow, steady stream. Beat until pale and fluffy, about 3 minutes. Reduce speed to low, and add flour mixture in 3 additions, alternating with milk mixture, beginning and ending with flour.\r\n3. In a clean bowl, whisk egg whites with a mixer on medium-high speed until stiff peaks form. Fold one-third of the whites into the cupcake batter. Fold in remaining egg whites in 2 batches.\r\n4. Divide batter among baking cups, filling each halfway full. Bake until a toothpick inserted into the center of each comes out clean and the tops spring back when lightly touched, 18 to 20 minutes. Let cool completely in tins set on wire racks.\r\n5. Meanwhile, make the caramel: bring granulated sugar and water to a boil in a small high-sided saucepan, stirring, until sugar dissolves. Reduce heat to medium-high, and cook until mixture just starts to turn pale gold around edges. Remove from heat, and immediately pour caramel onto a rimmed baking sheet. Working quickly, tilt pan to spread caramel to edges to make a very thin layer. Let cool to harden.\r\n6. Make the frosting: beat cream cheese and butter with a mixer on medium-high speed until pale and fluffy. Gradually add confectioners' sugar and vanilla. Beat until creamy and spreadable.\r\n7. Frost each cupcake using an offset spatula. Twist pan to release and break caramel in order for it to resemble broken glass. Place a shard or 2 of caramel \"glass\" in the center of each cupcake. Drizzle or pipe cherry preserves where caramel has entered the cupcake.\r\n\r\nMake ahead: unfrosted cupcakes can be stored at room temperature for up to 2 days. Frosting can be refrigerated for up to 4 days. Caramel can be stored at room temperature for up to 1 day, break just before using.\r\n\r\nStorage: frosted cupcakes can be refrigerated for up to 1 day. Top with caramel shards and cherry preserves just before serving.", false, "Broken glass cupcakes", 12, null },
                    { 118, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Heat the oven to 450 degrees. Make a bouquet garni by wrapping parsley, thyme, rosemary, bay leaves, and peppercorns in a piece of cheesecloth. Tie with kitchen twine, and set aside. Arrange meat, veal bones, onion, carrots, and celery in an even layer in a heavy roasting pan. Roast, turning every 20 minutes, until the vegetables and the bones are deep brown, about 1 1/2 hours. Transfer the meat, bones, and vegetables to a large stockpot, and set aside. Pour off the fat from the roasting pan, and discard. Place the pan over high heat on the stove. Add wine, and use a wooden spoon to scrape up the brown bits; boil until the wine has reduced by half, about 5 minutes. Pour all of the liquid into the stockpot.\r\n\r\nAdd 6 quarts of cold water to the stockpot, or more if needed to cover bones. Do not add less water. Bring to a boil, then reduce to a very gentle simmer. Add the reserved bouquet garni. Liquid should just bubble up to surface. Skim the foam from the surface, and discard. Simmer over the lowest possible heat for 3 hours; a skin will form on the surface of the liquid; skim off with a slotted spoon, and discard. Repeat as needed. Add water if at any time the level drops below the bones.\r\n\r\nStrain the stock through a fine sieve into a large bowl. Discard the solids. Transfer the bowl to an ice bath, and let cool to room temperature. Transfer to airtight containers. Refrigerate for at least 8 hours, or overnight. Stock may be refrigerated for 3 days or frozen for 4 months. If storing, leave fat layer intact to seal the stock. Before using, remove the fat that has collected on the surface.", false, "Homemade beef stock", 11, null },
                    { 119, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Melt butter in a large Dutch oven or heavy pot on medium-low heat. Add onions. Spread them out in as thin a layer as possible. Sprinkle with sugar, and cook, stirring just as needed to keep onions from sticking, until they are melting and soft, golden brown, and beginning to caramelize, about 1 hour. (If doing 2 servings, cook for only 30-40 minutes.)\r\n\r\nSprinkle flour over onions, and stir to coat. Add sherry, stock, and thyme, and bring to a simmer. Cook, partially covered, for about 30 minutes, to allow the flavors to combine. Season with salt and pepper to taste.  (If doing 2 servings, cook for only 15 minutes.)\r\n\r\nMeanwhile, lightly toast bread under a broiler; set aside. Ladle hot soup into six ovenproof bowls. Arrange the bowls on a baking pan. Place 1 or 2 slices of toasted bread over each bowl of soup. Sprinkle 1/2 cup grated cheese over bread in each bowl, and place under the broiler until cheese is melted and crusty brown around the edges. Watch carefully that bread doesn't burn.  \r\n\r\n(If you don't have broiler-proof bowls, instead lightly toast the bread, then top with the cheese and broil until bubbly and browned, 4-5 minutes. Serve the soup in an ordinary bowl, topped with the bread slices.)\r\n\r\nServe immediately.", false, "French onion soup", 6, null },
                    { 120, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "In a large saucepan over medium-high heat, cook the bacon until crisp, about 3 minutes. Transfer the bacon to a piece of paper towel, and set aside. Discard all but 1 tablespoon bacon drippings from pan.\r\n\r\nAdd the garlic, onion, and carrots to saucepan. Cook vegetable mixture over medium heat until tender, about 5 minutes. Add the minced sage, and cook 1 minute more.\r\n\r\nAdd the lentils, cumin, and chicken stock; stir to combine. Simmer until lentils are cooked and falling apart, 20 to 25 minutes.\r\n\r\nTo serve, divide the hot soup among four soup plates, and garnish with the reserved bacon and additional sage.", false, "Red lentil soup with sage and bacon", 1, null },
                    { 139, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "To make the sauce, combine the wasabi powder and water in a saucepan and let bloom for 5 minutes. Add 3/4 cup ponzu, the sake and grated ginger and bring to a boil over high heat. Reduce the heat to medium-low and simmer until the sauce is reduced by half, about 10 minutes.\r\n\r\nMeanwhile, place the fish and asparagus in a large baking dish. Pour the remaining ponzu sauce and the oil over the fish and asparagus and turn to coat evenly. Let stand for 10 minutes.\r\n\r\nIn a small frying pan, toast the sesame seeds over medium heat, shaking the pan frequently, until lightly colored, 3 to 4 minutes. Immediately pour onto a plate to cool. Place a grill pan over medium heat until hot. Lift the asparagus from the marinade, place in the pan and cook, turning occasionally, until tender-crisp, about 3 minutes. Transfer the asparagus to a plate and cover with aluminum foil, shiny side down, to keep warm. Lift the fish from the marinade and place in the grill pan. Cook, turning once, until it turns opaque and just begins to flake, 2 to 3 minutes on each side.\r\n\r\nTo serve, divide the rice among 4 bowls. Top with a piece of fish and some asparagus. Pour 1/4 cup of the sauce over the fish in each bowl. Garnish each serving with the sesame oil, green onions, avocado, cucumber, pickled ginger and sesame seeds.", false, "Grilled salmon sushi rice bowl", 7, null },
                    { 140, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Preheat oven to 450F. On a rimmed baking sheet, toss cauliflower with 1/2 of the oil. Season with salt and pepper. Roast for 15-20 minutes. In a small bowl, combine remaining oil, panko, cheese, and rosemary.\r\n\r\nRemove sheet from oven. Add beans, lemon zest, and red-pepper flakes to cauliflower, sprinkle with panko mixture and roast until panko is golden brown, about 5-7 minutes.", false, "Roasted cauliflower and white beans", 14, null },
                    { 141, new DateTime(2021, 11, 29, 13, 8, 53, 562, DateTimeKind.Utc), "1. Whisk egg white, 1 tbsp potato starch and 1 teaspoon soy sauce in a large bowl until frothy. Add the shrimp and toss to coat. Refrigerate 10 minutes. Meanwhile, whisk the hoisin sauce, vinegar, and the remaining 1 tablespoon soy sauce and 2 teaspoons potato starch in a small bowl, the whisk in the chicken broth. Set aside.\r\n\r\n2. Drain the shrimp. Heat the vegetable oil in a wok or large skillet over medium-high heat, then stir-fry the scallion whites, ginger and garlic, about 30 seconds. Add the shrimp and stir-fry until almost cooked through,a bout 3 minutes. Add the cabbage and stir-fry until wilted and the shrimp are just cooked through, about 2 more minutes.\r\n\r\n3. Stir the hoisin sauce mixture, then add to the wok and simmer, stirring occasionally, 2 minutes. Stir in the scallion greens. Serve with rice, if desired.", false, "Shrimp and cabbage stir fry", 2, null },
                    { 142, new DateTime(2021, 11, 29, 13, 8, 53, 562, DateTimeKind.Utc), "Cook onion and jalapeno in olive oil 6 minutes. Puree with remaining ingredients and season with salt to taste.\r\n\r\nServe with toasted bread and vegetable sticks.", false, "Avocado feta dip", 6, null },
                    { 15, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "Whisk together the shallot, vinegar, mustard, salt, and pepper in a small bowl. Slowly whisk in the oil until emulsified.", false, "Sherry Vinaigrette", 9, null },
                    { 14, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "Heat grill to high. Brush mushroom caps on both sides with oil and season with salt and pepper. Grill, cap side down, until slightly charred, about 4 to 5 minutes. Turn the mushrooms over and continue grilling until just cooked through, about 3 to 4 minutes longer.\r\n\r\nStack the ingredients on each of 4 salad plates starting with a mushroom cap, a slice of cheese, some spinach, and a drizzle of Sherry Vinaigrette. Add another mushroom cap, more vinaigrette, spinach, and another slice of cheese. Place a third mushroom cap on top and finish by drizzling with additional vinaigrette and garnishing with chopped chives, if desired.\r\n\r\n[Sherry Vinaigrette](http://www.xanthir.com/recipes/showrecipe.php?id=18)", false, "Grilled Portobello Mushrooms Stacked with Fresh Spinach and Shaved Manchego Cheese", 7, null },
                    { 13, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "Adjust oven rack to lower-middle position; heat oven to 450 degrees.  \r\n\r\nWhisk flour, baking power, baking soda, and salt in large bowl.\r\n\r\nAdd shortening to flour mixture; break up chunks with fingertips until only pea-sized pieces remain.  Working in batches, drop butter slices into flour mixture and toss to coat; pick up each slice of butter and press between floured fingertips into flat, nickel-sized pieces.  Repeat until all butter is incorporated; toss to combine.  Freeze mixture (in bowl) until chilled, about 15 minutes.\r\n\r\nSpray 24-square-inch work surface with nonstick cooking spray; spread spray evenly across surface with kitchen towel or paper towel.  Sprinkle 1/3 cup of extra flour across sprayed area; gently spread flour across work surface with palm to form thin, even coating.  Add all but 2 tablespoons of buttermilk to flour mixture; stir briskly with fork until ball forms and no dry bits of flour are visible, adding remaining buttermilk as needed (dough will be sticky and shaggy but should clear sides of bowl).  With rubber spatula, transfer dough onto center of prepared work surface, dust surface lightly with flour, and, with floured hands, bring dough together into cohesive ball.\r\n\r\nPat dough into approximate 10-inch square; roll into 18- by 14-inch rectangle about 1/4 inch thick, dusting dough and rolling pin with flour as needed.  Using bench scraper or thin metal spatula, fold dough into thirds, brushing any excess flour from surface; lift short end of dough and fold in thirds again to form approximate 6- by 4-inch rectangle.  Rotate dough 90 degrees, dusting work surface underneath with flour; roll and fold dough again, dusting with flour as needed.\r\n\r\nRoll dough into 10-inch square about 1/2 inch thick; flip dough and cut nine 3-inch rounds with floured biscuit cutter, dipping cutter back into flour after each cut.  Carefully invert and transfer rounds to ungreased baking sheet, spaced 1 inch apart.  Gather dough scraps into ball; roll and fold once or twice until scraps form smooth dough.  Roll dough into 1/2-inch-thick round; cut 3 more 3-inch rounds and transfer to baking sheet.  Discard excess dough.\r\n\r\nBrush biscuit tops with melted butter.  Bake, without opening oven door, until tops are golden brown and crisp, 15 to 17 minutes.  Let cool on baking sheet 5 to 10 minutes before serving.", false, "Flaky Buttermilk Biscuits", 8, null },
                    { 12, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "In a small bowl, whisk together the lemon juice, garlic, salt, and oil. Set aside.   In a large bowl lightly toss the lettuce with the olives, cheese, cucumber, tomatoes, onion, oregano, and black pepper. Let sit up to 2 hours.  To serve, toss salad with dressing and place sliced chicken on top.", false, "Greek Salad", 12, null },
                    { 11, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "In a food processor with a blade attachment, cream the cheese until smooth and then add in sugar. Pulse a couple times to incorporate sugar and cocoa powder. Add in eggs and yolks pulsing a couple times again and scrape down to ensure all is smooth and uniform. With machine running, pour in melted Godiva Chocolate in a steady stream until all in, and finish by pulsing in the cr�me fraiche. Pour batter into a 10\" x 10\" baking pan and bake at 325 for 30, minutes or until custard is set and a toothpick inserted in center can be removed cleanly. The top may caramelize or brown slightly, which is not an issue. Once set, remove from oven and allow cheesecake to cool completely. Wrap the pan with plastic and reserve in cooler to set and chill completely.\r\n\r\nOnce the cheesecake is cold and firm, remove it from the pan and place in a mixer bowl with a paddle attachment. Beat the cake for a few moments to soften and smooth out the custard. Place smoothed custard into a piping bag with a plain tip and pipe into the bottom of a plastic lined half cylinder mold. Tap the mold to ensure the custard is solid and then flatten out to top. Freeze the mold to harden the custard for unmolding. Once the cake can be unmolded, remove from the pan and cut into 1�\" sections. Brush some tempered Godiva Dark Chocolate onto a strip of acetate and, while it is still fluid, smooth over the top of the molded cheesecake. Once the chocolate has cooled and completely crystallized, remove the acetate, revealing a shiny and textured chocolate finish.", false, "Godiva Dark Chocolate Cheesecake", 14, null },
                    { 10, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "Preheat the oven to 400 degrees halfway through onion cooking.\r\n\r\nSlice the onions and saute in 4 tablespoons butter over medium-low heat; the longer you cook them - as long as 35 minutes - the sweeter they will be.  Sprinkle in crushed red pepper.\r\n\r\nMelt the remaining 4 tablespoons butter.  Mix with the crushed crackers, then press the mixture into the bottom and sides of a glass pie plate to form a crust.  Prebake crust for 10 minutes.\r\n\r\nLightly beat the eggs and milk together in a small bowl.\r\n\r\nSpoon the onions into the crust, then pour the egg mixture over them.  Sprinkle with Parmesan.\r\n\r\nBake for 30-40 minutes until set and golden.", false, "Onion Pie", 13, null },
                    { 9, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "In a large soup pot, brown ground beef and onion, drain off fat.  Add remaining ingredients EXCEPT for last 3 items (canned vegetables).  Simmer on low heat until vegetables are tender, about an hour.  Add canned vegetables and simmer 5 minutes.  Remove bay leaf and serve.", false, "Old Fashion Vegetable Soup", 3, null },
                    { 8, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "Preheat the oven to 325 degrees F.\r\n\r\nIn a large Dutch oven over medium-low heat, add the bacon and cook until it renders its fat and almost becomes crispy. Remove it with a slotted spoon to a plate. Add the onions, season with salt and pepper, to taste, and cook over low heat until they are deep in color and caramelized, about 30 minutes.\r\n\r\nRemove the onions to a plate, leaving as much fat in the pot as possible. Add the vegetable oil and mix it with the bacon fat. Raise the heat to high. Season the beef liberally with salt and pepper and sear, in batches, until nicely browned on both sides.\r\n\r\nOnce the meat is browned, add the first batch of meat back to the pan along with the onions, carrots and bacon. Sprinkle in the flour and stir. Cook for 1 minute before deglazing the pan with the beer. Add the remaining ingredients and bring the mixture to a simmer. Cover the pot and put it in the oven to braise until the beef is tender, about 2 hours. Remove the pot from the oven and transfer the pot roast to a serving dish.", false, "Pot Roast Carbonnade", 4, null },
                    { 7, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "Bring a saucepan of salted water it a boil, reduce the heat, and maintain a simmer. In a bowl, stir all the ingredients together (eggs, flour, milk, salt, baking powder, and nutmeg). Place a colander over the pan, pour about1/4 of the batter into the colander, and press through the holes with a plastic spatula into the hot water. When the spatzle starts to float to the surface, cover the pan and keep covered until the spatzle appears to swell and is fluffy. Remove the dumplings and repeat the procedure with the remaining batter.\r\n\r\nIn a medium saute pan, add butter, and melt over medium heat until butter turns a light brown. Add garlic and cook until it becomes lightly colored. Add spaetzle to the pan to heat through. Add parsley, cheese, salt and pepper, to taste.", false, "Spaetzle", 7, null },
                    { 6, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "TO MAKE SHELL: Preheat oven to 300 degrees. In mixer bowl, beat egg whites until foamy. Beat in salt and cream of tartar and beat until soft peaks form. Add sugar, a tablespoon at a time, beating after each addition. Continue until very stiff peaks form. Fold in nuts and vanilla. Lightly butter a metal 8-inch pie plate. (Do NOT use glass.) Spoon meringue into pan lightly, building up the edges to come at least 1/2 inch above the side of the pan. Bake in preheated 300 degree oven for 35 to 40 minutes until light brown. Cool completely before adding filling. TO MAKE FILLING: Melt chocolate and water in a pan over hot, but not boiling, water, stirring occasionally, to blend. Add vanilla and chocolate mixture (cooled) to whipped cream and pile into meringue shell, swirling top with spatula. Be sure to cool the chocolate mixture before adding to the whipped cream. If it is too warm, the mixture will thin out. If this happens, chill until it is thick enough to put in shell.", false, "Godiva Angel Pie", 2, null },
                    { 5, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "Preheat oven to 200F.\r\n\r\nIn a large bowl, whisk together the flour, sugar, baking powder, salt, and pepper. In a small bowl, lightly whisk the egg yolks, then whisk in the milk, 2 tablespoons of melted butter and lemon juice. Add the yolk mixture to the flour mixture and, using a wooden spoon, stir until well blended. The batter will be lumpy.\r\n\r\nIn a clean bowl, using an electric mixer on high speed, beat the egg whites until stiff, but not dry, peaks form. Using a silicone spatula, fold about one-third of the egg whites into the batter to lighten it, then fold in the rest just until no white streaks remain. Stir in fresh dill.\r\n\r\nBrush the wells of the ebelskiver pan with some of the remaining melted butter and place over medium heat. When the butter starts to bubble, add about 1 tablespoon batter to each well. Working quickly, carefully spoon about 1/2 teaspoon of the smoked salmon into the center of each pancake, then spoon about 1/2 teaspoon of the cream cheese on top. Top each with another 1 tablespoon batter. (Alternatively, gently mix the cream cheese and salmon together. Spoon about 1 teaspoon into the center of each pancake)\r\n\r\nCook until the bottoms of the pancakes are lightly browned and crisp, 3-5 minutes. Use 2 short wooden skewers to turn all the  pancakes and cook until lightly browned on the second side, about 3 minutes longer.\r\n\r\nTransfer the finished pancakes to a platter and keep warm  in the oven while you repeat to make 2 more batches. Serve right away.", false, "Smoked Salmon Ebelskivers", 9, null },
                    { 4, new DateTime(2021, 11, 29, 13, 8, 53, 556, DateTimeKind.Utc), "Preheat oven to 350F. In a large saucepan, heat the brown sugar, golden syrup and butter to the boiling point. Stirring constantly and scraping back any foam that clings to the side of the pan, let this mixture boil for about 1 minute. Remove from the heat and let cool while, in a separate bowl, you beat the eggs until creamy. \r\n\r\nWhen the boiled syrup has cooled, beat in the eggs, salt and pecans. Pour into the unbaked pie shell and bake for about 50 minutes.\r\n\r\nNotes:\r\n\r\n* A little cream (about 1/4 to 1/2 cup) mixed into a pecan pie filling before baking gives it a richer, lighter texture. \r\n\r\n* For a sweeter, lighter pie: add more sugar and use fewer pecans; for a denser, less sweet pie: add more pecans and use less sugar. \r\n\r\n* The buttery flavour and the lard-induced flakiness of a butter and lard crust make it the perfect one for a perfect pecan pie. And a Southern pecan pie authority I know suggests that you roll out the dough a little thicker than usual; a thick, richly shortened crust provides an appetizing balance to the sweetness of the filling. ", false, "John Thorne's Pecan Pie", 8, null },
                    { 3, new DateTime(2021, 11, 29, 13, 8, 53, 556, DateTimeKind.Utc), "Combine tomatoes, juice/and or possibly stock in saucepan. Simmer 30 min. Puree, along with the basil leaves, in small batches, in blender or food processor or use an immersion blender in the pan.\r\n\r\nReturn to saucepan and add in cream and butter, while stirring over low heat. Garnish with basil leaves and serve with your favorite bread.", false, "Tomato Basil Soup (La Madeleine copycat)", 9, null },
                    { 2, new DateTime(2021, 11, 29, 13, 8, 53, 556, DateTimeKind.Utc), "Wash strawberries and cut the tops off. Let strawberries drain.  Mix together heavy whipping cream, powdered sugar, and the brandy. Beat with a mixer till this becomes thick.  Place strawberries into glasses and spoon over the sauce.\r\n", false, "Strawberries Romanov (La Madeleine copycat)", 2, null },
                    { 1, new DateTime(2021, 11, 29, 13, 8, 53, 556, DateTimeKind.Utc), "Preheat the oven to 425 degrees F.\r\n\r\nDefrost shrimp by putting in cold water, drain. Place the shrimp in serving dish (9x13 or 2 quart casserole) and toss gently with the olive oil, wine, 1 teaspoons salt, and 1 teaspoon pepper. Allow to sit at room temperature while you make the butter and garlic mixture.\r\n\r\nIn a small bowl, mash the softened butter with the garlic, shallots, parsley, rosemary, red pepper flakes, lemon zest, lemon juice, egg yolk, panko, 1/2 teaspoon salt, and 1/4 teaspoon of pepper until combined.\r\n\r\nSpread the butter mixture evenly over the shrimp. Bake for 10 to 12 minutes until hot and bubbly. If you like the top browned, place under a broiler for 1-3 minutes (keep an eye on it). Serve with lemon wedges and French bread.\r\n\r\nNote: if using fresh shrimp, arrange for presentation. Starting from the outer edge of a 14-inch oval gratin dish, arrange the shrimp in a single layer cut side down with the tails curling up and towards the center of the dish. Pour the remaining marinade over the shrimp. ", false, "Baked Shrimp Scampi", 3, null },
                    { 16, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "Puree the plum tomato, sun-dried tomatoes, vinegar, garlic, oregano, a basil leaves and parmesan in a blender, drizzling in the sun-dried tomato oil until smooth. Add 2 to 3 tablespoons water, if needed to make a pour-able dressing; season with salt and pepper.\r\n\r\nHeat the olive oil in a large skillet over medium-high heat. Add the breadcrumbs, season with salt and pepper and cook, stirring occasionally, until golden, about 2 minutes. Add the remaining parmesan and the parsley and cook until toasted, about 1 more minute.\r\n\r\nToss the salad greens, mozzarella, and remaining basil in a large bowl. Toss with the dressing, then sprinkle with the breadcrumb mixture.", false, "Margherita Salad", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "RecipeCategory_Id", "UserId" },
                values: new object[,]
                {
                    { 105, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "In a medium bowl, whisk together the egg yolk, lemon juice, garlic, Worcestershire, pepper flakes, mustard, and anchovies. Slowly whisk in the oils to emulsify. Season, to taste, with salt and pepper.", false, "Caesar Salad Dressing", 3, null },
                    { 17, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "In small bowl, whisk together dressing ingredients.\r\n\r\nChop up additional ingredients bite size and add to a medium bowl.\r\n\r\nCombine dressing and all ingredients in a large bowl, toss, and serve.\r\n\r\nIncludes recipe for [basil-lime vinaigrette](http://www.xanthir.com/recipes/showrecipe.php?id=id6).\r\n\r\nAlternate dressing (for 2 servings):\r\n1/2 lemon, juiced; 1 tbsp apple cider vinegar; 2 tbsp olive oil; 2 tablespoons cilantro, chopped", false, "Mexican Ensalada", 8, null },
                    { 19, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "Combine all ingredients in blender. Blend until smooth.", false, "Sweet Almond Date Smoothie", 10, null },
                    { 143, new DateTime(2021, 11, 29, 13, 8, 53, 562, DateTimeKind.Utc), "Preheat oven to 450 degrees. Line a baking sheet with aluminum foil; set aside. In a food processor, combine bread, parsley, and oil; season with salt and pepper. Pulse until coarse crumbs form.\r\n\r\nPlace salmon on prepared sheet; season with salt and pepper. Spread top of fillets with Dijon; top with crumb mixture, pressing gently to adhere. Roast until salmon is opaque throughout, 11 to 13 minutes.\r\n\r\nMeanwhile, in a large bowl, combine lemon juice and remaining oil; season with salt and pepper. Add spinach and onion; toss to combine. Serve salmon with spinach salad.", false, "Herb crusted salmon with spinach salad", 10, null },
                    { 144, new DateTime(2021, 11, 29, 13, 8, 53, 562, DateTimeKind.Utc), "1. For filling, combine chocolate hazelnut spread and liqueur in Stainless (4-qt./4-L) \r\nMixing Bowl; beat on medium speed of electric mixer until well blended. Gradually add \r\ncream; increase speed to medium-high and continue beating just until very soft peaks \r\nform (do not overbeat).  \r\n2. For cake, arrange four and a half of the crackers in a single layer in Square Baking Pan; \r\ntop with 1 cup (250 mL) of the hazelnut filling. Spread filling to edges with Small \r\nSpreader; repeat layers three more times, ending with all of the remaining filling. (There \r\nwill be more filling on top than in the inner layers.) Cover and refrigerate at least 8 hours \r\nor overnight.  \r\n3. When ready to serve, prepare hazelnut cream. Beat cream on medium-high speed of \r\nmixer in Stainless (2-qt./2-L) Mixing Bowl until soft peaks form. Add liqueur and \r\npowdered sugar; continue beating until stiff peaks form.  \r\n4. Sprinkle cake with cocoa powder using Flour/Sugar Shaker; cut into servings. Top each \r\nserving with hazelnut cream and garnish with hazelnuts and Chocolate Flowers, if desired.\r\n\r\nCook�s Tips: For Chocolate Flowers, place 1/2 cup (125 mL) semi-sweet chocolate morsels into \r\nSmall Micro-Cooker�; microwave, uncovered, on HIGH 1 minute or until mostly melted, stirring\r\nevery 20 seconds. Pour melted chocolate into resealable plastic bag; twist to secure. Cut a small \r\ntip off corner of bag to allow chocolate to flow through. For three-dimensional design, cut 12 \r\npieces of Parchment Paper into 21/2 x 3-in. (6 x 7.5-cm) squares; fold in half. Fit parchment in \r\nwells of Muffin Pan. Pipe chocolate flower on Parchment Paper; refrigerate 15 minutes or until \r\nset. ", false, "Chocolate-Hazelnut Icebox Cake", 6, null },
                    { 145, new DateTime(2021, 11, 29, 13, 8, 53, 562, DateTimeKind.Utc), "1. Cut leeks in half lengthwise; thinly slice crosswise. Rinse in a colander to remove dirt.\r\n  \r\n2. Melt butter in large pot over medium heat. Add leeks, onion, pressed garlic and \r\npaprika to pot; cook, uncovered, 3-4 minutes or until vegetables are softened, stirring \r\noccasionally. Add potatoes; cook 2 minutes, stirring constantly. Add stock; cook, covered, 12-15 \r\nminutes or until potatoes are fork-tender, stirring occasionally. Add beans; cook 1-2 minutes or \r\nuntil heated through. Remove pot from heat; cool 5 minutes.\r\n\r\n3. Blend soup until smooth.\r\n\r\n4. Stir in milk. Cook, uncovered, over medium heat 2-3 minutes or until simmering. Stir in cheese, salt and black pepper. Cook 2-3 minutes or until cheese is melted. Garnish each serving with sour cream, chives and additional paprika, if desired. ", false, "Smoky Yukon Gold Potato Chowder", 1, null },
                    { 146, new DateTime(2021, 11, 29, 13, 8, 53, 562, DateTimeKind.Utc), "Cook pasta according to package directions, omitting salt and oil.  Carefully remove 1/2 cup (for 4 servings) of the cooking water for later use.  Drain pasta and set aside.\r\n\r\nMeanwhile, combine bread crumbs, oil and pressed garlic cloves in microwave-safe bowl.  Microwave, uncovered, on high 1-2 minutes or until light golden brown, stirring every 30 seconds.  Stir in parsley; set aside.\r\n\r\nCut cauliflower into small florets and onion into 1/2-in wedges.  Spritz medium skillet with olive oil.  Heat over medium-high heat until hot, then add cauliflower and onion, and season with salt. Cook 3-4 minutes or until cauliflower is golden brown on all sides, stirring occasionally.\r\n\r\nStir in remaining 1 tbsp oil, remaining pressed garlic cloves, wine, and pepper flakes; bring to a boil.  Cook 2-3 minutes or until wine is reduced by half.  \r\n\r\nAdd pasta, reserved cooking water, cheeses, black pepper, and remaining 1tsp salt; mix well. Remove skillet from heat, add spinach and tomatoes, stir until spinach wilts.  Cover and let stand 10 minutes or until spinach is wilted and sauce is thickened, stirring once halfway through.  Top each serving with bread crumb mixture and additional parmesan cheese.", false, "Orecchiette with roasted cauliflower", 12, null },
                    { 147, new DateTime(2021, 11, 29, 13, 8, 53, 562, DateTimeKind.Utc), "In a mixing bowl, combine all ingredients together. Toss thoroughly. Let stand 15 minutes before serving. Yields 2 cups.", false, "Salsa fresca", 5, null },
                    { 148, new DateTime(2021, 11, 29, 13, 8, 53, 562, DateTimeKind.Utc), "Mix all ingredients, toss with dressing.", false, "Black bean salad with chipotle honey dressing", 5, null },
                    { 149, new DateTime(2021, 11, 29, 13, 8, 53, 562, DateTimeKind.Utc), "Cook pasta. Meanwhile, toss chopped asparagus with oil, salt, pepper, and whatever other seasoning you desire. Roast at 450F for 8 minutes.\r\n\r\nWhen pasta is done, drain it, reserving some pasta water. Return it to the pot, and add butter, parmesan, and enough pasta water to make a thin sauce. Also add asparagus.\r\n\r\nFry eggs over easy. Dish the pasta, and top with egg and a little more parmesan.", false, "Linguine with asparagus and egg", 3, null },
                    { 150, new DateTime(2021, 11, 29, 13, 8, 53, 562, DateTimeKind.Utc), "1. Preheat oven to 400F. With a pasry brush, brush bottom and sides of a 9x13-inch baking dish with oil. In a large skillet, heat 1/4 cup (for 8 servings) water over medium-high. Working in batches, add spinach and cook, tossing, until completely wilted, about 8 minutes. Transfer to a colander to drain, pressing out as much water as possible. Return skillet to heat and add 1 tablespoon oil (for 8 servings). Add leeks and cook until softened, about 8 minutes. Stir in garlic, season with salt and pepper, and cook until fragrant about 1 minute. Stir in nutmeg. Transfer spinach and leek mixture to a food processor; pulse until coarsely chopped.\r\n\r\n2. Cut phyllo sheets to fit baking dish. Place 1 sheet in dish (keeping remaining sheets covered with a damp towel) and brush lightly with oil. Stack 7 more phyllo sheets on top, brushing each with oil. Spread half the spinach mixture over phyllo and evenly sprinkle the feta on top. Add 8 more phyllo sheets, brushing each with oil. Spread with remaining spinach mixture and feta. Top with remaining 8 phyllo sheets, brushing each with oil.\r\n\r\n3. Bake until phyllo is golden and crisp on top, about 30 minutes. Let cool 15 minutes before cutting  into squares. Serve warm or at room temperature.", false, "Spanakopita", 4, null },
                    { 26, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "Heat oil in a small non-stick skillet. Once hot, add veggies and saute until soft. Meanwhile, beat greek seasoning and feta into eggs. Once veggies are at desired doneness, add egg mixture to skillet and gently stir until cooked. Serve immediately.", false, "Breakfast Mediterranean Scramble", 14, null },
                    { 25, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "Combine all ingredients in a bowl, toss, and serve.\r\n\r\nUse whatever vinaigrette you want.", false, "Popeye's Muscle Salad", 9, null },
                    { 24, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "1. Lightly warm berries and maple syrup in a saucepan\r\n2. Pour over pancakes/dessert as desired", false, "Berry Sauce", 10, null },
                    { 23, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "1. Place all the salad ingredients, except the sesame seeds, into a large bowl or platter.\r\n\r\n2. Whisk together all the dressing ingredients in a small bowl. Drizzle over the salad and toss lightly to coat.\r\n\r\n3. Sprinkle with sesame seeds and serve.", false, "Extreme Green Salad", 8, null },
                    { 22, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "1. In small bowl, whisk olive oil, vinegar, and lemon juice.\r\n2. Combine salad ingredients in a medium bowl. Pour dressing over salad. Slice eggs and place on top.", false, "Apple Carrot Salad", 13, null },
                    { 21, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "Combine all ingredients in blender. Blend until smooth.", false, "The Shake", 6, null },
                    { 20, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "Combine olive oil, vinegar, mustard, salt and pepper to taste. Toss with other ingredients in a bowl and serve.", false, "Super Protein Salad", 11, null },
                    { 18, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "1. Place all ingredients in a bowl with a flat bottom and mash it with a potato masher.  Alternatively, you can mix everything briefly in a food processor.\r\n2. Stir well and keep refrigerated. This dish will brown on the areas exposed to air within a few hours, so serve it shortly after making it or just stir again before serving.", false, "Guacamole", 13, null },
                    { 104, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "In a large skillet, heat oil and chile over medium-high. Add lemon and honey and cook, stirring until lemon begins to break down, about 2 minutes. Add kale and cook, stirring, until just wilted, about 3 minutes. Add scallions, season with salt, and cook 1 minutes. Serve warm or at room temperature.", false, "Spicy sauteed kale with lemon", 12, null },
                    { 103, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "1. Put the chocolate in a microwave-safe bowl; microwave in 30-second intervals, stirring, until melted, about 2 minutes. Blend the chestnut puree, almond extract, salt and 1 cup confectioners' sugar in a food processor until smooth. Transfer to a bowl and fold in half of the melted chocolate.\r\n\r\n2. Beat the cream and the remaining 2 tablespoons confectioners' sugar with a mixer until soft peaks form. Reserve 1/2 cup for topping. Fold one-quarter of the remaining whipped cream into the chestnut mixture, then fold in the rest. Chill up to 8 hours.\r\n\r\n3. Divide the mousse among dessert glasses. Top with the reserved whipped cream. Remelt the remaining chocolate in the microwave, if necessary, then drizzle on top.", false, "Chocolate chestnut mousse", 5, null },
                    { 102, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "1. Make the ragu: Soak the porcini mushrooms in 1 cup hot water until soft, about 15 minutes. Strain through a fine-mesh sieve over a bowl. Chop; reserve the liquid.\r\n\r\n2. Meanwhile, heat the olive oil in a pot over medium heat. Add the onion, carrot and celery and cook until soft, 5 minutes. Stir in the garlic and tomato paste and cook, stirring, 2 more minutes. Add the portobello and shiitake mushrooms, 1 teaspoon salt and 1/2 teaspoon pepper; cook, stirring until the mushrooms are soft, 5 more minutes.\r\n\r\n3. Add the porcini mushrooms, cook 2 minutes. Add the reserved porcini liquid, bring to a boil and cook until reduced slightly, about 3 minutes. Add the tomatoes and their juice, 2 cups water and the bay leaves; bring to a boil, stirring occasionally. Reduce the heat to medium low, add the parsley and 1 teaspoon salt and simmer, stirring a few times, until thick, about 1 hour, 30 minutes. Discard the bay leaves. (you can make the ragu up to 1 day ahead; let cool, then cover and chill. Reheat before using.)\r\n\r\n4. Make the lasagna filling: Mix the parmesan, mozzarella and asiago; set 1 1/2 cups of the cheese mixture aside. Combine the remaining cheese mixture in a large bowl with the ricotta, eggs, spinach, nutmeg and 1/2 teaspoon salt.\r\n\r\n5. Preheat the oven to 375F. Bring a pot of water to a boil and add a generous amount of salt. Add the noodles and cook as the label directs. Drain and rinse under cold water; shake off the excess water.\r\n\r\n6. Spread 1 cup of the ragu in a 9-by-13-inch baking dish. Add a layer of noodles, then half of the spinach mixture and 2 cups ragu. Repeat with another layer of noodles, spinach mixture and ragu. Top with the remaining noodles and ragu and sprinkle with the reserved cheese. Cover with foil, place on a baking sheet and bake 50 minutes. Uncover and bake until golden, about 25 more minutes. Let rest before serving.", false, "Spinach lasagna with mushroom ragu", 14, null },
                    { 49, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "For croutons: Toss bread with olive oil, almonds, parmesan, lemon zest, salt and pepper. Spread on a baking sheet and bake at 425, about 8 minutes.\r\n\r\nFor dressing: Meanwhile, process almonds, parmesan, anchovies, and garlic in a food processor until finely chopped. Add dijon and lemon juice, pulse motor until just combined. With motor running, drizzle in olive oil until thoroughly combined. Season with salt and pepper.\r\n\r\nToss dressing with lettuce and croutons.", false, "Almond Caesar salad with croutons", 2, null },
                    { 50, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "In a small saucepan gently melt the butter for a minute with the orange zest and juice, the sugar, cinnamon, grated nutmeg and cloves. Stir until the butter foams, then stir in the apples. Place a lid on top and cook for 15-20 minutes on a medium to low heat until you have a soft, sludgy sauce. Taste and add a bit more sugar if you want. Serve warm or room temperature.", false, "Spiced Apple Sauce", 8, null },
                    { 51, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "To prepare your meat, put the escalopes on to a chopping board, put a piece of wax paper on top and bat the meat with the bottom of a saucepan to flatten in a little - you want to get it to about 1/4 inch thick.\r\n\r\nTo breadcrumb your meat, get yourself four large plates and lay them out in a line in the front of you. From left to right, you want to have your slat and pepper in one, flour in the second, beaten egg in the third and your fine breadcrumbs in the fourth. It's very simple...season the pieces of meat and dip them into the flour, shaking off any excess, then put them into the egg, dripping off any excess, and into the breadcrumbs, patting them over both sides and pressing down quite firmly. Gently shake off any excess and put the meat on a board or clean plate ready to be cooked.\r\n\r\nHeat a heavy frying pan, add a couple of good glugs of olive oil and, when it's good and hot, put both pieces of pork into the pan. Cook for 2 minutes or so, then carefully start to shake and agitate the pan to cover them in the hot oil. Turn the pork over and continue to cook for a couple of minutes until both sides are crisp and golden brown. Remove to a tray line with paper towels and season with salt and pepper. Put a schnitzel on to each of your serving plates. Put a little pile of cornichon matchsticks and some watercress leaves on top and serve with a big lob of apple sauce, a squeeze of lemon juice and a drizzle of extra virgin olive oil.", false, "Schnitzel", 1, null },
                    { 52, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "To marinate the chicken: In a non-reactive dish, combine the lemon juice, olive oil, oregano, salt, and pepper and mix together. Add the chicken breasts to the dish and rub both sides in the mixture. Cover the dish with plastic wrap and let marinate in the refrigerator for at least 30 minutes and up to 4 hours.\r\n\r\nTo cook the chicken: Heat a nonstick skillet or grill pan over high heat. Add the chicken breasts and cook, turning once, until well browned, about 4 to 5 minutes on each side or until cooked through. Let the chicken rest on a cutting board for a few minutes before slicing it into thin strips.", false, "Oregano Marinated Chicken", 5, null },
                    { 53, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "In a small pot, heat oil over medium. Add onion and garlic and cook until onion is soft and garlic is fragrant, 3 minutes. Add cumin and cook until fragrant, 1 minute. Add beans, water, salt, and pepper, and simmer until beans are heated through, 3 minutes. Mash in pan with wooden spoon.\r\n\r\nSeason to taste with salt and pepper if needed. Serve with tortillas, cheese, avocado, lettuce, and jalapenos.", false, "Black bean and cheese tacos", 3, null },
                    { 54, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Mix the first five ingredients in a large bowl.\r\nIn a second bowl, beat dressing ingredients together gently until smooth.\r\nToss the salad with the dressing approximately 10 minutes before serving to allow flavors to meld. Serve on chilled salad dishes.", false, "Joan's Broccoli Madness", 4, null },
                    { 55, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "In a large frying pan over medium heat, saute the garlic in the olive oil until fragrant, about 1 minute. Stir in the red pepper flakes, basil, oregano, and tomatoes and bring to a simmer. Reduce the heat to low and simmer until thickened, about 20 minutes. Season to taste.\r\n\r\nMakes about 2 1/2 cups (20 fl oz/625mL)", false, "Marinara Sauce", 14, null },
                    { 56, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Combine the olive oil, onion, garlic, celery, tomatoes, sugar, and salt in a saucepan. Cook over medium heat, stirring occasionally, until the vegetables are tender, about 25 minutes. Puree until smooth (or desired consistency), or transfer to a regular blender in batches and puree. Pour back into saucepan and add milk and basil. Add salt and pepper to taste. For vegans or non-creamy soup, thin with water if needed.", false, "Creamy tomato soup", 11, null },
                    { 57, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Combine all three cheeses in a bowl. Divide evenly among 4 bread slices and top with the remaining bread. Heat 1 tablespoon butter in a large skillet or griddle over medium heat. Cook the sandwiches in batches, adding the remaining butter as needed, until the cheese melts and the bread is golden, 3-4 minutes per side. Serve the sandwiches with the soup.", false, "Triple Grilled Cheese", 5, null },
                    { 58, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Preheat the oven to 200 degrees F.\r\n\r\nCut the tofu in half horizontally and lay between layers of paper towels. Place on a plate, top with another plate, and place a weight on top (a 14-ounce can of vegetables works well). Let stand 20 minutes. After 20 minutes, cut the tofu into 1/4-inch cubes and place in a large mixing bowl. Add the carrots, cabbage, red pepper, scallions, ginger, cilantro, soy sauce, hoisin, sesame oil, egg, salt, and pepper. Lightly stir to combine.\r\n\r\nTo form the dumplings, remove 1 wonton wrapper from the package, covering the others with a damp cloth. Brush the edges of the wrapper lightly with water. Place 1/2 rounded teaspoon of the tofu mixture in the center of the wrapper. Shape as desired. Set on a sheet pan and cover with a damp cloth. Repeat procedure until all of the filling is gone.\r\n\r\nUsing a steaming apparatus of your choice, bring 1/4 to 1/2-inch of water to a simmer over medium heat. Spray the steamer's surface lightly with the non-stick vegetable spray to prevent sticking. Place as many dumplings as will fit into a steamer, without touching each other. Cover and steam for 10 to 12 minutes over medium heat. Remove the dumplings from the steamer to a heatproof platter and place in oven to keep warm. Repeat until all dumplings are cooked.\r\n\r\nTo make dipping sauce, whisk together ingredients in a small bowl.", false, "Vegetarian Steamed Dumplings", 4, null },
                    { 59, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. In a large pot of boiling salted water, cook asparagus until crisp-tender, about 3 minutes. With a slotted spoon or mesh strainer, transfer asparagus to a colander and rinse under cool water to stop the cooking. Transfer asparagus to a medium bowl. Return water to a boil; add shrimp and cook until pink and opaque throughout, about 2 minutes. Transfer shrimp to bowl with asparagus. Return water to a boil; add noodles and cook according to package instructions. Drain noodles and rinse under cool water.\r\n\r\n2. Meanwhile, in a small bowl, whisk together soy sauce oil, vinegar, and sugar. Divide noodles among four bowls and drizzle with dressing. Top with asparagus and shrimp and sprinkle with scallions and basil.", false, "Soba salad with asparagus and shrimp", 2, null },
                    { 60, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. Drain tofu; cut into 3/4-inch cubes. Carefully press cubes between paper towels to remove as much water as possible.\r\n2. Heat oil in 12-inch skillet over medium heat. Cook tofu in oil 6 to 8 minutes, turning frequently, until light golden brown. Remove tofu from skillet; set aside.\r\n3. Add sweet potato and garlic to skillet. Cook 2 to 3 minutes, stirring occasionally, just until sweet potato begins to brown. Stir in broth, rice, Worcestershire sauce and red pepper. Heat to boiling; reduce heat. Cover and simmer 10 minutes.\r\n4. Stir in beans. Cover and cook 8 to 10 minutes, stirring occasionally, until rice is tender and liquid is absorbed. Stir in tofu and onions. Cook 1 to 2 minutes or until heated through.", false, "Tofu and Sweet Potato Jambalaya", 1, null },
                    { 61, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "In a 4-quart stockpot on medium heat, saute the onions and garlic with the olive oil, oregano, salt, and pepper until the onions are translucent, 10 to 15 minutes. Add the carrots, potatoes, 1/2 pound of split peas, and chicken stock. Bring to a boil, then simmer uncovered for 40 minutes. Skim off the foam while cooking. Add the remaining split peas and continue to simmer for another 40 minutes, or until all the peas are soft. Stir frequently to keep the solids from burning on the bottom. Taste for salt and pepper. Serve hot.", false, "Parker's split pea soup", 9, null },
                    { 62, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Heat the olive oil in a large pot over medium-high heat. Add the onion and saute, stirring frequently with a wooden spoon for 2 minutes. Add the mushrooms and cook until tender and slightly brown, about 8 minutes (add a splash more oil if necessary). Add the garlic and cook for 2 minutes more. \r\n\r\nAdd the rice and stir well, about 30 seconds. Add the wine and simmer, stirring constantly until the liquid is absorbed, 2 to 3 minutes. Add the stock, reduce the heat to medium, and cook, stirring occasionally, until the stock is absorbed, the rice is just tender, and the risotto is creamy. The total cooking time is 20 to 25 minutes.\r\n\r\nStir in 1/4 cup cheese, the thyme, and butter. If the rice appears dry, add up to 1/4 cup water to loosen the risotto slightly. Season with salt and pepper to taste.\r\n\r\nDivide the risotto between 2 large bowls and drizzle with truffle oil, if desired. Sprinkle with the remaining cheese and the chives.", false, "Wild Mushroom Risotto", 8, null },
                    { 63, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. Make the relish: preheat the oven to 350. Spread the walnuts on a baking sheet and bake until toasted 7 to 10 minutes. Let cool, then finely chop and transfer to a bowl. Add the cayenne, lemon juice, honey, roasted red pepper, walnut oil, olive oil and parsley. Add salt and black pepper to taste and toss to combine. (The relish can be made up to 1 day ahead; cover and refrigerate.)\r\n\r\n2. Make the salmon: Raise the oven temperature to 425. Combine the remaining olive oil and parsley, the chives, lemon zest, salt and black pepper to taste in a bowl. Rub the herb mixture *all* over the salmon. Lay skin-side down in a baking dish and roast until just cooking through, 12 to 14 minutes (for 3 lbs). Let rest 5 minutes, then transfer to a platter and top with the relish.", false, "Roasted Salmon with Walnut-Pepper Relish", 11, null },
                    { 48, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Put a baking sheet in the oven and preheat to 450.\r\n\r\nCut potatoes lengthwise into eighths. Toss with olive oil, tomatoes, rosemary, garlic cloves, salt and pepper. Put cut-side down on the hot baking sheet and roast 15 minutes. Flip the mixture and roast 10 more minutes.", false, "Roasted potatoes and tomatoes", 8, null },
                    { 64, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. Mix rice with 1 tbsp lemon juice while warm.\r\n\r\n2. Combine rice and chickpeas in a bowl. Stir in lemon zest, remaining juice, and oil. Let cool.\r\n\r\n3. Stir in cheese, tomatoes, mint, and onion. Season with salt. Refrigerate until ready to serve.\r\n\r\nCan be refrigerated for up to 2 days.", false, "Brown rice, chickpea, feta, and mint salad", 4, null },
                    { 47, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Cook pancetta in a skilled with olive oil until crisp.  Remove with slotted spoon.\r\n\r\nMeanwhile, bring 1 quart of water to a boil. Add 1 tbsp salt and orzo. Cook about 5 minutes or until al dente.\r\n\r\nAdd frozen peas and water to the skillet; simmer until tender (about 5 minutes). Drain and return to skillet.\r\n\r\nStir in pesto, orzo, pancetta, and parmesan, and heat through.", false, "Pesto Orzo with Peas", 12, null },
                    { 45, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "Slice the beans on a diagonal into roughly 1/8-inch pieces. If you are using a food processor, do them a handful at a time. Either way, the result should be tiny, angular zeroes.\r\n\r\nHeat the olive oil in a large skillet over medium-high heat. Add the beans and stir until coated with oil, then add the water. Cover and cook 2 or 3 minutes, until the beans are brightly colored and tender; give the pan a good shake midway through to ensure even cooking. Remove from the heat and stir in the zests and half of the chives. Season to taste with salt and pepper and serve garnished with the remaining chives.", false, "Shredded Green Beans", 14, null },
                    { 30, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "Preheat the oven to 400 degrees F.\r\n\r\nHeat a large, well-seasoned cast iron skillet over high heat until very hot, 5 to 7 minutes.\r\n\r\nMeanwhile, pat the steaks dry with a paper towel and brush them lightly with vegetable oil. Combine the fleur de sel and cracked pepper on a plate and roll the steaks in the mixture, pressing lightly to evenly coat all sides.\r\n\r\nWhen the skillet is ready, add the steaks and sear them evenly on all sides for about 2 minutes per side, for a total of 10 minutes.\r\n\r\nTop each steak with a tablespoon of butter, if using, and place the skillet in the oven. Cook the steaks until they reach 120 degrees F for rare or 125 degrees F for medium-rare on an instant-read thermometer. (To test the steaks, insert the thermometer sideways to be sure you're actually testing the middle of the steak.)\r\n\r\nRemove the steaks to a serving platter, cover tightly with aluminum foil and allow to rest at room temperature for 10 minutes. Serve hot with [Roquefort Cheese Sauce](http://www.xanthir.com/recipes/showrecipe.php?id=62) on the side.", false, "Steakhouse steaks", 11, null }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "RecipeCategory_Id", "UserId" },
                values: new object[,]
                {
                    { 31, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "In a large pot of boiling, salted water cook the pasta to al dente and drain. Return to the pot and melt in the butter. Toss to coat.\r\n\r\nWhisk together the eggs, milk, hot sauce, salt, pepper, and mustard. Stir into the pasta and add the cheese. Over low heat continue to stir for 3 minutes or until creamy.\r\n\r\n(This recipe originally called for 6oz milk.  It is reduced as an experiment.)", false, "Stove top mac and cheese", 8, null },
                    { 32, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "Heat oven to 250. Place butter in large roasting pan and melt in the oven. Mix together cereals, nuts, pretzels and bagel chips in a large bowl. Remove pan from oven and mix seasonings into the melted butter. Add cereal mix and stir well to coat with seasoned butter. Place in the oven and bake for 1 hour, stirring every 15 minutes. Spread mix out to cool before storing.", false, "The Original Chex Party Mix", 14, null },
                    { 33, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "Sift flour and semolina into a medium bow.  Mix in salt.  Add eggs and olive oil, and beginning in the center, mix with two fingers in a circular motion until flour is combined with eggs.  Do not overmix.  Remove dough from bowl and gather into a ball.  On a lightly-floured board, knead gently with the heels of your hands, folding dough over onto itself until it forms a smooth mass.  Pat into a ball, flatten slightly, wrap in waxed paper or plastic wrap, and refrigerate for 30 minutes or as long as overnight.\r\n\r\nWork on a lightly floured surface.  Keep the dough lightly dusted with flour.  Roll dough into a sheet about 1/16-inch thick.  Gently roll dough up into a cylinder.  With a slicing knife, cut crosswise in 1/4-inch slices.  Dust dough with semolina and unwrap noodles.  Cover with a tea towel until ready to cook.  (The past may be made an hour ahead of time or frozen for up to 1 month.  Defrost in refrigerator.)  Fresh pasta will cook, in boiling salted water, in about 2-3 minutes.", false, "Handmade Pasta", 7, null },
                    { 34, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "Combine all ingredients thoroughly.", false, "Emeril Essence Creole Seasoning", 6, null },
                    { 35, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "In a large (6qt), heavy pot, heat the oil over medium-high heat. Add the onions, bell peppers, garlic, and serrano peppers, and cook, stirring, until soft, about 3 minutes. \r\n\r\nAdd the zucchini and mushrooms, and cook, stirring, until soft and the vegetables give off their liquid and start to brown around the edges, about 6 minutes. Add the chili powder, cumin, salt and cayenne, and cook, stirring, until fragrant, about 30 seconds. \r\n\r\nAdd the tomatoes and stir well. Add the beans, tomato sauce, and vegetable stock, stir well, and bring to a boil. Reduce the heat to medium-low and simmer, stirring occasionally, for about 20 minutes.\r\n\r\nRemove from the heat and stir in the cilantro and lime juice. Adjust the seasoning, to taste.\r\n\r\nTo serve, place 1/4 cup of brown rice in the bottom of each bowl. Ladle the chili into the bowls over the rice. Top each serving with a dollop of sour cream and spoonful of avocado or [guacamole](http://www.xanthir.com/recipes/showrecipe.php?id=28). Sprinkle with [Essence](http://www.xanthir.com/recipes/showrecipe.php?id=id4) and green onions and serve.", false, "Vegetarian Chili", 5, null },
                    { 36, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "In a small bowl, combine the lime zest, lime juice, balsamic vinegar, basil, and cumin. Slowly add the oil, whisking constantly until the mixture thickens. Season with salt and pepper, to taste.", false, "Basil-Lime Vinaigrette", 1, null },
                    { 37, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "Place the olive oil into a large 6-quart Dutch oven and set over medium heat. Once hot, add the onion, carrot, celery and salt and sweat until the onions are translucent, approximately 6 to 7 minutes. Add the lentils, tomatoes, broth, coriander, cumin and pepper and stir to combine. Increase the heat to high and bring just to a boil. Reduce the heat to low, cover and cook at a low simmer until the lentils are tender, approximately 35 to 40 minutes. Using a stick blender, puree to your preferred consistency (optional). Serve immediately.", false, "Lentil Soup", 7, null },
                    { 38, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "Mix together", false, "Natural sports drink", 9, null },
                    { 39, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "1. Cook leeks, carrots, onion, and garlic, covered stirring occasionally in a medium saucepan over medium heat for 10 minutes.\r\n2. Add water, parsley, thyme, bay leaf, and peppercorns. Raise heat to high. Bring to a boil, reduce heat. Simmer, uncovered, for 30 minutes. Pour through a cheesecloth-lined strainer; discard solids.\r\n\r\nStorage: stock can be refrigerated for up to 2 days or frozen for up to 3 months.", false, "Vegetable Stock", 10, null },
                    { 40, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "Preheat oven to 425 degrees.\r\n\r\nMix rice, oats, onion, bread crumbs, milk, basil, oregano, cayenne, and egg.  Press mixture into small baking dish.  Mix panko and parmesan, put on top of mixture.  Bake for 20 minutes or until crispy or browned.  (If topping starts browning too soon, cover loosely with aluminum foil.)\r\n\r\nServe with marinara sauce.", false, "Spicy Rice Casserole", 9, null },
                    { 41, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "To make the dressing, combine the orange zest and juice, lemon juice, and shallot. Whisk in the olive oil and season with a few pinches of salt and a few grinds of pepper.\r\n\r\nToss the hot rice with the spinach, pine nuts, citrus dressing, then top with the feta. Taste for seasoning and sprinkle with a bit more salt if needed.", false, "Citrus Rice Salad", 12, null },
                    { 42, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "Bring a large pot of water to a rolling boil.\r\n\r\nMeanwhile, make asparagus pesto.\r\n\r\nSalt the pasta water well and cook the pasta until just tender. Drain and toss immediately with 1 cup of the asparagus pesto (1/4 cup per serving), stirring in more afterward depending on how heavily coated you like your pasta. Serve sprinkled with the remaining toasted pine nuts, a dusting of Parmesan, and a quick drizzle of extra-virgin olive oil.", false, "Straw and Hay Fettuccine Tangle", 5, null },
                    { 43, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "Cook the rice, if it is not already.\r\n\r\nWhen you have all your ingredients prepped, arrange them within arm's reach of the stove. Heat a small splash of sesame oil in a wok or large nonstick pan over medium-high heat. When the oil is hot, add the tofu and cook for a couple of minutes, until the tofu is golden. Remove from the pan. (You can also cook the tofu in a dry nonstick or well seasoned pan.)\r\n\r\nAdd another splash of oil to the wok and, as soon as it's hot, add the asparagus and stir for 2 minutes.  Add the white part of the green onions and chiles, and stir for another 2 minutes.  Add the green part of the green onions, and stir for another 2 minutes.  Add the garlic and ginger, and stir for 30 seconds, then add the cashews and spinach and stir for another minute, or until the spinach wilts and collapses. \r\n\r\nReturn the tofu to the pan. Stir in the stir-fry sauce. Cook for another minute, stirring constantly.\r\n\r\nRemove from heat and stir in the mint and basil. Season with enough soy sauce to make the flavors pop, starting with a splash.\r\n\r\nServe over cooked rice.\r\n\r\nNutrition information does not include stir-fry sauce.", false, "Green-packed Stir Fry with Fresh Herbs", 10, null },
                    { 44, new DateTime(2021, 11, 29, 13, 8, 53, 559, DateTimeKind.Utc), "Preheat a skillet with 1 tablespoon butter (or oil) on medium-low.\r\n\r\nSpread Dijon mustard on the inside of a split piece of baguette. Fill with the brie and apple slices.\r\n\r\nAdd sandwich to skillet, the press a heavy pan on top to weigh it down. Cook until golden and crisp, 3 to 4 minutes per side. Add more butter to the skillet, if needed, for second side.", false, "Apple-Brie Panini", 9, null },
                    { 27, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "1. To prepare, once oatmeal has been sufficiently cooked, add diced apples and nut butter. Stir for 2-3 minutes.\r\n2. Serve into a bowl and mix in cinnamon, flax seeds, maple syrup/agave. Stir and enjoy!", false, "Best Oatmeal Ever", 3, null },
                    { 28, new DateTime(2021, 11, 29, 13, 8, 53, 557, DateTimeKind.Utc), "1. Pour coconut oil and chopped garlic into a saucepan, over medium heat, and saut� the garlic until lightly browned.\r\n2. Add vegetable broth to the saucepan, allowing everything to simmer for about 5 minutes.\r\n3. Add 1 cup of water along with lentils and allow to simmer (uncovered) for about 20-30 minutes until they are soft. Add rosemary and drizzle olive oil near the end.", false, "Lovely Lentils", 11, null },
                    { 65, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. For the honeycomb: Line a shallow baking tray with parchment paper. Place the honey, liquid glucose, water and sugar in a large heavy-based saucepan and heat gently, stirring occasionally until the sugar dissolves. Increase the heat and cook until the mixture starts to turn a light golden colour. Mix in the baking soda. The mixture will erupt into a foaming mass. Pour immediately into the prepared baking tray.\r\n\r\n2. Leave to cool, then place in the fridge to set. This takes approx 6-10 mins. Break up with the end of a rolling pin and store in an airtight jar if not using immediately.\r\n\r\n3. Using a blender, blitz the raspberries and blueberries together with little caster sugar until smooth. Add a drop of lavender essence. Strain the mixture through a sieve to create a fresh coulis. Taste to check consistency and flavour, add a spoonful of water or sugar as necessary.\r\n\r\n4. Lightly mix almost all of the honeycomb through the yoghurt. Spoon into individual serving glasses and pour the coulis on top. Garnish with lavender flowers and a sprinkling of the remaining honeycomb. Serve immediately.", false, "Greek yogurt with homemade honeycomb", 8, null },
                    { 67, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Whisk all the ingredients together in a small saucepan, place over medium heat.\r\n\r\nWhen mixture begins to bubble reduce heat to low and simmer for 30 minutes. Cover and cool. Refrigerate when cold", false, "Heinz Chili Sauce", 14, null },
                    { 87, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. In a blender, puree cherries, sugar, and lemon juice until sugar is dissolved and mixture is smooth. Pour into an 8-inch square baking dish. Freeze 6 hours, scraping with fork every hour (mixture should be icy and fluffy).\r\n\r\n2. To serve, pour 1 tablespoon liqueur into each of 12 small bowls or glasses. Top with 1/2 cup granita and a small dollop of whipped cream, if desired. Serve immediately.", false, "Sweet cherry granita", 5, null },
                    { 88, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Preheat the oven to 350 degrees F. Lightly butter 2 large baking sheets.\r\n\r\nIn a small bowl, combine the jam and Chambord. Stir to combine.\r\n\r\nIn a medium bowl, combine the flour, baking powder, and salt and whisk to blend.\r\n\r\nIn a large bowl using an electric mixer, beat the butter and sugar until light and creamy. Beat in the egg yolks, lemon zest, lemon juice and vanilla. Add the flour mixture in 2 additions and beat just until moist clumps form. Gather the dough together into a ball.\r\n\r\nPinch off the dough to form 1-inch balls. Place on the prepared baking sheets, spacing 1-inch apart. Use your floured index finger or 1/2 teaspoon measuring spoon to create depressions in the center of each ball. Fill each indentation with nearly 1/2 teaspoon of the jam mixture. Bake until golden brown, about 20 minutes.\r\n\r\nTransfer the cookies to wire racks to cool completely.\r\n\r\nYield: 2 dozen", false, "Raspberry-lemon thumbprint cookies", 3, null },
                    { 89, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Melt butter in large saute pan over medium heat. Add carrots, orange juice, and thyme; cook, stirring occasionally, until carrots are tender, about 5 minutes. Season with salt and pepper. Serve warm.", false, "Glazed carrots", 11, null },
                    { 90, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. Bring a large saucepan of water to a boil. Stir in wild rice, reduce to a simmer, and cook (uncovered) until tender, about 40 minutes. Drain rice.\r\n\r\n2. Meanwhile, melt 2 tbsp (or 2/3) of the butter in a large saute pan over medium heat. Toast pecans, stirring frequently, until fragrant, about 5 minutes. With a slotted spoon, transfer pecans to a plate, and season with salt.\r\n\r\n3. Add remaining butter, the pearl onions, and the water to pan; simmer until water is evaporated and onions are tender and pale golden, about 10 minutes.\r\n\r\n4. Trim Brussels sprouts, then score an X into the bottom of each one. Place in a  steaming basket or colander set in a saucepan filled with 1 inch of water. Bring water to a boil, then reduce to a simmer; cover and steam until just tender enough to pierce with the tip of a sharp knife, 6 to 8 minutes.\r\n\r\n5. In a bowl, whisk together sherry vinegar, maple syrup, and mustard. Add rice, Brussels sprouts, and onions; toss to coat, and season with salt and pepper. Coarsely chop pecans and add just before serving, warm or at room temperature.", false, "Baby Brussels sprouts with wild rice and pecans", 1, null },
                    { 91, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. In a small saucepan, sprinkle gelatin over the cold water, and let soften 5 minutes. Cook softened gelatin over medium heat, swirling pan, just until gelatin is dissolved; do not let boil. Let cool completely.\r\n\r\n2. Place pumpkin puree in a large bowl. Stir in softened gelatin, then add egg yolks, maple syrup, nutmeg, vanilla, ginger, allspice, salt, white pepper, and rum. Whisk until fully blended.\r\n\r\n3. With an electric mixer on medium speed, whisk egg whites and the sugar to soft peaks. Gently fold egg-white mixture into pumpkin mixture to combine. Whip heavy cream on medium high to stiff peaks, then gently but thoroughly fold into pumpkin mixture.\r\n\r\n4. Divide mousse among 8 to 10 glasses; refrigerate until set, at least 2 hours, or up to 1 day, covered with plastic wrap. If desired, top each with a dollop of sweetened whipped cream and a pastry leaf before serving.\r\n\r\nFood safety note: the eggs in this recipe are not cooked", false, "Pumpkin mousse", 6, null },
                    { 92, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. Preheat oven to 350F. Make the cake: butter three 9-inch round cake pans, and dust with flour, tapping out excess. Sift flour, granulated sugar, cocoa, baking soda, baking powder, and 1 1/2 teaspoons salt into the bowl of a mixer. Beat on low speed until just combined. Raise speed to medium and add eggs, buttermilk, warm water, oil, and vanilla. Beat until smooth, about 3 minutes.\r\n\r\n2. Divide batter among pans. Bake until cakes are set and a toothpick inserted into the center of each comes out clean, about 35 minutes. Let cool in pans set on a wire rack for 15 minutes. Turn out cakes onto racks and let cool completely.\r\n\r\n3. Make the caramel: Combine granulated sugar, corn syrup, and water in a medium saucepan over high heat. Cook, without stirring, until mixture is dark amber, about 14 minutes. Remove from heat, and carefully pour in cream (mixture will bubble violently); stir until smooth. Return to heat, and cook until a candy thermometer reaches 238F, about 2 minutes. Pour caramel into a medium bowl, stir in 1 teaspoon coarse salt, and let cool slightly, about 15 minutes. Stir in butter, 1 tablespoon at a time. Let cool completely.\r\n\r\n4. Meanwhile, make the frosting: whisk together cocoa and warm water in a bowl until cocoa dissolves. Beat butter, confections' sugar, and a generous pinch of coarse salt in a clean bowl with a mixer on medium speed until pale and fluffy. Gradually beat in melted chocolate and then cocoa mixture until combined. Let stand for 30 minutes before using.\r\n\r\n5. Trim tops of cakes using a serrated knife to creat a level surface. Cut each in half horizontally to form 2 layers. Transfer 1 layer to a serving platter and spread 3/4 cup caramel over top. Top with another cake layer, and repeat with remaining caramel and cake layers, leaving top uncovered. Refrigerate until set, about 1 hour.\r\n\r\n6. Frost top and sides of cake in a swirling motion. Sprinkle with sea salt.\r\n\r\nMake ahead: Caramel can be refrigerated for up to 3 days. Bring to room temperature before using. Cake layers can be refrigerated for up to 3 days (they actually taste better when refrigerated and have a better texture for stacking).\r\n\r\nStorage: Frosted cake can be refrigerated for up to 3 days.", false, "Salted caramel six layer chocolate cake", 11, null },
                    { 93, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "1. Preheat oven to 350F. Line 16 cups of two 12-cup muffin tins with baking cups and lightly coat each with cooking spray.\r\n2. Whisk together sugar, flours, baking soda, and salt in a large bowl. Whisk together milk, yogurt, eggs, and orange zest and juice in a medium bowl. Fold milk mixture into flour mixture, then gently fold in cranberries until combined.\r\n3. Spoon batter into baking cups until each is three-quarters full. Sprinkle with almonds. Bake until a toothpick inserted into the center of each comes out clean, about 20 minutes. Transfer pans to wire racks, and let cool for 10 minutes. Turn out muffins onto racks and let cool completely.", false, "Cranberry almond muffins", 10, null },
                    { 94, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "1. Preheat oven to 350F. Line 16 cups of two 12-cup muffin tins with baking cups and lightly coat each with cooking spray.\r\n2. Whisk together sugar, flours, baking soda, and salt in a large bowl. Whisk together milk, yogurt, eggs, and orange zest and juice in a medium bowl. Fold milk mixture into flour mixture, then gently fold in pears until combined.\r\n3. Spoon batter into baking cups until each is three-quarters full. Sprinkle with hazelnuts. Bake until a toothpick inserted into the center of each comes out clean, about 20 minutes. Transfer pans to wire racks, and let cool for 10 minutes. Turn out muffins onto racks and let cool completely.", false, "Hazelnut pear muffins", 8, null },
                    { 95, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "1. Pulse flour, hazelnuts, and 1/4 teaspoon salt in a food processor until combined. Add butter, and pulse until mixture resembles coarse meal, about 10 seconds. Drizzle 1/4 cup ice water evenly over mixture and pulse until it just begins to hold together (dough should not be wet or sticky). If dough is too dry, add more water, 1 tablespoon at a time, and pulse.\r\n\r\n2. Divide dough in half, and shape each half into a rectangle. Wrap in plastic wrap. Refrigerate until firm, about 1 hour. Let stand for 10 minutes before rolling.\r\n\r\nMake ahead: Dough can be refrigerated overnight or frozen for up to 3 months. Let chilled dough stand at room temperature for 10 minutes and fozen dough thaw before using.", false, "Hazelnut pastry dough", 10, null },
                    { 96, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Place pine nuts in a skillet over medium-low heat. Stir or toss frequently until toasted. Cool before using.\r\n\r\nPlace basil, pine nuts, and garlic in food processor or blender. Pulse until finely chopped. With motor running, slowly drizzle in olive oil. Blend a few minutes, stopping occasionally to scrape sides, until smooth.\r\n\r\nStir in grated Parmesan. Taste for seasoning and add salt and pepper to taste, if desired. Yields about 1 1/4 cup pesto.", false, "Pesto", 13, null },
                    { 97, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "1. Pulse flour, sugar, and salt in a food processor until combined. dd butter, and pulse until mixture resembles coarse meal, about 10 seconds. Drizzle 1/4 cup ice water evenly over mixture. Pulse until mixture holds together when pressed between 2 fingers (dough should not be wet or sticky). If dough is too dry, add more water, 1 tablespoon at a time, and pulse.\r\n\r\n2. Shape dough into 1 large disk or 2 small disks, and wrap in plastic wrap. Refrigerate until firm, at least 1 hour. Dough can be refrigerated overnight or frozen for up to 3 months.\r\n\r\nTo make pastry leaves for garnishing: roll out dough to a 1/4-inch thickness on a lightly floured surface and cut out leaves using floured leaf-shaped cookie cutters. Bake on a parchment-lined baking sheet at 350F, rotating sheet halfway throuh, until pale gold, about 12 minutes.", false, "Pate brisee", 3, null },
                    { 98, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "1. Cook the rice as the label directs. Meanwhile, heat the olive oil in a medium saucepan over medium-high heat. Add the salsa and cumin and cook, stirring, until the salsa is soft, about 5 minutes. Add the black-eyed peas, plus the liquid from one of the cans and 1/4 cup water. Cook, stirring occasionally, until the beans are creamy and tender, about 12 minutes.\r\n\r\n2. Fluff the rice with a fork and divide among bowls. Add the spinach and cilantro to the black-eyed pea mixture and stir until wilted, about 1 minute; spoon evenly over the rice. Top each serving with a few avocado slices, some cheese and more salsa. Serve with sour cream or Greek yogurt, if desired.", false, "Tex-mex rice and black eyed peas", 3, null },
                    { 99, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "1. Preheat the oven to 375F. Heat olive oil in a large ovenproof skillet over medium-high heat. Add the onion and cook, stirring, until golden, about 5 minutes. Add the tomato paste and cook, stirring, 1 more minute. Stir in the vinegar, honey mustard, Worcestershire sauce, water, and salt and pepper to taste. Bring to a simmer, then add the beans, plus the liquid from one of the cans. Cook until the beans are soft, about 5 more minutes.\r\n\r\n2. Make eight indentations in the bean mixture and crack an egg into each. Sprinkle with salt and pepper and transfer to the oven. Bake until the egg whites are set, 10 to 14 minutes. (For 2 servings, 8-9 minutes. Whites should still be slightly \"jiggly\" when you remove from oven.)\r\n\r\n3. Meanwhile, heat a large skillet over medium-high heat. Brush the bread with olive oil on both sides and toast in the skillet, 1 minute per side. Toss the tomatoes, parsley and remaining olive oil, and salt and pepper to taste in a bowl. Divide the toast among plates; top each with 2 eggs, some beans and the tomato salad.", false, "Baked eggs and beans on toast", 12, null },
                    { 100, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "1. Preheat the oven to 400F. Toss the potatoes and bell pepper with olive oil, salt and pepper to taste in a shallow baking dish. Roast 15 minutes. Meanwhile, toss the shrimp with the garlic, oregano, paprika, olive oil, salt, and pepper to taste in a medium bowl.\r\n\r\n2. Add the shrimp to the baking dish. Roast, stirring once, until the shrimp are just cooked through and the potatoes are golden brown, 12 to 15 more minutes.\r\n\r\n3. Toss the romaine in a serving bowl with the lemon juice, olive oil, and salt and pepper to taste. Add the warm shrimp and vegetables and toss to combine. Top with the feta.", false, "Warm shrimp and potato salad", 10, null },
                    { 101, new DateTime(2021, 11, 29, 13, 8, 53, 561, DateTimeKind.Utc), "Bring milks, sugar, almond extract, and a pinch of salt to a boil in a saucepan over medium heat. Add couscous, dried cherries and cinnamon stick; cover and cook 2 minutes. Remove from the heat and let sit, covered, 8 minutes. Fluff with a fork, remove the cinnamon stick and divide among bowls. Top with toasted almond slices and honey, if desired.", false, "Cherry couscous pudding", 8, null },
                    { 86, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. Line a 4.5x8.5-inch loaf pan with parchment, leaving a 4-inch overhang on all sides. Prepare a large bowl of ice water. In a medium saucepan, combine coconut milk and condensed milk and bring to a boil over  high. Reduce heat and cook at a rapid simmer, stirring frequently until thickened, 10 minutes. Remove from heat and stir in lime zest and salt. Place saucepan in bowl of ice water and stir until mixture is cool, 4 minutes.\r\n\r\n2. In a large bowl, using an electric mixer, beat cream on high until stiff peaks from, 2 minutes. Gently fold whipped cream into coconut milk mixture. Pour into loaf pan; evenly sprinkle coconut over top. Freeze until firm, 6 hours (or covered, up to 3 days). Let sit 20 minutes at room temperature. Invert onto a serving platter; peel away parchment. Layer mango on top and serve.", false, "Coconut lime semifreddo", 14, null },
                    { 66, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Combine all ingredients.", false, "Cocktail Sauce", 14, null },
                    { 85, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. Wrap outside of a 3.5-cup souffle mold or four 6-ounce ramekins with parchment, extending 2 to 3 inches above rim (it should fit snugly). Secure with tape, set aside.\r\n\r\n2. In a medium saucepan, whisk together granulated sugar, lemon zest and juice, egg yolks, and salt over medium-high. Cook, whisking constantly, until mixture is thick enough to coat the back of a spoon and small bubbles form around edge of pan, about 5 minutes (do not boil). Immediately remove from heat while continuing to whisk. Pour through a fine-mesh sieve into a heatproof bowl, pressing on lemon curd with a rubber spatula.\r\n\r\n3. Place plastic wrap directly against surface of curd and refrigerate until cool, about 30 minutes (or up to overnight).\r\n\r\n4. In a large bowl, using an electric mixer, beat egg whites on high until stiff peaks form, 2 minutes. Gently fold egg whites into cooled lemon curd. In the same large bowl, beat cream on high until stiff peaks form, 1 to 2 minutes. Gently fold whipped cream into lemon curd mixture. Pour into mold and freeze until firm, 6 hours (or up to overnight). To serve, remove parchment, top with raspberries and dust with confectioners' sugar.", false, "Frozen lemon souffle", 14, null },
                    { 83, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. In a blender, combine strawberries, 3/4 cup sugar, and a pinch of salt and puree until smooth. Pour into a 9x13 baking dish. Transfer to freezer and scrape with a fork every 30 minutes until mixture is thick and slushy, 2 hours. Smooth top with rubber spatula.\r\n\r\n2. In a large bowl, using and electric mixer, beat egg whites on high until foamy. With mixer on medium, gradually add 3/4 cup sugar. Increase speed to high and beat until stiff, glossy peaks form, 3 minutes. In another medium bowl, beat cream and vanilla on high until stiff peaks form, 1 to 2 minutes. With rubber spatula, gently fold whipped cream into egg white mixture. Pour over strawberry mixture and smooth top with rubber spatula. Freeze until firm, about 4 hours (or, covered, up to 3 days), before cutting into 12 squares.", false, "Strawberries and cream bars", 14, null },
                    { 68, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Preheat the oven to 425F with the pan in the oven, and toast the pine nuts. \r\n\r\nWhisk the egg whites in a clean bowl to form stiff peaks. In a separate bowl, mix the egg yolks with the spinach, tomato, goat cheese, salt, and pepper to combine. Gently fold the egg whites into the spinach mixture. \r\n\r\nSpray the hot pan with oil, then spoon the mixture in and sprinkle with the pine nuts.\r\n\r\nBake in the oven for 10 minutes, or until well risen, golden, and firm. Serve.\r\n\r\nRather than fresh spinach, one can use 3.5oz per serving cooked spinach, chopped or pureed.", false, "Spinach souffle", 8, null },
                    { 69, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Preheat oven to 400�.\r\nWrap shallot in foil. Bake at 400� for 35 minutes; cool for 10 minutes. Peel and mince. Combine shallot, vinegar, oil, sugar, mustard, salt, and pepper in a large bowl; stir well with a whisk.", false, "Roasted Shallot Vinaigrette", 14, null },
                    { 70, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Thinly slice the bell pepper and scallions.  Roughly chop the basil, cilantro, mint, and peanuts.\r\n\r\nCook noodles according to package instructions.  Transfer to a serving bowl.\r\n\r\nWhisk the lime juice soy sauce, peanut butter, brown sugar, and vegetable oil in a medium bowl until smooth.  Pour the dressing over the noodles.  (If possible, do this when the noodles are hot - it helps melt the peanut butter, which will still be chunky in the dressing.)  \r\n\r\nAdd the bell pepper , scallions, basil, cilantro, and mint and toss to combine.  Season with salt and sprinkle with the peanuts.", false, "Peanut Noodle Salad", 11, null },
                    { 71, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Preheat oven to 425�.\r\n\r\nIn a large skillet, heat 1 tbsp oil over medium-high.  Add leeks and celery; cook until softened, 8 minutes.  Add artichokes, broth, and cheese and stir to combine.  Remove skillet from heat, add lemon juice, and season with salt and pepper.\r\n\r\nBrush a 1 1/2-quart baking dish with oil.  Arrange half the potato slices in a single layer, overlapping slightly; season with salt and pepper.  Top with artichoke mixture and smooth top . Layer with remaining potatoes, brush with 2 tsp oil, and season with salt and pepper.\r\n\r\nBake until sauce is bubbling and potatoes are golden and tender, 35 to 40 minutes.  Let cool 10 minutes before serving.", false, "Artichoke, Leek, and Potato Casserole", 7, null },
                    { 72, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "In a large skillet, heat olive oil over medium-high.  Add broccoli, trimmed and cut into florets, and cook until broccoli begins to brown, 4 minutes.  Add garlic and cook, stirring occasionally, until broccoli is crisp and tender and garlic begins to brown, 3 minutes.\r\n\r\nAdd red pepper flakes, season with salt and pepper, and transfer to serving bowl.  Toss with lemon zest, lemon juice, parmesan, and walnuts.  Serve warm or at room temperature.", false, "Broccoli with Parmesan and Walnuts", 8, null }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "RecipeCategory_Id", "UserId" },
                values: new object[,]
                {
                    { 73, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. In a medium saucepan, bring water and sugar to a boil over medium-high. Reduce to a simmer and cook, stirring occasionally, until sugar dissolves, 2 minutes. Transfer to a pitcher and refrigerated until cool, about 45 minutes. Add lemon juice and stir to combine.\r\n\r\n2. In a blender, puree strawberries until smooth. Pour through a fine-mesh sieve into a pitcher with lemon syrup, pressing on solid. Stir well to combine.\r\n\r\n3. To serve, stir in seltzer and divide among ice-filled glasses. Trop with lemon slices and mint.", false, "Emeril's strawberry lemonade", 5, null },
                    { 74, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Preheat oven to 500. Lightly dust a work surface, rolling pin, and a baking sheet with flour. Roll dough out to a 13-inch round and transfer to sheet.\r\n\r\nIn a small bowl, stir together ricotta, oil and garlic; season with salt and pepper. Spread ricotta mixture on dough, leaving a 1/2-inch border. Top with mozzarella, then Parmesan. Brush oil on edge of dough. Bake until crust is golden and cheese is melted and browned in spots, 12 to 14 minutes. \r\n\r\nIn a small bowl, toss arugula with oil and season to taste with salt and pepper. Top pizza with arugula and serve.", false, "Pizza bianca", 4, null },
                    { 75, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Heat oil in a large pot over medium heat.  Cook garlic and leek until soft and translucent, about 4 minutes.  Add apple, celery, and ginger, and cook for 3 minutes.  Add sweet potatoes and stock, and simmer until sweet potatoes are tender, about 15 minutes.  \r\n\r\nAdd chipotle chiles.  Puree until smooth.  Season with salt and pepper.  Sprinkle with pepitas before serving.", false, "Smoky Sweet-Potato Soup", 2, null },
                    { 76, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "In a medium bowl, whisk together buttermilk, sour cream, and mayonnaise. Whisk in remaining ingredients. Season to taste with salt and pepper.", false, "Green goddess dressing", 14, null },
                    { 77, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "In a medium bowl, whisk together buttermilk, sour cream, and mayonnaise. Whisk in remaining ingredients. Season to taste with salt and pepper.", false, "Creamy roasted garlic dressing", 3, null },
                    { 78, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Whisk together all ingredients in bowl. Season to taste with salt and pepper.", false, "Creamy ranch dressing", 6, null },
                    { 79, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Whisk together all ingredients.", false, "Creamy peppercorn-Parmesan dressing", 1, null },
                    { 80, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. Make crust: preheat oven to 350. Lightly butter six standard muffin cups. In a food processor, process butter, flour, sugar, and salt until mixture resembles coarse meal. Add yolks and vanilla and process until dough comes together when pressed (dough will be crumbly).\r\n\r\n2. Divide dough into 6 pieces. Roll each into a ball and place in a muffin cup, pressing evenly into bottom and up sides. Place a paper cupcake liner into each muffin cup over dough and fill with pie weights or dried beans. Bake until edges are dry, 15 minutes. Carefully remove liners and weights; bake until crusts are dry and barely golden, 5 to 7 minutes.\r\n\r\n3. Meanwhile, make filling: in a medium bowl, whisk together eggs, flour, sugar, lime juice, and salt. Place 3 cherry halves into each crust and divide filling among each. Bake until filling is set, about 25 minutes. With the tip of a knife or small offset spatula, remove cups from pan. Let cool completely on a wire rack.\r\n\r\nTo store, refrigerate in an airtight container, up to 1 day.", false, "Cherry-lime cups", 11, null },
                    { 81, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. Heat broiler, with rack in top position. Place tomatoes, onion halves, jalapenos, and garlic in a single layer on a rimmed baking sheet.\r\n\r\n2. Broil until vegetables are blistered and slightly softened, rotating sheet and flipping vegetables frequently, 6 to 8 minutes (garlic may need to be removed earlier if it is browning too quickly.)\r\n\r\n3. Discard garlic skins. In a food processor, pulse garlic and vegetables until coarsely pureed. Add lime juice, season with salt and pepper, and pulse to combine.\r\n\r\n4. Transfer salsa to a bowl and stir in cilantro.\r\n\r\nYields 3 cups. Refrigerate up to 3 days or freeze up to 3 months.\r\n\r\nFor green salsa, use 1 1/2 lbs tomatillos and omit lime juice.", false, "Roasted salsa", 3, null },
                    { 82, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Cook rice according to package instructions. Meanwhile, in a large nonstick skillet, heat oil over medium-high. Add shrimp and garlic and cook, stirring occasionally, 4 minutes. Add edamame and scallion whites and cook until shrimp are opaque and garlic is golden, about 3 minutes. Add scallion greens ad lime juice and cook 1 minute. Season to taste with salt and pepper; serve with rice and lime wedges, if desired.", false, "Shrimp and edamame with lime", 12, null },
                    { 84, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "1. In a medium bowl, toss together cake and brandy, if desired. In another medium bowl, using and electric mixer, beat egg whites on high until foamy. With mixer on medium, gradually add sugar. Increase speed to high and beat until stiff, glossy peaks form, 2 minutes. With a rubber spatula, gently fold cocoa powder into egg white mixture.\r\n\r\n2. In another medium bowl, beat cream on high until stiff peaks form, 3 minutes. Gently fold whipped cream into egg white mixture.\r\n\r\n3. Fill each of four small glasses with 1/4 cup cake and top with heaping 1/4 cup mousse. Repeat to make a second layer with remaining cake and mousse. Freeze until firm, 3 hours (or up to overnight). Let sit 10 minutes at room temperature, then finely grate chocolate over tops to serve.", false, "Frozen chocolate mousse trifles", 6, null },
                    { 46, new DateTime(2021, 11, 29, 13, 8, 53, 560, DateTimeKind.Utc), "Prepare mix ahead of time. One serving is 1/4 cup mix per cup of milk.\r\n\r\nBring milk to a simmer in a saucepan over medium heat. Whisk cocoa/sugar mix into the milk. Add the chopped chocolate and reduce heat to low and simmer, stirring, until the chocolate melts and the cocoa is thick, about 2 minutes. Divide among mugs and garnish each with homemade marshmallows or whipped cream.", false, "Hot Cocoa", 4, null }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 4, 1, 3, 33m },
                    { 42, 102, 3, 46m },
                    { 4, 102, 3, 14m },
                    { 39, 102, 1, 46m },
                    { 88, 102, 1, 21m },
                    { 24, 101, 5, 44m },
                    { 4, 101, 3, 45m },
                    { 30, 101, 3, 47m },
                    { 47, 101, 2, 189m },
                    { 9, 101, 4, 189m },
                    { 73, 101, 3, 12m },
                    { 56, 102, 5, 12m },
                    { 86, 101, 2, 691m },
                    { 12, 101, 2, 341m },
                    { 68, 101, 2, 143m },
                    { 6, 101, 3, 15m },
                    { 24, 100, 5, 17m },
                    { 50, 100, 1, 19m },
                    { 74, 100, 1, 46m },
                    { 76, 100, 3, 37m },
                    { 33, 100, 5, 46m },
                    { 98, 100, 4, 389m },
                    { 28, 100, 3, 7m },
                    { 37, 101, 3, 46m },
                    { 10, 102, 4, 313m },
                    { 65, 102, 4, 331m },
                    { 98, 102, 4, 844m },
                    { 7, 104, 2, 675m },
                    { 23, 104, 2, 502m },
                    { 84, 104, 2, 823m },
                    { 48, 104, 1, 40m },
                    { 92, 104, 2, 105m },
                    { 15, 104, 3, 38m },
                    { 83, 103, 3, 18m },
                    { 44, 103, 3, 15m },
                    { 4, 103, 3, 21m },
                    { 26, 103, 5, 10m },
                    { 16, 103, 1, 45m },
                    { 39, 103, 1, 40m },
                    { 52, 103, 4, 549m },
                    { 36, 103, 1, 34m },
                    { 55, 103, 5, 18m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 25, 103, 3, 21m },
                    { 72, 103, 5, 45m },
                    { 77, 103, 4, 128m },
                    { 40, 103, 1, 23m },
                    { 83, 102, 3, 31m },
                    { 12, 102, 2, 375m },
                    { 80, 102, 3, 18m },
                    { 57, 102, 5, 38m },
                    { 27, 100, 3, 24m },
                    { 30, 100, 3, 8m },
                    { 55, 100, 5, 35m },
                    { 3, 100, 1, 1m },
                    { 72, 97, 5, 32m },
                    { 54, 97, 3, 32m },
                    { 24, 97, 5, 8m },
                    { 4, 97, 3, 28m },
                    { 81, 97, 2, 713m },
                    { 35, 97, 2, 200m },
                    { 10, 97, 4, 747m },
                    { 16, 97, 1, 28m },
                    { 84, 97, 2, 484m },
                    { 79, 96, 2, 177m },
                    { 42, 96, 3, 33m },
                    { 83, 96, 3, 41m },
                    { 94, 96, 5, 29m },
                    { 39, 96, 1, 6m },
                    { 62, 96, 1, 23m },
                    { 51, 96, 5, 29m },
                    { 20, 96, 5, 11m },
                    { 54, 96, 3, 7m },
                    { 93, 96, 2, 310m },
                    { 9, 96, 4, 150m },
                    { 31, 95, 1, 16m },
                    { 53, 95, 3, 25m },
                    { 95, 95, 4, 439m },
                    { 21, 97, 4, 370m },
                    { 78, 104, 1, 12m },
                    { 58, 98, 4, 773m },
                    { 82, 98, 3, 18m },
                    { 4, 100, 3, 41m },
                    { 26, 99, 5, 3m },
                    { 80, 99, 3, 46m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 68, 99, 2, 505m },
                    { 51, 99, 5, 18m },
                    { 59, 99, 4, 749m },
                    { 29, 99, 3, 25m },
                    { 19, 99, 1, 7m },
                    { 82, 99, 3, 15m },
                    { 3, 99, 1, 20m },
                    { 5, 99, 5, 31m },
                    { 89, 99, 5, 39m },
                    { 96, 99, 1, 48m },
                    { 25, 99, 3, 2m },
                    { 28, 99, 3, 26m },
                    { 6, 99, 3, 49m },
                    { 19, 98, 1, 32m },
                    { 88, 98, 1, 20m },
                    { 28, 98, 3, 32m },
                    { 63, 98, 2, 318m },
                    { 89, 98, 5, 36m },
                    { 81, 98, 2, 796m },
                    { 5, 98, 5, 47m },
                    { 37, 98, 3, 38m },
                    { 91, 104, 2, 152m },
                    { 52, 104, 4, 348m },
                    { 6, 104, 3, 47m },
                    { 50, 111, 1, 10m },
                    { 49, 111, 2, 225m },
                    { 83, 111, 3, 45m },
                    { 45, 111, 1, 39m },
                    { 72, 111, 5, 22m },
                    { 28, 110, 3, 10m },
                    { 84, 110, 2, 530m },
                    { 97, 110, 2, 345m },
                    { 72, 110, 5, 29m },
                    { 1, 110, 3, 23m },
                    { 81, 110, 2, 117m },
                    { 57, 110, 5, 46m },
                    { 45, 110, 1, 1m },
                    { 43, 110, 2, 549m },
                    { 78, 110, 1, 17m },
                    { 65, 109, 4, 497m },
                    { 46, 109, 3, 7m },
                    { 3, 109, 1, 35m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 24, 109, 5, 39m },
                    { 11, 109, 3, 30m },
                    { 99, 109, 3, 21m },
                    { 44, 109, 3, 31m },
                    { 5, 109, 5, 26m },
                    { 65, 111, 4, 624m },
                    { 80, 109, 3, 14m },
                    { 35, 111, 2, 285m },
                    { 16, 111, 1, 12m },
                    { 81, 113, 2, 105m },
                    { 45, 113, 1, 50m },
                    { 65, 113, 4, 190m },
                    { 8, 113, 5, 32m },
                    { 35, 113, 2, 546m },
                    { 25, 113, 3, 21m },
                    { 79, 113, 2, 506m },
                    { 50, 113, 1, 32m },
                    { 11, 112, 3, 43m },
                    { 83, 112, 3, 18m },
                    { 51, 112, 5, 43m },
                    { 100, 112, 4, 602m },
                    { 19, 112, 1, 24m },
                    { 13, 112, 1, 12m },
                    { 80, 112, 3, 27m },
                    { 12, 112, 2, 155m },
                    { 66, 112, 2, 288m },
                    { 50, 112, 1, 7m },
                    { 45, 112, 1, 39m },
                    { 57, 112, 5, 42m },
                    { 72, 112, 5, 13m },
                    { 78, 111, 1, 31m },
                    { 42, 111, 3, 38m },
                    { 88, 111, 1, 37m },
                    { 29, 95, 3, 45m },
                    { 98, 109, 4, 660m },
                    { 76, 109, 3, 47m },
                    { 25, 106, 3, 17m },
                    { 17, 106, 4, 519m },
                    { 91, 106, 2, 520m },
                    { 23, 106, 2, 546m },
                    { 87, 106, 5, 18m },
                    { 40, 106, 1, 34m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 77, 106, 4, 167m },
                    { 72, 106, 5, 28m },
                    { 37, 105, 3, 28m },
                    { 44, 105, 3, 45m },
                    { 40, 105, 1, 14m },
                    { 29, 105, 3, 27m },
                    { 62, 105, 1, 29m },
                    { 86, 105, 2, 201m },
                    { 23, 105, 2, 121m },
                    { 69, 105, 2, 534m },
                    { 26, 105, 5, 4m },
                    { 95, 105, 4, 784m },
                    { 84, 105, 2, 359m },
                    { 59, 105, 4, 699m },
                    { 90, 104, 1, 48m },
                    { 86, 104, 2, 825m },
                    { 40, 104, 1, 29m },
                    { 66, 106, 2, 724m },
                    { 60, 109, 1, 29m },
                    { 53, 106, 3, 47m },
                    { 58, 106, 4, 514m },
                    { 78, 109, 1, 2m },
                    { 38, 109, 3, 13m },
                    { 5, 108, 5, 3m },
                    { 56, 108, 5, 45m },
                    { 37, 108, 3, 17m },
                    { 92, 108, 2, 650m },
                    { 39, 108, 1, 42m },
                    { 71, 108, 2, 625m },
                    { 4, 108, 3, 11m },
                    { 73, 108, 3, 20m },
                    { 78, 108, 1, 17m },
                    { 89, 107, 5, 2m },
                    { 65, 107, 4, 302m },
                    { 50, 107, 1, 44m },
                    { 75, 107, 3, 11m },
                    { 46, 107, 3, 13m },
                    { 79, 107, 2, 309m },
                    { 86, 107, 2, 454m },
                    { 24, 107, 5, 5m },
                    { 59, 107, 4, 813m },
                    { 25, 107, 3, 10m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 14, 106, 4, 715m },
                    { 46, 106, 3, 22m },
                    { 6, 106, 3, 15m },
                    { 42, 95, 3, 45m },
                    { 27, 95, 3, 50m },
                    { 8, 95, 5, 37m },
                    { 37, 83, 3, 29m },
                    { 97, 83, 2, 350m },
                    { 79, 83, 2, 756m },
                    { 41, 83, 2, 160m },
                    { 26, 83, 5, 50m },
                    { 43, 83, 2, 509m },
                    { 75, 83, 3, 22m },
                    { 68, 83, 2, 424m },
                    { 31, 82, 1, 26m },
                    { 60, 82, 1, 42m },
                    { 57, 82, 5, 33m },
                    { 52, 82, 4, 642m },
                    { 24, 82, 5, 29m },
                    { 7, 82, 2, 124m },
                    { 16, 82, 1, 12m },
                    { 71, 82, 2, 629m },
                    { 10, 82, 4, 798m },
                    { 54, 82, 3, 18m },
                    { 8, 82, 5, 22m },
                    { 97, 82, 2, 567m },
                    { 37, 82, 3, 10m },
                    { 63, 82, 2, 203m },
                    { 44, 82, 3, 28m },
                    { 26, 84, 5, 29m },
                    { 20, 81, 5, 38m },
                    { 97, 84, 2, 570m },
                    { 78, 84, 1, 13m },
                    { 50, 85, 1, 34m },
                    { 96, 85, 1, 46m },
                    { 25, 85, 3, 12m },
                    { 74, 85, 1, 17m },
                    { 86, 85, 2, 496m },
                    { 18, 85, 4, 294m },
                    { 73, 85, 3, 44m },
                    { 28, 85, 3, 26m },
                    { 43, 85, 2, 252m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 53, 85, 3, 38m },
                    { 1, 85, 3, 47m },
                    { 5, 85, 5, 13m },
                    { 87, 85, 5, 42m },
                    { 17, 85, 4, 419m },
                    { 42, 84, 3, 21m },
                    { 47, 84, 2, 574m },
                    { 44, 84, 3, 16m },
                    { 68, 84, 2, 743m },
                    { 75, 84, 3, 37m },
                    { 33, 84, 5, 2m },
                    { 59, 84, 4, 421m },
                    { 40, 84, 1, 5m },
                    { 43, 84, 2, 611m },
                    { 3, 84, 1, 37m },
                    { 27, 85, 3, 10m },
                    { 62, 81, 1, 49m },
                    { 97, 81, 2, 586m },
                    { 8, 79, 5, 14m },
                    { 44, 79, 3, 17m },
                    { 93, 79, 2, 656m },
                    { 45, 79, 1, 16m },
                    { 36, 79, 1, 14m },
                    { 4, 79, 3, 4m },
                    { 53, 79, 3, 11m },
                    { 5, 79, 5, 25m },
                    { 13, 78, 1, 17m },
                    { 52, 78, 4, 313m },
                    { 73, 78, 3, 2m },
                    { 55, 78, 5, 27m },
                    { 36, 78, 1, 6m },
                    { 69, 78, 2, 826m },
                    { 81, 78, 2, 370m },
                    { 90, 78, 1, 37m },
                    { 17, 78, 4, 537m },
                    { 63, 78, 2, 664m },
                    { 40, 77, 1, 13m },
                    { 26, 77, 5, 33m },
                    { 9, 77, 4, 183m },
                    { 87, 77, 5, 32m },
                    { 72, 77, 5, 30m },
                    { 62, 79, 1, 6m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 85, 81, 4, 363m },
                    { 43, 79, 2, 669m },
                    { 39, 80, 1, 20m },
                    { 99, 81, 3, 34m },
                    { 66, 81, 2, 454m },
                    { 75, 81, 3, 7m },
                    { 45, 81, 1, 28m },
                    { 18, 81, 4, 368m },
                    { 56, 81, 5, 31m },
                    { 23, 81, 2, 424m },
                    { 44, 81, 3, 32m },
                    { 92, 81, 2, 539m },
                    { 49, 81, 2, 382m },
                    { 53, 80, 3, 22m },
                    { 60, 80, 1, 49m },
                    { 1, 80, 3, 21m },
                    { 35, 80, 2, 278m },
                    { 100, 80, 4, 386m },
                    { 66, 80, 2, 470m },
                    { 99, 80, 3, 36m },
                    { 62, 80, 1, 48m },
                    { 10, 80, 4, 640m },
                    { 48, 80, 1, 33m },
                    { 4, 80, 3, 15m },
                    { 84, 80, 2, 695m },
                    { 54, 80, 3, 35m },
                    { 49, 79, 2, 652m },
                    { 35, 114, 2, 781m },
                    { 91, 86, 2, 213m },
                    { 55, 86, 5, 7m },
                    { 16, 92, 1, 35m },
                    { 10, 92, 4, 485m },
                    { 77, 92, 4, 754m },
                    { 41, 92, 2, 417m },
                    { 60, 92, 1, 1m },
                    { 100, 92, 4, 717m },
                    { 54, 92, 3, 40m },
                    { 27, 92, 3, 19m },
                    { 13, 92, 1, 17m },
                    { 12, 92, 2, 307m },
                    { 52, 92, 4, 758m },
                    { 62, 92, 1, 16m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 96, 91, 1, 40m },
                    { 40, 91, 1, 29m },
                    { 93, 91, 2, 782m },
                    { 36, 91, 1, 42m },
                    { 7, 91, 2, 159m },
                    { 49, 91, 2, 316m },
                    { 87, 91, 5, 36m },
                    { 85, 91, 4, 115m },
                    { 81, 91, 2, 592m },
                    { 11, 91, 3, 43m },
                    { 29, 91, 3, 32m },
                    { 94, 92, 5, 36m },
                    { 41, 91, 2, 737m },
                    { 5, 92, 5, 13m },
                    { 58, 93, 4, 556m },
                    { 17, 95, 4, 426m },
                    { 39, 95, 1, 20m },
                    { 5, 95, 5, 39m },
                    { 59, 95, 4, 590m },
                    { 87, 95, 5, 24m },
                    { 3, 95, 1, 22m },
                    { 83, 95, 3, 31m },
                    { 92, 94, 2, 331m },
                    { 93, 94, 2, 668m },
                    { 43, 94, 2, 487m },
                    { 78, 94, 1, 4m },
                    { 58, 94, 4, 186m },
                    { 59, 94, 4, 777m },
                    { 18, 94, 4, 348m },
                    { 19, 94, 1, 39m },
                    { 32, 94, 4, 213m },
                    { 78, 93, 1, 40m },
                    { 90, 93, 1, 22m },
                    { 74, 93, 1, 25m },
                    { 85, 93, 4, 736m },
                    { 7, 93, 2, 792m },
                    { 86, 93, 2, 493m },
                    { 92, 93, 2, 115m },
                    { 82, 92, 3, 47m },
                    { 28, 86, 3, 27m },
                    { 72, 91, 5, 15m },
                    { 27, 90, 3, 1m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 91, 88, 2, 575m },
                    { 45, 88, 1, 2m },
                    { 6, 88, 3, 35m },
                    { 44, 88, 3, 18m },
                    { 99, 87, 3, 12m },
                    { 73, 87, 3, 47m },
                    { 27, 87, 3, 22m },
                    { 59, 87, 4, 613m },
                    { 84, 87, 2, 289m },
                    { 54, 87, 3, 21m },
                    { 6, 87, 3, 36m },
                    { 2, 87, 2, 184m },
                    { 3, 87, 1, 21m },
                    { 20, 87, 5, 44m },
                    { 88, 87, 1, 30m },
                    { 49, 87, 2, 286m },
                    { 45, 86, 1, 39m },
                    { 41, 86, 2, 101m },
                    { 100, 86, 4, 799m },
                    { 90, 86, 1, 7m },
                    { 71, 86, 2, 819m },
                    { 18, 86, 4, 697m },
                    { 88, 86, 1, 14m },
                    { 50, 88, 1, 19m },
                    { 28, 90, 3, 26m },
                    { 51, 88, 5, 6m },
                    { 48, 88, 1, 44m },
                    { 70, 90, 1, 6m },
                    { 97, 90, 2, 561m },
                    { 56, 90, 5, 15m },
                    { 7, 90, 2, 322m },
                    { 59, 90, 4, 517m },
                    { 75, 90, 3, 42m },
                    { 98, 90, 4, 639m },
                    { 53, 89, 3, 37m },
                    { 29, 89, 3, 29m },
                    { 46, 89, 3, 24m },
                    { 7, 89, 2, 336m },
                    { 8, 89, 5, 16m },
                    { 3, 89, 1, 12m },
                    { 1, 89, 3, 42m },
                    { 22, 89, 3, 23m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 27, 89, 3, 43m },
                    { 54, 89, 3, 36m },
                    { 17, 89, 4, 728m },
                    { 59, 88, 4, 794m },
                    { 21, 88, 4, 415m },
                    { 39, 88, 1, 36m },
                    { 79, 88, 2, 119m },
                    { 94, 88, 5, 49m },
                    { 100, 88, 4, 127m },
                    { 62, 77, 1, 36m },
                    { 8, 114, 5, 28m },
                    { 12, 114, 2, 295m },
                    { 41, 139, 2, 793m },
                    { 76, 139, 3, 11m },
                    { 66, 139, 2, 574m },
                    { 23, 139, 2, 568m },
                    { 10, 139, 4, 455m },
                    { 45, 139, 1, 25m },
                    { 65, 139, 4, 468m },
                    { 62, 139, 1, 44m },
                    { 18, 139, 4, 368m },
                    { 3, 139, 1, 9m },
                    { 40, 139, 1, 30m },
                    { 97, 139, 2, 318m },
                    { 91, 138, 2, 609m },
                    { 100, 138, 4, 769m },
                    { 93, 138, 2, 208m },
                    { 67, 138, 2, 407m },
                    { 69, 138, 2, 312m },
                    { 11, 138, 3, 14m },
                    { 92, 138, 2, 729m },
                    { 22, 138, 3, 20m },
                    { 9, 138, 4, 221m },
                    { 48, 137, 1, 43m },
                    { 99, 138, 3, 41m },
                    { 84, 139, 2, 454m },
                    { 61, 139, 1, 16m },
                    { 2, 139, 2, 816m },
                    { 49, 142, 2, 187m },
                    { 81, 142, 2, 444m },
                    { 56, 142, 5, 42m },
                    { 51, 142, 5, 11m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 3, 141, 1, 12m },
                    { 100, 141, 4, 594m },
                    { 83, 141, 3, 46m },
                    { 17, 141, 4, 428m },
                    { 40, 141, 1, 33m },
                    { 35, 141, 2, 525m },
                    { 81, 141, 2, 620m },
                    { 8, 141, 5, 17m },
                    { 47, 140, 2, 351m },
                    { 45, 140, 1, 48m },
                    { 76, 140, 3, 3m },
                    { 48, 140, 1, 34m },
                    { 100, 140, 4, 457m },
                    { 97, 140, 2, 359m },
                    { 62, 140, 1, 27m },
                    { 46, 140, 3, 50m },
                    { 10, 140, 4, 593m },
                    { 40, 140, 1, 23m },
                    { 26, 140, 5, 43m },
                    { 28, 137, 3, 32m },
                    { 8, 137, 5, 8m },
                    { 71, 137, 2, 593m },
                    { 2, 137, 2, 202m },
                    { 12, 135, 2, 723m },
                    { 95, 135, 4, 146m },
                    { 60, 135, 1, 19m },
                    { 4, 135, 3, 32m },
                    { 50, 135, 1, 46m },
                    { 44, 134, 3, 24m },
                    { 30, 134, 3, 29m },
                    { 55, 134, 5, 39m },
                    { 20, 134, 5, 49m },
                    { 36, 134, 1, 18m },
                    { 5, 134, 5, 30m },
                    { 58, 134, 4, 675m },
                    { 13, 134, 1, 9m },
                    { 12, 134, 2, 517m },
                    { 60, 134, 1, 50m },
                    { 71, 133, 2, 366m },
                    { 11, 133, 3, 18m },
                    { 83, 133, 3, 11m },
                    { 50, 133, 1, 28m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 23, 133, 2, 606m },
                    { 41, 133, 2, 365m },
                    { 44, 133, 3, 42m },
                    { 30, 133, 3, 23m },
                    { 11, 135, 3, 12m },
                    { 83, 142, 3, 7m },
                    { 18, 135, 4, 244m },
                    { 63, 135, 2, 297m },
                    { 51, 137, 5, 21m },
                    { 76, 137, 3, 43m },
                    { 30, 137, 3, 17m },
                    { 85, 137, 4, 345m },
                    { 75, 137, 3, 33m },
                    { 65, 137, 4, 238m },
                    { 69, 137, 2, 363m },
                    { 70, 137, 1, 45m },
                    { 87, 137, 5, 32m },
                    { 9, 137, 4, 542m },
                    { 96, 136, 1, 8m },
                    { 44, 136, 3, 32m },
                    { 80, 136, 3, 45m },
                    { 70, 136, 1, 15m },
                    { 3, 136, 1, 20m },
                    { 90, 136, 1, 46m },
                    { 99, 136, 3, 17m },
                    { 82, 136, 3, 39m },
                    { 67, 136, 2, 390m },
                    { 49, 136, 2, 447m },
                    { 65, 136, 4, 689m },
                    { 52, 135, 4, 170m },
                    { 24, 135, 5, 19m },
                    { 74, 135, 1, 33m },
                    { 27, 142, 3, 8m },
                    { 35, 142, 2, 422m },
                    { 85, 142, 4, 202m },
                    { 14, 148, 4, 156m },
                    { 66, 148, 2, 128m },
                    { 37, 148, 3, 3m },
                    { 38, 148, 3, 27m },
                    { 94, 148, 5, 5m },
                    { 11, 148, 3, 9m },
                    { 89, 148, 5, 4m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 31, 148, 1, 15m },
                    { 65, 147, 4, 335m },
                    { 77, 147, 4, 536m },
                    { 10, 147, 4, 846m },
                    { 25, 147, 3, 35m },
                    { 66, 147, 2, 233m },
                    { 69, 147, 2, 327m },
                    { 70, 147, 1, 1m },
                    { 73, 147, 3, 13m },
                    { 60, 147, 1, 47m },
                    { 68, 147, 2, 309m },
                    { 51, 147, 5, 35m },
                    { 48, 146, 1, 9m },
                    { 15, 146, 3, 31m },
                    { 76, 146, 3, 17m },
                    { 83, 146, 3, 13m },
                    { 47, 148, 2, 337m },
                    { 71, 146, 2, 515m },
                    { 80, 148, 3, 26m },
                    { 41, 149, 2, 496m },
                    { 61, 150, 1, 44m },
                    { 41, 150, 2, 292m },
                    { 47, 150, 2, 182m },
                    { 53, 150, 3, 49m },
                    { 96, 150, 1, 17m },
                    { 93, 150, 2, 464m },
                    { 3, 150, 1, 10m },
                    { 58, 150, 4, 368m },
                    { 80, 150, 3, 40m },
                    { 73, 150, 3, 30m },
                    { 42, 150, 3, 34m },
                    { 63, 150, 2, 780m },
                    { 35, 149, 2, 319m },
                    { 10, 149, 4, 738m },
                    { 25, 149, 3, 36m },
                    { 23, 149, 2, 199m },
                    { 75, 149, 3, 9m },
                    { 56, 149, 5, 46m },
                    { 8, 149, 5, 26m },
                    { 71, 149, 2, 310m },
                    { 31, 149, 1, 27m },
                    { 100, 149, 4, 504m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 87, 149, 5, 25m },
                    { 63, 149, 2, 492m },
                    { 82, 133, 3, 24m },
                    { 75, 146, 3, 5m },
                    { 2, 146, 2, 558m },
                    { 14, 144, 4, 120m },
                    { 4, 144, 3, 17m },
                    { 42, 144, 3, 27m },
                    { 70, 144, 1, 36m },
                    { 43, 144, 2, 637m },
                    { 86, 144, 2, 656m },
                    { 98, 144, 4, 582m },
                    { 28, 144, 3, 50m },
                    { 70, 143, 1, 20m },
                    { 37, 143, 3, 50m },
                    { 2, 143, 2, 406m },
                    { 22, 143, 3, 45m },
                    { 48, 143, 1, 34m },
                    { 73, 143, 3, 20m },
                    { 7, 143, 2, 315m },
                    { 95, 143, 4, 614m },
                    { 54, 143, 3, 26m },
                    { 28, 143, 3, 7m },
                    { 20, 143, 5, 4m },
                    { 40, 143, 1, 9m },
                    { 44, 143, 3, 41m },
                    { 74, 142, 1, 10m },
                    { 31, 142, 1, 4m },
                    { 89, 144, 5, 6m },
                    { 64, 146, 2, 134m },
                    { 64, 144, 2, 701m },
                    { 81, 144, 2, 142m },
                    { 87, 146, 5, 22m },
                    { 11, 146, 3, 33m },
                    { 52, 146, 4, 194m },
                    { 53, 146, 3, 15m },
                    { 31, 146, 1, 16m },
                    { 92, 145, 2, 602m },
                    { 40, 145, 1, 50m },
                    { 2, 145, 2, 202m },
                    { 43, 145, 2, 476m },
                    { 42, 145, 3, 14m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 27, 145, 3, 40m },
                    { 12, 145, 2, 203m },
                    { 22, 145, 3, 33m },
                    { 91, 145, 2, 654m },
                    { 25, 145, 3, 31m },
                    { 89, 145, 5, 49m },
                    { 48, 145, 1, 47m },
                    { 4, 145, 3, 5m },
                    { 11, 145, 3, 30m },
                    { 70, 145, 1, 29m },
                    { 40, 144, 1, 20m },
                    { 5, 144, 5, 6m },
                    { 22, 144, 3, 9m },
                    { 61, 144, 1, 6m },
                    { 3, 133, 1, 9m },
                    { 92, 133, 2, 144m },
                    { 8, 133, 5, 1m },
                    { 87, 121, 5, 37m },
                    { 28, 121, 3, 25m },
                    { 96, 121, 1, 12m },
                    { 78, 120, 1, 47m },
                    { 93, 120, 2, 136m },
                    { 67, 120, 2, 344m },
                    { 13, 120, 1, 27m },
                    { 45, 120, 1, 4m },
                    { 58, 120, 4, 121m },
                    { 35, 120, 2, 111m },
                    { 31, 120, 1, 37m },
                    { 25, 120, 3, 40m },
                    { 87, 120, 5, 28m },
                    { 75, 120, 3, 9m },
                    { 3, 120, 1, 41m },
                    { 41, 120, 2, 628m },
                    { 71, 120, 2, 130m },
                    { 35, 119, 2, 426m },
                    { 28, 119, 3, 39m },
                    { 39, 119, 1, 38m },
                    { 43, 119, 2, 650m },
                    { 38, 119, 3, 6m },
                    { 45, 119, 1, 22m },
                    { 49, 121, 2, 221m },
                    { 86, 119, 2, 540m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 4, 121, 3, 32m },
                    { 29, 121, 3, 12m },
                    { 52, 123, 4, 711m },
                    { 31, 123, 1, 26m },
                    { 26, 123, 5, 37m },
                    { 14, 123, 4, 768m },
                    { 38, 123, 3, 37m },
                    { 36, 123, 1, 25m },
                    { 81, 122, 2, 488m },
                    { 65, 122, 4, 538m },
                    { 94, 122, 5, 36m },
                    { 82, 122, 3, 26m },
                    { 76, 122, 3, 8m },
                    { 24, 122, 5, 6m },
                    { 83, 122, 3, 8m },
                    { 60, 122, 1, 49m },
                    { 99, 122, 3, 3m },
                    { 80, 122, 3, 35m },
                    { 93, 121, 2, 242m },
                    { 6, 121, 3, 26m },
                    { 75, 121, 3, 6m },
                    { 81, 121, 2, 151m },
                    { 89, 121, 5, 46m },
                    { 68, 121, 2, 148m },
                    { 21, 121, 4, 681m },
                    { 67, 121, 2, 384m },
                    { 100, 123, 4, 607m },
                    { 76, 119, 3, 6m },
                    { 4, 119, 3, 27m },
                    { 24, 116, 5, 35m },
                    { 89, 116, 5, 8m },
                    { 91, 116, 2, 793m },
                    { 93, 116, 2, 178m },
                    { 84, 116, 2, 415m },
                    { 68, 116, 2, 665m },
                    { 37, 116, 3, 4m },
                    { 98, 115, 4, 675m },
                    { 11, 115, 3, 26m },
                    { 18, 115, 4, 658m },
                    { 34, 115, 5, 49m },
                    { 42, 115, 3, 22m },
                    { 23, 115, 2, 227m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 73, 115, 3, 50m },
                    { 99, 115, 3, 8m },
                    { 29, 115, 3, 35m },
                    { 36, 115, 1, 33m },
                    { 52, 115, 4, 466m },
                    { 1, 115, 3, 22m },
                    { 33, 114, 5, 26m },
                    { 100, 114, 4, 499m },
                    { 43, 114, 2, 486m },
                    { 93, 114, 2, 719m },
                    { 70, 116, 1, 22m },
                    { 11, 119, 3, 18m },
                    { 77, 116, 4, 459m },
                    { 10, 117, 4, 841m },
                    { 56, 119, 5, 34m },
                    { 17, 119, 4, 415m },
                    { 42, 119, 3, 18m },
                    { 82, 119, 3, 6m },
                    { 37, 119, 3, 18m },
                    { 30, 118, 3, 3m },
                    { 74, 118, 1, 16m },
                    { 46, 118, 3, 12m },
                    { 79, 118, 2, 319m },
                    { 72, 118, 5, 46m },
                    { 86, 118, 2, 679m },
                    { 17, 118, 4, 266m },
                    { 27, 118, 3, 20m },
                    { 33, 117, 5, 37m },
                    { 74, 117, 1, 9m },
                    { 53, 117, 3, 48m },
                    { 65, 117, 4, 180m },
                    { 62, 117, 1, 44m },
                    { 52, 117, 4, 252m },
                    { 21, 117, 4, 142m },
                    { 46, 117, 3, 45m },
                    { 70, 117, 1, 49m },
                    { 86, 117, 2, 279m },
                    { 59, 116, 4, 730m },
                    { 75, 114, 3, 25m },
                    { 5, 123, 5, 35m },
                    { 66, 123, 2, 514m },
                    { 77, 130, 4, 695m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 15, 130, 3, 39m },
                    { 87, 130, 5, 3m },
                    { 65, 130, 4, 509m },
                    { 20, 130, 5, 18m },
                    { 88, 130, 1, 29m },
                    { 99, 130, 3, 25m },
                    { 84, 130, 2, 368m },
                    { 27, 130, 3, 31m },
                    { 96, 130, 1, 23m },
                    { 95, 129, 4, 563m },
                    { 49, 129, 2, 707m },
                    { 7, 129, 2, 303m },
                    { 28, 129, 3, 42m },
                    { 25, 129, 3, 9m },
                    { 19, 129, 1, 41m },
                    { 10, 129, 4, 779m },
                    { 58, 129, 4, 724m },
                    { 49, 128, 2, 277m },
                    { 10, 128, 4, 239m },
                    { 33, 128, 5, 18m },
                    { 39, 128, 1, 27m },
                    { 74, 128, 1, 34m },
                    { 34, 130, 5, 26m },
                    { 44, 128, 3, 7m },
                    { 81, 130, 2, 707m },
                    { 23, 131, 2, 669m },
                    { 70, 132, 1, 28m },
                    { 64, 132, 2, 589m },
                    { 86, 132, 2, 780m },
                    { 32, 132, 4, 317m },
                    { 35, 132, 2, 656m },
                    { 73, 132, 3, 34m },
                    { 44, 132, 3, 47m },
                    { 42, 132, 3, 24m },
                    { 56, 132, 5, 18m },
                    { 41, 132, 2, 720m },
                    { 59, 132, 4, 795m },
                    { 60, 132, 1, 15m },
                    { 58, 132, 4, 821m },
                    { 100, 132, 4, 148m },
                    { 91, 131, 2, 324m },
                    { 90, 131, 1, 47m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 79, 131, 2, 752m },
                    { 97, 131, 2, 825m },
                    { 14, 131, 4, 774m },
                    { 59, 131, 4, 663m },
                    { 18, 131, 4, 261m },
                    { 43, 131, 2, 261m },
                    { 65, 131, 4, 755m },
                    { 16, 131, 1, 33m },
                    { 60, 123, 1, 26m },
                    { 23, 128, 2, 676m },
                    { 8, 128, 5, 23m },
                    { 27, 125, 3, 12m },
                    { 87, 125, 5, 35m },
                    { 76, 125, 3, 34m },
                    { 67, 125, 2, 705m },
                    { 10, 125, 4, 235m },
                    { 83, 125, 3, 4m },
                    { 98, 125, 4, 292m },
                    { 47, 125, 2, 243m },
                    { 75, 125, 3, 17m },
                    { 58, 125, 4, 436m },
                    { 28, 124, 3, 7m },
                    { 13, 124, 1, 10m },
                    { 80, 124, 3, 5m },
                    { 81, 124, 2, 113m },
                    { 7, 124, 2, 471m },
                    { 89, 124, 5, 40m },
                    { 16, 124, 1, 12m },
                    { 11, 124, 3, 44m },
                    { 24, 124, 5, 16m },
                    { 100, 124, 4, 725m },
                    { 56, 124, 5, 9m },
                    { 60, 124, 1, 10m },
                    { 7, 123, 2, 177m },
                    { 84, 125, 2, 406m },
                    { 92, 128, 2, 499m },
                    { 24, 125, 5, 21m },
                    { 71, 126, 2, 842m },
                    { 5, 128, 5, 39m },
                    { 36, 128, 1, 24m },
                    { 43, 128, 2, 772m },
                    { 55, 128, 5, 25m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 80, 127, 3, 45m },
                    { 36, 127, 1, 46m },
                    { 63, 127, 2, 143m },
                    { 5, 127, 5, 45m },
                    { 53, 127, 3, 28m },
                    { 44, 127, 3, 34m },
                    { 1, 127, 3, 47m },
                    { 49, 127, 2, 456m },
                    { 71, 127, 2, 457m },
                    { 55, 126, 5, 27m },
                    { 74, 126, 1, 19m },
                    { 59, 126, 4, 508m },
                    { 75, 126, 3, 25m },
                    { 72, 126, 5, 33m },
                    { 99, 126, 3, 11m },
                    { 29, 126, 3, 17m },
                    { 43, 126, 2, 378m },
                    { 69, 126, 2, 721m },
                    { 53, 126, 3, 16m },
                    { 44, 125, 3, 16m },
                    { 90, 77, 1, 39m },
                    { 54, 77, 3, 1m },
                    { 88, 76, 1, 5m },
                    { 63, 25, 2, 112m },
                    { 5, 25, 5, 4m },
                    { 30, 25, 3, 47m },
                    { 55, 25, 5, 25m },
                    { 23, 25, 2, 290m },
                    { 1, 25, 3, 28m },
                    { 48, 25, 1, 40m },
                    { 72, 25, 5, 45m },
                    { 2, 25, 2, 155m },
                    { 54, 25, 3, 21m },
                    { 12, 25, 2, 432m },
                    { 60, 25, 1, 9m },
                    { 44, 24, 3, 47m },
                    { 77, 24, 4, 635m },
                    { 11, 24, 3, 47m },
                    { 61, 24, 1, 23m },
                    { 48, 24, 1, 37m },
                    { 14, 24, 4, 715m },
                    { 65, 24, 4, 647m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 70, 24, 1, 40m },
                    { 69, 24, 2, 455m },
                    { 19, 24, 1, 1m },
                    { 51, 25, 5, 23m },
                    { 13, 26, 1, 7m },
                    { 8, 26, 5, 22m },
                    { 55, 26, 5, 4m },
                    { 72, 28, 5, 20m },
                    { 78, 28, 1, 41m },
                    { 52, 27, 4, 360m },
                    { 88, 27, 1, 47m },
                    { 51, 27, 5, 18m },
                    { 95, 27, 4, 402m },
                    { 79, 27, 2, 314m },
                    { 31, 27, 1, 21m },
                    { 10, 27, 4, 289m },
                    { 4, 27, 3, 22m },
                    { 57, 27, 5, 32m },
                    { 90, 27, 1, 17m },
                    { 86, 26, 2, 821m },
                    { 93, 26, 2, 327m },
                    { 28, 26, 3, 35m },
                    { 40, 26, 1, 19m },
                    { 97, 26, 2, 163m },
                    { 10, 26, 4, 681m },
                    { 82, 26, 3, 44m },
                    { 5, 26, 5, 23m },
                    { 24, 26, 5, 6m },
                    { 34, 26, 5, 19m },
                    { 44, 26, 3, 20m },
                    { 52, 24, 4, 272m },
                    { 8, 23, 5, 19m },
                    { 84, 23, 2, 167m },
                    { 77, 23, 4, 241m },
                    { 17, 21, 4, 319m },
                    { 10, 21, 4, 653m },
                    { 85, 20, 4, 706m },
                    { 97, 20, 2, 332m },
                    { 98, 20, 4, 145m },
                    { 54, 20, 3, 19m },
                    { 35, 20, 2, 324m },
                    { 10, 20, 4, 240m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 33, 20, 5, 33m },
                    { 8, 20, 5, 41m },
                    { 48, 20, 1, 7m },
                    { 37, 20, 3, 9m },
                    { 96, 20, 1, 22m },
                    { 95, 19, 4, 834m },
                    { 24, 19, 5, 3m },
                    { 21, 19, 4, 443m },
                    { 30, 19, 3, 16m },
                    { 82, 19, 3, 14m },
                    { 12, 19, 2, 100m },
                    { 5, 19, 5, 41m },
                    { 78, 19, 1, 27m },
                    { 6, 19, 3, 27m },
                    { 56, 19, 5, 35m },
                    { 18, 21, 4, 176m },
                    { 27, 28, 3, 41m },
                    { 93, 21, 2, 700m },
                    { 95, 21, 4, 642m },
                    { 59, 23, 4, 288m },
                    { 22, 23, 3, 35m },
                    { 26, 23, 5, 16m },
                    { 23, 23, 2, 673m },
                    { 55, 23, 5, 11m },
                    { 36, 23, 1, 31m },
                    { 96, 23, 1, 1m },
                    { 3, 23, 1, 2m },
                    { 48, 23, 1, 10m },
                    { 56, 22, 5, 42m },
                    { 89, 22, 5, 31m },
                    { 37, 22, 3, 38m },
                    { 22, 22, 3, 13m },
                    { 100, 22, 4, 108m },
                    { 81, 22, 2, 779m },
                    { 45, 22, 1, 8m },
                    { 49, 22, 2, 503m },
                    { 87, 22, 5, 12m },
                    { 23, 22, 2, 102m },
                    { 78, 22, 1, 49m },
                    { 21, 22, 4, 743m },
                    { 34, 21, 5, 13m },
                    { 47, 21, 2, 669m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 4, 21, 3, 12m },
                    { 59, 28, 4, 236m },
                    { 41, 28, 2, 663m },
                    { 68, 28, 2, 323m },
                    { 40, 36, 1, 4m },
                    { 87, 36, 5, 14m },
                    { 96, 36, 1, 29m },
                    { 46, 36, 3, 33m },
                    { 62, 36, 1, 42m },
                    { 18, 35, 4, 204m },
                    { 4, 35, 3, 21m },
                    { 51, 35, 5, 38m },
                    { 49, 35, 2, 452m },
                    { 93, 35, 2, 191m },
                    { 38, 35, 3, 36m },
                    { 60, 35, 1, 20m },
                    { 88, 35, 1, 38m },
                    { 86, 35, 2, 391m },
                    { 10, 35, 4, 647m },
                    { 91, 35, 2, 752m },
                    { 63, 35, 2, 282m },
                    { 92, 35, 2, 815m },
                    { 5, 35, 5, 6m },
                    { 36, 34, 1, 22m },
                    { 98, 34, 4, 391m },
                    { 40, 34, 1, 47m },
                    { 49, 34, 2, 295m },
                    { 84, 36, 2, 654m },
                    { 58, 34, 4, 709m },
                    { 88, 36, 1, 7m },
                    { 20, 36, 5, 4m },
                    { 19, 38, 1, 48m },
                    { 92, 38, 2, 178m },
                    { 71, 38, 2, 723m },
                    { 54, 38, 3, 3m },
                    { 43, 38, 2, 361m },
                    { 25, 38, 3, 10m },
                    { 47, 38, 2, 172m },
                    { 65, 38, 4, 428m },
                    { 98, 38, 4, 454m },
                    { 94, 38, 5, 30m },
                    { 56, 38, 5, 45m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 11, 37, 3, 11m },
                    { 4, 37, 3, 33m },
                    { 46, 37, 3, 10m },
                    { 62, 37, 1, 32m },
                    { 91, 37, 2, 697m },
                    { 92, 37, 2, 629m },
                    { 69, 37, 2, 281m },
                    { 56, 37, 5, 4m },
                    { 100, 37, 4, 524m },
                    { 29, 36, 3, 8m },
                    { 54, 36, 3, 12m },
                    { 50, 36, 1, 34m },
                    { 89, 36, 5, 34m },
                    { 84, 19, 2, 201m },
                    { 25, 34, 3, 19m },
                    { 20, 34, 5, 31m },
                    { 1, 31, 3, 30m },
                    { 39, 31, 1, 31m },
                    { 19, 30, 1, 44m },
                    { 43, 30, 2, 224m },
                    { 28, 30, 3, 46m },
                    { 79, 30, 2, 242m },
                    { 1, 30, 3, 24m },
                    { 15, 30, 3, 20m },
                    { 12, 30, 2, 434m },
                    { 82, 30, 3, 10m },
                    { 85, 30, 4, 503m },
                    { 71, 30, 2, 571m },
                    { 39, 30, 1, 29m },
                    { 3, 29, 1, 33m },
                    { 79, 29, 2, 352m },
                    { 31, 29, 1, 8m },
                    { 56, 29, 5, 3m },
                    { 42, 29, 3, 2m },
                    { 74, 29, 1, 16m },
                    { 69, 29, 2, 784m },
                    { 90, 29, 1, 9m },
                    { 47, 28, 2, 157m },
                    { 67, 28, 2, 138m },
                    { 43, 31, 2, 236m },
                    { 59, 34, 4, 517m },
                    { 71, 31, 2, 265m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 14, 31, 4, 348m },
                    { 63, 34, 2, 299m },
                    { 11, 34, 3, 38m },
                    { 35, 34, 2, 778m },
                    { 13, 33, 1, 41m },
                    { 35, 33, 2, 142m },
                    { 91, 33, 2, 658m },
                    { 92, 33, 2, 433m },
                    { 36, 33, 1, 38m },
                    { 8, 33, 5, 41m },
                    { 100, 33, 4, 571m },
                    { 27, 33, 3, 13m },
                    { 18, 33, 4, 714m },
                    { 16, 32, 1, 10m },
                    { 92, 32, 2, 197m },
                    { 47, 32, 2, 612m },
                    { 19, 32, 1, 33m },
                    { 73, 32, 3, 26m },
                    { 67, 32, 2, 425m },
                    { 27, 32, 3, 24m },
                    { 18, 32, 4, 676m },
                    { 63, 31, 2, 176m },
                    { 29, 31, 3, 46m },
                    { 16, 31, 1, 15m },
                    { 85, 31, 4, 208m },
                    { 48, 19, 1, 45m },
                    { 58, 19, 4, 415m },
                    { 89, 19, 5, 23m },
                    { 10, 8, 4, 746m },
                    { 7, 8, 2, 508m },
                    { 74, 8, 1, 33m },
                    { 45, 8, 1, 36m },
                    { 98, 8, 4, 343m },
                    { 48, 8, 1, 12m },
                    { 26, 8, 5, 37m },
                    { 17, 7, 4, 564m },
                    { 85, 7, 4, 793m },
                    { 15, 7, 3, 21m },
                    { 11, 7, 3, 44m },
                    { 56, 7, 5, 28m },
                    { 20, 7, 5, 12m },
                    { 79, 7, 2, 744m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 99, 7, 3, 22m },
                    { 26, 6, 5, 14m },
                    { 86, 6, 2, 640m },
                    { 56, 6, 5, 27m },
                    { 84, 6, 2, 789m },
                    { 31, 6, 1, 21m },
                    { 46, 6, 3, 9m },
                    { 35, 6, 2, 488m },
                    { 61, 6, 1, 19m },
                    { 30, 8, 3, 11m },
                    { 2, 6, 2, 774m },
                    { 17, 8, 4, 481m },
                    { 35, 8, 2, 547m },
                    { 21, 10, 4, 759m },
                    { 12, 10, 2, 588m },
                    { 35, 10, 2, 260m },
                    { 41, 10, 2, 450m },
                    { 6, 9, 3, 50m },
                    { 25, 9, 3, 37m },
                    { 86, 9, 2, 726m },
                    { 63, 9, 2, 336m },
                    { 56, 9, 5, 31m },
                    { 18, 9, 4, 739m },
                    { 75, 9, 3, 6m },
                    { 48, 9, 1, 14m },
                    { 87, 9, 5, 12m },
                    { 21, 9, 4, 488m },
                    { 85, 9, 4, 519m },
                    { 5, 9, 5, 25m },
                    { 83, 9, 3, 36m },
                    { 99, 9, 3, 46m },
                    { 17, 9, 4, 590m },
                    { 87, 8, 5, 27m },
                    { 69, 8, 2, 687m },
                    { 2, 8, 2, 741m },
                    { 85, 8, 4, 649m },
                    { 75, 8, 3, 18m },
                    { 68, 10, 2, 701m },
                    { 89, 6, 5, 11m },
                    { 45, 5, 1, 23m },
                    { 67, 3, 2, 726m },
                    { 31, 3, 1, 5m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 96, 2, 1, 28m },
                    { 61, 2, 1, 23m },
                    { 47, 2, 2, 731m },
                    { 72, 2, 5, 48m },
                    { 34, 2, 5, 10m },
                    { 3, 2, 1, 33m },
                    { 89, 2, 5, 3m },
                    { 76, 2, 3, 2m },
                    { 3, 1, 1, 9m },
                    { 6, 1, 3, 4m },
                    { 23, 1, 2, 140m },
                    { 11, 1, 3, 13m },
                    { 19, 1, 1, 41m },
                    { 15, 1, 3, 16m },
                    { 25, 1, 3, 39m },
                    { 2, 1, 2, 646m },
                    { 33, 1, 5, 42m },
                    { 80, 1, 3, 12m },
                    { 55, 1, 5, 43m },
                    { 96, 1, 1, 40m },
                    { 90, 1, 1, 15m },
                    { 28, 3, 3, 50m },
                    { 57, 6, 5, 39m },
                    { 37, 3, 3, 45m },
                    { 66, 3, 2, 544m },
                    { 39, 5, 1, 7m },
                    { 79, 5, 2, 323m },
                    { 38, 5, 3, 27m },
                    { 56, 5, 5, 31m },
                    { 83, 5, 3, 48m },
                    { 36, 5, 1, 47m },
                    { 68, 5, 2, 189m },
                    { 6, 5, 3, 16m },
                    { 33, 4, 5, 34m },
                    { 41, 4, 2, 742m },
                    { 17, 4, 4, 287m },
                    { 47, 4, 2, 240m },
                    { 10, 4, 4, 426m },
                    { 72, 4, 5, 24m },
                    { 58, 4, 4, 783m },
                    { 67, 4, 2, 133m },
                    { 16, 4, 1, 40m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 66, 4, 2, 120m },
                    { 28, 4, 3, 49m },
                    { 73, 4, 3, 6m },
                    { 9, 4, 4, 565m },
                    { 70, 3, 1, 46m },
                    { 7, 3, 2, 258m },
                    { 89, 3, 5, 31m },
                    { 99, 39, 3, 6m },
                    { 86, 10, 2, 762m },
                    { 94, 10, 5, 14m },
                    { 68, 16, 2, 248m },
                    { 4, 16, 3, 24m },
                    { 9, 16, 4, 196m },
                    { 82, 16, 3, 27m },
                    { 81, 16, 2, 415m },
                    { 99, 16, 3, 6m },
                    { 80, 16, 3, 10m },
                    { 37, 16, 3, 12m },
                    { 60, 15, 1, 14m },
                    { 81, 15, 2, 811m },
                    { 3, 15, 1, 43m },
                    { 31, 15, 1, 21m },
                    { 47, 15, 2, 156m },
                    { 28, 15, 3, 36m },
                    { 7, 15, 2, 358m },
                    { 24, 15, 5, 23m },
                    { 68, 15, 2, 419m },
                    { 5, 15, 5, 33m },
                    { 19, 15, 1, 48m },
                    { 69, 15, 2, 321m },
                    { 100, 15, 4, 144m },
                    { 58, 15, 4, 703m },
                    { 26, 15, 5, 1m },
                    { 23, 16, 2, 200m },
                    { 66, 14, 2, 187m },
                    { 86, 16, 2, 281m },
                    { 65, 16, 4, 298m },
                    { 82, 18, 3, 39m },
                    { 14, 18, 4, 300m },
                    { 12, 18, 2, 209m },
                    { 15, 18, 3, 19m },
                    { 47, 18, 2, 388m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 40, 18, 1, 38m },
                    { 52, 18, 4, 505m },
                    { 92, 18, 2, 566m },
                    { 25, 18, 3, 48m },
                    { 48, 18, 1, 6m },
                    { 18, 17, 4, 766m },
                    { 10, 17, 4, 265m },
                    { 79, 17, 2, 382m },
                    { 93, 17, 2, 339m },
                    { 54, 17, 3, 5m },
                    { 50, 17, 1, 14m },
                    { 29, 17, 3, 5m },
                    { 85, 17, 4, 757m },
                    { 26, 17, 5, 40m },
                    { 11, 17, 3, 27m },
                    { 92, 17, 2, 792m },
                    { 94, 17, 5, 40m },
                    { 89, 17, 5, 24m },
                    { 66, 16, 2, 100m },
                    { 23, 10, 2, 623m },
                    { 21, 14, 4, 611m },
                    { 55, 14, 5, 44m },
                    { 2, 12, 2, 610m },
                    { 59, 12, 4, 341m },
                    { 25, 12, 3, 35m },
                    { 49, 11, 2, 505m },
                    { 62, 11, 1, 45m },
                    { 57, 11, 5, 49m },
                    { 71, 11, 2, 383m },
                    { 31, 11, 1, 15m },
                    { 55, 11, 5, 32m },
                    { 60, 11, 1, 6m },
                    { 96, 11, 1, 22m },
                    { 58, 11, 4, 131m },
                    { 35, 11, 2, 222m },
                    { 61, 11, 1, 10m },
                    { 32, 11, 4, 337m },
                    { 28, 11, 3, 36m },
                    { 16, 11, 1, 28m },
                    { 45, 10, 1, 39m },
                    { 84, 10, 2, 682m },
                    { 92, 10, 2, 344m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 87, 10, 5, 35m },
                    { 37, 10, 3, 46m },
                    { 16, 10, 1, 14m },
                    { 16, 12, 1, 38m },
                    { 80, 14, 3, 33m },
                    { 96, 12, 1, 34m },
                    { 53, 12, 3, 20m },
                    { 68, 14, 2, 426m },
                    { 78, 14, 1, 29m },
                    { 52, 14, 4, 552m },
                    { 16, 14, 1, 28m },
                    { 37, 14, 3, 11m },
                    { 93, 14, 2, 721m },
                    { 97, 14, 2, 626m },
                    { 46, 14, 3, 32m },
                    { 89, 14, 5, 7m },
                    { 58, 14, 4, 234m },
                    { 19, 14, 1, 47m },
                    { 95, 13, 4, 325m },
                    { 56, 13, 5, 34m },
                    { 36, 13, 1, 23m },
                    { 25, 13, 3, 37m },
                    { 72, 13, 5, 19m },
                    { 27, 13, 3, 46m },
                    { 70, 13, 1, 23m },
                    { 85, 13, 4, 410m },
                    { 10, 13, 4, 275m },
                    { 24, 13, 5, 50m },
                    { 21, 13, 4, 130m },
                    { 92, 12, 2, 733m },
                    { 78, 12, 1, 43m },
                    { 96, 39, 1, 20m },
                    { 33, 39, 5, 6m },
                    { 25, 39, 3, 34m },
                    { 70, 65, 1, 34m },
                    { 23, 65, 2, 465m },
                    { 50, 65, 1, 41m },
                    { 95, 65, 4, 675m },
                    { 99, 65, 3, 47m },
                    { 88, 64, 1, 29m },
                    { 91, 64, 2, 749m },
                    { 64, 64, 2, 283m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 8, 64, 5, 33m },
                    { 34, 64, 5, 38m },
                    { 54, 64, 3, 43m },
                    { 4, 64, 3, 9m },
                    { 29, 64, 3, 4m },
                    { 87, 64, 5, 23m },
                    { 25, 64, 3, 40m },
                    { 27, 64, 3, 28m },
                    { 82, 64, 3, 44m },
                    { 10, 64, 4, 390m },
                    { 86, 64, 2, 113m },
                    { 52, 64, 4, 376m },
                    { 11, 63, 3, 19m },
                    { 43, 63, 2, 241m },
                    { 61, 63, 1, 30m },
                    { 84, 65, 2, 199m },
                    { 79, 63, 2, 847m },
                    { 17, 65, 4, 297m },
                    { 77, 65, 4, 732m },
                    { 85, 67, 4, 404m },
                    { 2, 67, 2, 216m },
                    { 70, 67, 1, 6m },
                    { 83, 67, 3, 40m },
                    { 66, 67, 2, 455m },
                    { 1, 67, 3, 8m },
                    { 69, 67, 2, 232m },
                    { 38, 66, 3, 18m },
                    { 61, 66, 1, 3m },
                    { 53, 66, 3, 28m },
                    { 11, 66, 3, 3m },
                    { 78, 66, 1, 50m },
                    { 63, 66, 2, 476m },
                    { 89, 66, 5, 11m },
                    { 6, 66, 3, 37m },
                    { 32, 66, 4, 422m },
                    { 17, 66, 4, 791m },
                    { 33, 65, 5, 39m },
                    { 64, 65, 2, 638m },
                    { 18, 65, 4, 256m },
                    { 93, 65, 2, 202m },
                    { 34, 65, 5, 27m },
                    { 31, 65, 1, 25m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 56, 65, 5, 14m },
                    { 75, 67, 3, 12m },
                    { 50, 63, 1, 14m },
                    { 22, 63, 3, 42m },
                    { 11, 61, 3, 5m },
                    { 42, 61, 3, 50m },
                    { 10, 60, 4, 749m },
                    { 79, 60, 2, 419m },
                    { 54, 60, 3, 6m },
                    { 72, 60, 5, 22m },
                    { 63, 60, 2, 655m },
                    { 95, 60, 4, 347m },
                    { 4, 60, 3, 2m },
                    { 29, 60, 3, 36m },
                    { 45, 60, 1, 41m },
                    { 20, 60, 5, 26m },
                    { 1, 60, 3, 30m },
                    { 41, 60, 2, 845m },
                    { 68, 60, 2, 528m },
                    { 91, 60, 2, 190m },
                    { 55, 59, 5, 13m },
                    { 10, 59, 4, 370m },
                    { 17, 59, 4, 273m },
                    { 4, 59, 3, 6m },
                    { 32, 59, 4, 220m },
                    { 20, 59, 5, 13m },
                    { 19, 59, 1, 24m },
                    { 52, 61, 4, 583m },
                    { 96, 63, 1, 11m },
                    { 74, 61, 1, 35m },
                    { 71, 61, 2, 272m },
                    { 10, 63, 4, 161m },
                    { 99, 63, 3, 10m },
                    { 51, 63, 5, 45m },
                    { 27, 63, 3, 50m },
                    { 21, 63, 4, 160m },
                    { 36, 63, 1, 48m },
                    { 71, 63, 2, 697m },
                    { 11, 62, 3, 18m },
                    { 30, 62, 3, 15m },
                    { 97, 62, 2, 181m },
                    { 73, 62, 3, 11m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 85, 62, 4, 806m },
                    { 32, 62, 4, 385m },
                    { 74, 62, 1, 45m },
                    { 79, 62, 2, 830m },
                    { 49, 62, 2, 399m },
                    { 71, 62, 2, 624m },
                    { 78, 62, 1, 14m },
                    { 81, 62, 2, 157m },
                    { 9, 61, 4, 391m },
                    { 97, 61, 2, 336m },
                    { 96, 61, 1, 21m },
                    { 87, 61, 5, 37m },
                    { 43, 61, 2, 199m },
                    { 41, 59, 2, 524m },
                    { 59, 67, 4, 723m },
                    { 90, 68, 1, 29m },
                    { 1, 74, 3, 24m },
                    { 69, 74, 2, 213m },
                    { 74, 74, 1, 48m },
                    { 7, 74, 2, 347m },
                    { 20, 74, 5, 41m },
                    { 50, 74, 1, 37m },
                    { 2, 74, 2, 789m },
                    { 74, 73, 1, 13m },
                    { 59, 73, 4, 402m },
                    { 26, 73, 5, 45m },
                    { 42, 73, 3, 20m },
                    { 25, 73, 3, 23m },
                    { 8, 73, 5, 34m },
                    { 64, 73, 2, 202m },
                    { 24, 73, 5, 25m },
                    { 70, 73, 1, 15m },
                    { 73, 73, 3, 11m },
                    { 55, 73, 5, 17m },
                    { 83, 73, 3, 28m },
                    { 54, 72, 3, 36m },
                    { 36, 72, 1, 26m },
                    { 18, 72, 4, 653m },
                    { 85, 72, 4, 333m },
                    { 51, 74, 5, 28m },
                    { 44, 72, 3, 13m },
                    { 16, 74, 1, 5m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 80, 75, 3, 49m },
                    { 80, 76, 3, 32m },
                    { 60, 76, 1, 25m },
                    { 58, 76, 4, 553m },
                    { 90, 76, 1, 46m },
                    { 38, 76, 3, 20m },
                    { 35, 76, 2, 416m },
                    { 5, 76, 5, 4m },
                    { 26, 76, 5, 45m },
                    { 66, 76, 2, 572m },
                    { 39, 76, 1, 25m },
                    { 43, 76, 2, 250m },
                    { 55, 75, 5, 30m },
                    { 49, 75, 2, 395m },
                    { 21, 75, 4, 734m },
                    { 59, 75, 4, 206m },
                    { 82, 75, 3, 18m },
                    { 88, 75, 1, 40m },
                    { 25, 75, 3, 45m },
                    { 81, 75, 2, 561m },
                    { 66, 75, 2, 233m },
                    { 89, 75, 5, 8m },
                    { 19, 75, 1, 43m },
                    { 51, 75, 5, 35m },
                    { 9, 75, 4, 425m },
                    { 99, 67, 3, 22m },
                    { 38, 72, 3, 21m },
                    { 53, 72, 3, 27m },
                    { 81, 69, 2, 121m },
                    { 48, 69, 1, 49m },
                    { 66, 69, 2, 766m },
                    { 49, 69, 2, 552m },
                    { 42, 69, 3, 18m },
                    { 15, 69, 3, 44m },
                    { 73, 69, 3, 41m },
                    { 71, 69, 2, 711m },
                    { 20, 69, 5, 10m },
                    { 32, 69, 4, 420m },
                    { 83, 69, 3, 7m },
                    { 65, 69, 4, 616m },
                    { 51, 69, 5, 16m },
                    { 89, 69, 5, 44m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 52, 69, 4, 695m },
                    { 15, 68, 3, 12m },
                    { 58, 68, 4, 288m },
                    { 61, 68, 1, 15m },
                    { 79, 68, 2, 555m },
                    { 51, 68, 5, 24m },
                    { 43, 68, 2, 124m },
                    { 64, 68, 2, 253m },
                    { 93, 68, 2, 309m },
                    { 1, 70, 3, 15m },
                    { 8, 72, 5, 5m },
                    { 50, 70, 1, 8m },
                    { 80, 70, 3, 46m },
                    { 3, 72, 1, 33m },
                    { 28, 71, 3, 9m },
                    { 88, 71, 1, 15m },
                    { 82, 71, 3, 36m },
                    { 27, 71, 3, 47m },
                    { 35, 71, 2, 842m },
                    { 9, 71, 4, 783m },
                    { 96, 71, 1, 11m },
                    { 76, 71, 3, 35m },
                    { 56, 71, 5, 26m },
                    { 54, 71, 3, 5m },
                    { 64, 71, 2, 252m },
                    { 79, 71, 2, 764m },
                    { 70, 70, 1, 18m },
                    { 94, 70, 5, 4m },
                    { 15, 70, 3, 29m },
                    { 52, 70, 4, 645m },
                    { 63, 70, 2, 355m },
                    { 28, 70, 3, 42m },
                    { 48, 70, 1, 31m },
                    { 13, 70, 1, 35m },
                    { 79, 70, 2, 774m },
                    { 5, 70, 5, 32m },
                    { 77, 70, 4, 457m },
                    { 50, 150, 1, 39m },
                    { 96, 59, 1, 11m },
                    { 70, 58, 1, 23m },
                    { 37, 45, 3, 19m },
                    { 33, 45, 5, 16m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 70, 45, 1, 27m },
                    { 57, 45, 5, 46m },
                    { 46, 45, 3, 34m },
                    { 64, 45, 2, 188m },
                    { 4, 45, 3, 48m },
                    { 74, 45, 1, 36m },
                    { 20, 45, 5, 23m },
                    { 80, 45, 3, 18m },
                    { 91, 44, 2, 823m },
                    { 79, 44, 2, 323m },
                    { 84, 44, 2, 824m },
                    { 99, 44, 3, 46m },
                    { 69, 44, 2, 505m },
                    { 31, 44, 1, 45m },
                    { 72, 44, 5, 4m },
                    { 70, 44, 1, 36m },
                    { 43, 44, 2, 177m },
                    { 11, 44, 3, 6m },
                    { 96, 44, 1, 6m },
                    { 27, 44, 3, 11m },
                    { 46, 44, 3, 25m },
                    { 23, 45, 2, 613m },
                    { 6, 43, 3, 38m },
                    { 1, 45, 3, 36m },
                    { 56, 46, 5, 44m },
                    { 16, 48, 1, 48m },
                    { 46, 48, 3, 42m },
                    { 83, 47, 3, 44m },
                    { 94, 47, 5, 46m },
                    { 22, 47, 3, 5m },
                    { 8, 47, 5, 23m },
                    { 31, 47, 1, 32m },
                    { 50, 47, 1, 48m },
                    { 66, 47, 2, 429m },
                    { 32, 47, 4, 323m },
                    { 6, 47, 3, 19m },
                    { 46, 47, 3, 8m },
                    { 72, 46, 5, 28m },
                    { 59, 46, 4, 265m },
                    { 38, 46, 3, 28m },
                    { 89, 46, 5, 5m },
                    { 28, 46, 3, 4m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 58, 46, 4, 639m },
                    { 6, 46, 3, 46m },
                    { 66, 46, 2, 337m },
                    { 46, 46, 3, 40m },
                    { 8, 46, 5, 31m },
                    { 4, 46, 3, 12m },
                    { 92, 46, 2, 556m },
                    { 81, 48, 2, 293m },
                    { 84, 43, 2, 269m },
                    { 90, 43, 1, 13m },
                    { 15, 41, 3, 12m },
                    { 31, 41, 1, 20m },
                    { 12, 41, 2, 808m },
                    { 2, 41, 2, 592m },
                    { 47, 41, 2, 532m },
                    { 58, 40, 4, 139m },
                    { 56, 40, 5, 8m },
                    { 40, 40, 1, 30m },
                    { 99, 40, 3, 34m },
                    { 94, 40, 5, 37m },
                    { 15, 40, 3, 4m },
                    { 59, 40, 4, 777m },
                    { 89, 40, 5, 16m },
                    { 20, 40, 5, 25m },
                    { 34, 40, 5, 22m },
                    { 42, 39, 3, 21m },
                    { 80, 39, 3, 31m },
                    { 68, 39, 2, 410m },
                    { 63, 39, 2, 183m },
                    { 41, 39, 2, 435m },
                    { 59, 39, 4, 373m },
                    { 88, 39, 1, 17m },
                    { 60, 39, 1, 31m },
                    { 9, 41, 4, 691m },
                    { 8, 43, 5, 29m },
                    { 82, 41, 3, 14m },
                    { 78, 41, 1, 9m },
                    { 68, 43, 2, 661m },
                    { 77, 43, 4, 804m },
                    { 72, 43, 5, 10m },
                    { 27, 43, 3, 12m },
                    { 23, 43, 2, 267m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 15, 43, 3, 44m },
                    { 92, 43, 2, 220m },
                    { 73, 43, 3, 45m },
                    { 42, 43, 3, 17m },
                    { 28, 43, 3, 16m },
                    { 4, 42, 3, 38m },
                    { 48, 42, 1, 10m },
                    { 97, 42, 2, 835m },
                    { 55, 42, 5, 23m },
                    { 9, 42, 4, 126m },
                    { 82, 42, 3, 31m },
                    { 79, 42, 2, 312m },
                    { 46, 42, 3, 22m },
                    { 78, 42, 1, 21m },
                    { 85, 42, 4, 146m },
                    { 8, 42, 5, 34m },
                    { 26, 42, 5, 25m },
                    { 22, 42, 3, 38m },
                    { 8, 41, 5, 6m },
                    { 37, 58, 3, 40m },
                    { 68, 48, 2, 182m },
                    { 35, 48, 2, 797m },
                    { 55, 56, 5, 23m },
                    { 31, 56, 1, 33m },
                    { 44, 56, 3, 30m },
                    { 69, 56, 2, 447m },
                    { 54, 56, 3, 30m },
                    { 24, 55, 5, 20m },
                    { 10, 55, 4, 177m },
                    { 73, 55, 3, 30m },
                    { 51, 55, 5, 49m },
                    { 60, 55, 1, 23m },
                    { 69, 55, 2, 110m },
                    { 62, 55, 1, 13m },
                    { 55, 55, 5, 47m },
                    { 79, 55, 2, 694m },
                    { 93, 55, 2, 791m },
                    { 76, 55, 3, 34m },
                    { 80, 54, 3, 2m },
                    { 97, 54, 2, 719m },
                    { 73, 54, 3, 36m },
                    { 100, 54, 4, 348m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 88, 54, 1, 23m },
                    { 91, 54, 2, 478m },
                    { 89, 54, 5, 37m },
                    { 98, 56, 4, 350m },
                    { 75, 54, 3, 4m },
                    { 5, 56, 5, 7m },
                    { 76, 56, 3, 20m },
                    { 89, 58, 5, 10m },
                    { 72, 58, 5, 7m },
                    { 81, 58, 2, 364m },
                    { 85, 58, 4, 693m },
                    { 34, 58, 5, 34m },
                    { 9, 58, 4, 235m },
                    { 33, 58, 5, 1m },
                    { 23, 58, 2, 367m },
                    { 68, 58, 2, 709m },
                    { 78, 58, 1, 21m },
                    { 84, 58, 2, 593m },
                    { 95, 58, 4, 748m },
                    { 55, 58, 5, 16m },
                    { 36, 57, 1, 2m },
                    { 65, 57, 4, 216m },
                    { 5, 57, 5, 36m },
                    { 39, 57, 1, 27m },
                    { 74, 57, 1, 11m },
                    { 89, 57, 5, 15m },
                    { 1, 57, 3, 46m },
                    { 100, 57, 4, 447m },
                    { 53, 57, 3, 1m },
                    { 93, 57, 2, 664m },
                    { 3, 56, 1, 22m },
                    { 42, 48, 3, 22m },
                    { 98, 54, 4, 307m },
                    { 4, 53, 3, 31m },
                    { 13, 51, 1, 23m },
                    { 94, 51, 5, 35m },
                    { 15, 51, 3, 25m },
                    { 80, 51, 3, 6m },
                    { 74, 50, 1, 36m },
                    { 90, 50, 1, 10m },
                    { 52, 50, 4, 590m },
                    { 87, 50, 5, 27m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[,]
                {
                    { 45, 50, 1, 9m },
                    { 99, 50, 3, 35m },
                    { 37, 50, 3, 29m },
                    { 9, 50, 4, 404m },
                    { 36, 49, 1, 5m },
                    { 24, 49, 5, 14m },
                    { 2, 49, 2, 803m },
                    { 12, 49, 2, 819m },
                    { 19, 49, 1, 28m },
                    { 55, 49, 5, 10m },
                    { 33, 49, 5, 25m },
                    { 7, 49, 2, 300m },
                    { 86, 48, 2, 242m },
                    { 7, 48, 2, 709m },
                    { 21, 48, 4, 495m },
                    { 35, 51, 2, 350m },
                    { 51, 54, 5, 24m },
                    { 70, 51, 1, 30m },
                    { 74, 51, 1, 8m },
                    { 97, 53, 2, 376m },
                    { 17, 53, 4, 288m },
                    { 98, 53, 4, 696m },
                    { 42, 53, 3, 9m },
                    { 20, 53, 5, 11m },
                    { 50, 53, 1, 11m },
                    { 24, 53, 5, 32m },
                    { 90, 53, 1, 24m },
                    { 51, 53, 5, 2m },
                    { 69, 52, 2, 142m },
                    { 43, 52, 2, 585m },
                    { 61, 52, 1, 37m },
                    { 29, 52, 3, 45m },
                    { 28, 52, 3, 4m },
                    { 64, 52, 2, 782m },
                    { 52, 52, 4, 628m },
                    { 33, 52, 5, 14m },
                    { 12, 52, 2, 199m },
                    { 78, 52, 1, 10m },
                    { 65, 52, 4, 589m },
                    { 83, 52, 3, 8m },
                    { 56, 52, 5, 42m },
                    { 51, 52, 5, 3m }
                });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[] { 81, 51, 2, 331m });

            migrationBuilder.InsertData(
                table: "RecipesIngredients",
                columns: new[] { "Ingredient_Id", "Recipe_Id", "MeasureUnit", "UnitQuantity" },
                values: new object[] { 8, 150, 5, 32m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 1, 30 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 1, 31 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 1, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 1, 57 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 1, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 1, 67 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 1, 70 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 1, 74 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 1, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 1, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 1, 89 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 1, 110 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 1, 115 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 1, 127 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 2, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 2, 41 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 2, 49 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 2, 67 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 2, 74 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 2, 87 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 2, 137 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 2, 139 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 2, 143 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 2, 145 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 2, 146 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 29 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 56 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 72 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 84 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 87 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 89 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 100 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 109 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 120 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 133 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 136 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 139 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 141 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 3, 150 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 21 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 27 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 35 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 37 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 46 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 53 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 59 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 79 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 97 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 100 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 101 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 102 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 103 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 108 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 119 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 121 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 135 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 144 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 4, 145 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 35 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 56 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 57 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 70 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 79 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 98 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 108 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 109 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 123 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 127 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 128 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 134 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 5, 144 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 6, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 6, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 6, 46 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 6, 47 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 6, 66 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 6, 87 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 6, 88 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 6, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 6, 101 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 6, 104 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 6, 106 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 6, 121 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 48 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 49 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 74 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 89 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 90 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 93 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 104 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 123 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 124 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 129 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 7, 143 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 20 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 23 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 33 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 41 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 46 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 47 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 72 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 73 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 79 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 89 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 113 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 114 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 128 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 133 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 137 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 141 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 149 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 8, 150 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 9, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 9, 41 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 9, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 9, 50 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 9, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 9, 61 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 9, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 9, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 9, 77 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 9, 96 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 9, 101 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 9, 137 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 9, 138 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 17 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 20 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 21 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 27 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 35 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 55 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 59 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 97 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 102 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 117 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 125 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 128 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 129 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 139 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 140 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 147 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 10, 149 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 17 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 24 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 34 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 37 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 44 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 61 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 66 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 109 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 112 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 115 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 119 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 124 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 133 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 135 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 138 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 145 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 146 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 11, 148 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 18 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 30 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 41 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 49 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 52 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 101 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 102 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 112 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 114 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 134 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 135 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 12, 145 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 13, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 13, 33 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 13, 51 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 13, 70 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 13, 78 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 13, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 13, 112 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 13, 120 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 13, 124 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 13, 134 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 14, 18 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 14, 24 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 14, 31 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 14, 106 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 14, 123 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 14, 131 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 14, 144 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 14, 148 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 15, 18 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 15, 30 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 15, 40 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 15, 41 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 15, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 15, 51 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 15, 68 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 15, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 15, 70 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 15, 104 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 15, 130 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 15, 146 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 12 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 31 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 32 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 48 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 74 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 97 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 103 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 111 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 124 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 16, 131 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 21 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 53 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 59 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 66 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 78 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 89 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 106 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 118 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 119 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 17, 141 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 17 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 21 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 32 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 33 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 35 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 72 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 86 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 94 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 115 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 131 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 135 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 18, 139 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 19, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 19, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 19, 24 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 19, 30 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 19, 32 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 19, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 19, 49 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 19, 59 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 19, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 19, 94 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 19, 98 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 19, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 19, 112 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 19, 129 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 34 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 36 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 40 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 53 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 59 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 74 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 87 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 96 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 130 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 134 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 20, 143 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 21, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 21, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 21, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 21, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 21, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 21, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 21, 48 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 21, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 21, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 21, 88 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 21, 97 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 21, 117 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 21, 121 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 22, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 22, 23 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 22, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 22, 47 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 22, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 22, 89 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 22, 138 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 22, 143 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 22, 144 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 22, 145 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 23 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 104 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 105 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 106 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 115 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 128 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 131 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 133 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 139 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 23, 149 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 49 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 53 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 55 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 73 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 97 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 100 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 101 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 107 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 109 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 116 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 122 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 124 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 125 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 24, 135 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 12 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 18 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 34 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 39 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 73 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 103 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 106 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 107 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 113 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 120 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 129 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 145 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 147 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 25, 149 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 17 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 23 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 73 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 77 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 83 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 84 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 103 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 105 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 123 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 26, 140 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 28 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 32 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 33 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 44 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 87 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 89 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 90 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 100 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 118 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 125 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 130 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 142 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 27, 145 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 3 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 30 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 46 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 52 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 70 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 86 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 90 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 98 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 100 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 110 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 119 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 121 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 124 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 129 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 137 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 143 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 28, 144 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 29, 17 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 29, 31 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 29, 36 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 29, 52 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 29, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 29, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 29, 89 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 29, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 29, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 29, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 29, 105 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 29, 115 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 29, 121 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 29, 126 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 30, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 30, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 30, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 30, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 30, 100 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 30, 101 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 30, 118 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 30, 133 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 30, 134 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 30, 137 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 3 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 6 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 27 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 29 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 41 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 44 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 47 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 56 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 120 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 123 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 142 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 146 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 148 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 31, 149 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 32, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 32, 47 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 32, 59 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 32, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 32, 66 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 32, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 32, 94 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 32, 132 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 33, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 33, 20 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 33, 39 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 33, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 33, 49 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 33, 52 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 33, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 33, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 33, 84 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 33, 100 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 33, 114 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 33, 117 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 33, 128 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 34, 2 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 34, 21 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 34, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 34, 40 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 34, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 34, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 34, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 34, 115 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 34, 130 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 6 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 20 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 33 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 34 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 48 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 51 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 97 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 111 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 113 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 114 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 119 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 120 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 132 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 141 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 142 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 35, 149 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 5 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 23 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 33 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 34 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 49 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 57 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 72 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 78 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 79 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 103 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 115 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 123 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 127 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 128 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 36, 134 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 3 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 20 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 50 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 83 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 98 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 101 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 105 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 108 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 116 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 119 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 143 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 37, 148 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 38, 5 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 38, 35 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 38, 46 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 38, 66 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 38, 72 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 38, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 38, 109 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 38, 119 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 38, 123 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 38, 148 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 39, 5 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 39, 30 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 39, 31 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 39, 57 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 39, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 39, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 39, 88 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 39, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 39, 96 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 39, 102 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 39, 103 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 39, 108 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 39, 119 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 39, 128 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 18 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 34 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 36 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 40 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 77 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 84 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 103 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 104 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 105 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 106 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 139 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 140 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 141 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 143 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 144 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 40, 145 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 28 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 39 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 59 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 83 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 86 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 120 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 132 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 133 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 139 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 149 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 41, 150 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 29 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 39 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 48 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 53 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 61 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 73 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 84 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 96 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 102 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 111 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 115 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 119 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 132 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 144 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 145 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 42, 150 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 30 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 31 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 44 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 52 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 61 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 68 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 79 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 83 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 84 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 94 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 110 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 114 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 119 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 126 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 128 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 131 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 144 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 43, 145 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 24 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 56 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 72 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 79 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 84 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 88 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 103 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 105 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 109 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 125 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 127 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 128 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 132 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 133 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 134 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 136 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 44, 143 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 5 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 50 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 79 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 86 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 88 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 110 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 111 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 112 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 113 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 119 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 120 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 139 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 45, 140 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 6 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 36 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 37 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 44 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 46 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 47 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 48 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 89 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 106 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 107 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 109 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 117 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 118 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 46, 140 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 47, 2 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 47, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 47, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 47, 18 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 47, 21 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 47, 28 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 47, 32 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 47, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 47, 41 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 47, 84 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 47, 101 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 47, 125 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 47, 140 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 47, 148 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 47, 150 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 18 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 20 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 23 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 24 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 70 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 88 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 104 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 137 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 140 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 143 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 145 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 48, 146 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 34 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 35 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 79 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 87 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 111 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 121 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 127 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 128 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 129 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 136 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 49, 142 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 17 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 36 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 47 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 53 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 70 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 74 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 88 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 100 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 107 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 111 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 112 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 113 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 133 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 135 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 50, 150 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 27 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 35 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 52 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 53 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 54 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 55 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 68 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 74 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 88 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 96 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 112 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 137 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 142 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 51, 147 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 18 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 24 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 27 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 50 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 52 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 61 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 70 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 78 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 103 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 104 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 115 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 117 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 123 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 135 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 52, 146 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 53, 12 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 53, 57 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 53, 66 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 53, 72 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 53, 79 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 53, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 53, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 53, 89 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 53, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 53, 106 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 53, 117 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 53, 126 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 53, 127 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 53, 146 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 53, 150 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 17 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 20 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 36 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 56 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 72 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 77 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 87 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 89 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 96 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 97 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 54, 143 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 23 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 49 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 55 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 56 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 59 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 73 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 78 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 86 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 100 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 103 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 126 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 128 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 55, 134 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 5 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 6 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 7 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 29 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 37 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 40 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 46 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 52 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 90 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 102 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 108 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 119 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 124 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 132 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 142 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 56, 149 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 57, 6 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 57, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 57, 27 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 57, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 57, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 57, 102 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 57, 110 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 57, 112 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 34 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 40 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 46 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 68 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 93 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 94 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 98 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 106 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 120 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 125 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 129 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 132 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 134 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 58, 150 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 12 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 23 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 28 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 34 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 39 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 40 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 46 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 67 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 73 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 84 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 87 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 88 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 90 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 94 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 105 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 107 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 116 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 126 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 131 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 59, 132 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 35 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 39 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 55 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 109 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 122 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 123 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 124 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 132 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 134 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 135 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 60, 147 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 61, 2 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 61, 6 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 61, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 61, 24 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 61, 52 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 61, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 61, 66 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 61, 68 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 61, 139 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 61, 144 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 61, 150 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 62, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 62, 36 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 62, 37 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 62, 55 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 62, 77 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 62, 79 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 62, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 62, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 62, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 62, 96 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 62, 105 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 62, 117 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 62, 139 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 62, 140 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 31 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 34 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 35 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 39 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 66 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 70 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 78 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 98 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 127 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 135 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 149 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 63, 150 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 64, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 64, 52 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 64, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 64, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 64, 68 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 64, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 64, 73 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 64, 132 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 64, 144 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 64, 146 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 24 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 52 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 57 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 102 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 107 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 109 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 111 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 113 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 117 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 122 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 130 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 131 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 136 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 137 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 139 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 65, 147 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 3 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 46 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 47 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 67 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 106 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 112 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 123 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 139 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 147 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 66, 148 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 67, 3 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 67, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 67, 28 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 67, 32 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 67, 120 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 67, 121 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 67, 125 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 67, 136 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 67, 138 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 5 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 28 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 39 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 48 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 83 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 84 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 101 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 116 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 121 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 68, 147 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 24 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 29 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 37 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 44 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 52 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 55 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 56 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 67 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 74 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 78 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 105 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 126 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 137 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 138 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 69, 147 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 3 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 24 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 44 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 51 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 67 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 70 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 73 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 90 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 116 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 117 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 132 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 136 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 137 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 143 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 144 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 145 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 70, 147 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 30 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 31 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 61 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 86 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 108 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 120 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 126 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 127 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 133 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 137 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 146 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 71, 149 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 2 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 28 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 44 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 46 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 77 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 97 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 103 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 106 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 110 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 111 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 112 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 118 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 72, 126 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 32 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 54 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 55 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 73 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 78 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 87 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 101 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 108 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 115 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 132 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 143 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 147 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 73, 150 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 29 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 50 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 51 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 57 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 61 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 73 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 74 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 93 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 100 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 117 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 118 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 126 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 128 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 135 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 74, 142 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 54 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 67 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 83 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 84 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 90 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 107 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 114 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 120 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 121 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 125 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 126 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 137 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 146 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 75, 149 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 76, 2 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 76, 55 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 76, 56 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 76, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 76, 100 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 76, 109 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 76, 119 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 76, 122 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 76, 125 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 76, 137 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 76, 139 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 76, 140 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 76, 146 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 77, 23 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 77, 24 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 77, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 77, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 77, 70 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 77, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 77, 103 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 77, 106 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 77, 116 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 77, 130 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 77, 147 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 12 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 28 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 41 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 52 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 66 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 84 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 93 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 94 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 104 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 108 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 109 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 110 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 111 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 78, 120 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 5 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 7 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 17 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 27 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 29 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 30 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 44 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 55 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 68 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 70 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 83 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 88 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 96 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 107 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 113 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 118 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 79, 131 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 1 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 39 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 51 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 54 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 70 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 102 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 109 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 112 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 122 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 124 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 127 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 136 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 148 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 80, 150 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 48 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 51 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 78 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 97 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 98 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 110 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 113 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 121 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 122 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 124 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 130 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 141 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 142 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 81, 144 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 18 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 30 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 41 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 98 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 119 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 122 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 133 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 82, 136 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 5 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 47 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 52 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 67 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 73 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 96 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 102 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 103 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 111 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 112 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 122 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 125 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 133 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 141 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 142 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 83, 146 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 6 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 23 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 36 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 44 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 87 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 97 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 104 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 105 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 110 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 116 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 125 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 130 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 84, 139 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 7 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 17 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 20 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 30 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 31 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 67 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 72 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 93 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 137 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 85, 142 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 6 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 35 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 48 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 93 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 101 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 104 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 105 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 107 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 117 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 118 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 119 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 132 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 86, 144 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 36 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 50 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 61 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 77 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 106 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 120 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 121 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 125 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 130 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 137 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 146 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 87, 149 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 88, 27 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 88, 35 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 88, 36 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 88, 39 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 88, 54 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 88, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 88, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 88, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 88, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 88, 86 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 88, 87 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 88, 98 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 88, 102 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 88, 111 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 88, 130 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 2 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 3 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 6 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 17 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 36 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 40 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 46 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 54 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 57 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 66 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 98 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 107 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 116 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 121 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 124 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 144 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 145 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 89, 148 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 90, 1 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 90, 27 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 90, 29 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 90, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 90, 50 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 90, 53 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 90, 68 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 90, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 90, 77 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 90, 78 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 90, 86 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 90, 93 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 90, 104 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 90, 131 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 90, 136 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 91, 33 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 91, 35 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 91, 37 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 91, 44 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 91, 54 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 91, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 91, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 91, 86 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 91, 88 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 91, 104 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 91, 106 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 91, 116 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 91, 131 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 91, 138 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 91, 145 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 12 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 17 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 18 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 32 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 33 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 35 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 37 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 46 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 93 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 94 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 104 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 108 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 128 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 133 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 138 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 92, 145 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 17 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 21 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 35 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 55 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 57 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 68 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 79 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 94 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 96 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 114 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 116 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 120 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 121 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 138 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 93, 150 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 94, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 94, 17 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 94, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 94, 40 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 94, 47 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 94, 51 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 94, 70 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 94, 88 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 94, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 94, 96 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 94, 122 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 94, 148 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 95, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 95, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 95, 21 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 95, 27 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 95, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 95, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 95, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 95, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 95, 105 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 95, 129 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 95, 135 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 95, 143 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 1 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 2 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 12 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 20 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 23 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 36 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 39 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 44 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 59 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 61 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 121 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 130 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 136 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 96, 150 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 20 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 53 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 54 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 61 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 83 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 84 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 90 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 110 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 131 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 139 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 97, 140 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 98, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 98, 20 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 98, 34 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 98, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 98, 53 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 98, 54 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 98, 56 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 98, 90 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 98, 100 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 98, 102 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 98, 109 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 98, 115 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 98, 125 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 98, 144 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 7 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 39 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 40 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 44 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 50 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 67 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 87 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 109 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 115 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 122 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 126 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 130 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 136 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 99, 138 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 33 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 37 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 54 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 57 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 86 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 88 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 112 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 114 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 123 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 124 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 132 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 138 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 140 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 141 });

            migrationBuilder.DeleteData(
                table: "RecipesIngredients",
                keyColumns: new[] { "Ingredient_Id", "Recipe_Id" },
                keyValues: new object[] { 100, 149 });

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitQuantity",
                table: "RecipesIngredients",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitQuantity",
                table: "Ingredients",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "Ingredients",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostIngredient",
                table: "Ingredients",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice" },
                values: new object[] { 2000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "Oil", 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice" },
                values: new object[] { 1000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "Water", 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sugar", 2m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Flour", 2m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 8m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Chocolate", 2m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rice", 2m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 8m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Spaghetti", 2m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitQuantity" },
                values: new object[] { 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Chicken", 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Avocado", 2m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Salt", 2m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Banana", 2m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Apple", 2m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsDeleted", "MeasureUnit", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "Mayonnaise", 2m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CostIngredient", "CreatedAt", "IsDeleted", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { 8m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bread", 2m, 4m });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
