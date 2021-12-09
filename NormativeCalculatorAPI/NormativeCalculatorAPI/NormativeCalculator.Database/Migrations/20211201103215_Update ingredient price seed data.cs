using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Infrastructure.Migrations
{
    public partial class Updateingredientpriceseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 38m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 3, 0.038m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 14m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 1, 0.0035m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 4, 4.5m, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 39m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 4, 6.5m, 6m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 5m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 5, 5m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 50m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 2, 10m, 5m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 45m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 0.005m, 9m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice" },
                values: new object[] { 41m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 41m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 2.25m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 49m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 5, 7m, 7m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 13m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 3, 0.0065m, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 23m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 4, 7.666666666666667m, 3m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 18m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 2, 9m, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 14m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 3, 0.00175m, 8m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 17m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 2, 1.8888888888888888m, 9m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 28m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 5, 3.111111111111111m, 9m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 39m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 1, 0.005571428571428572m, 7m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 25m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 5, 3.125m, 8m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 47m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 5.875m, 8m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 40m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 5, 40m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 8m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 1, 0.0026666666666666666m, 3m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 22m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 2, 2.2m, 10m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 49m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 3, 0.008166666666666666m, 6m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 15m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 2, 1.5m, 10m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 18m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 3, 0.018m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 2, 0.1m, 10m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 6m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 2, 0.6m, 10m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 33m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 5, 11m, 3m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 26m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 3, 0.0028888888888888888m, 9m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 46m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 5, 5.75m, 8m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitQuantity" },
                values: new object[] { 7m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 2, 7m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 36m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 3, 0.012m, 3m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 8m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 4, 4m, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 39m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 3, 0.00975m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 28m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 3, 0.014m, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 28m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 5, 9.333333333333334m, 3m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 44m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 7.333333333333333m, 6m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 20m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 1, 0.006666666666666667m, 3m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 17m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 3, 0.0028333333333333335m, 6m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 17m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 4.25m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 45m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 5, 11.25m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 49m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 0.0049m, 10m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 50m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 2, 6.25m, 8m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 16m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 1, 0.005333333333333333m, 3m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 20m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 1, 0.004m, 5m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 6m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 4, 2m, 3m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 11m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 2, 2.75m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 32m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 4, 3.2m, 10m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 32m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 4, 5.333333333333333m, 6m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice" },
                values: new object[] { 43m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 0.043m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 5m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 2, 1.6666666666666667m, 3m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 16m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 1, 0.002m, 8m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 32m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 3.2m, 10m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 20m, new DateTime(2021, 12, 1, 10, 29, 53, 24, DateTimeKind.Utc), 4, 10m, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.0001m, 10m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 42m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 4, 10.5m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 39m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 3, 0.0065m, 6m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 18m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 4, 3.6m, 5m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 21m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 3, 0.002625m, 8m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 43m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 5, 10.75m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 31m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 15.5m, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 19m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.019m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 39m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.013m, 3m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 40m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 5m, 8m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 16m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 0.0016m, 10m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 26m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.0037142857142857142m, 7m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 25m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 3, 0.003125m, 8m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 18m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 2, 3.6m, 5m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 2m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.002m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 3m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.000375m, 8m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 8m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 4, 2.6666666666666665m, 3m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 5m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.0025m, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 2m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1m, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 4, 1.5m, 6m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 47m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 3, 0.005222222222222222m, 9m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 4, 0.1m, 10m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 48m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 3, 0.048m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 20m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 4, 2.5m, 8m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 49m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.008166666666666666m, 6m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 4, 0.5m, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 20m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 3, 0.002857142857142857m, 7m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 35m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.011666666666666667m, 3m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 44m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 4, 22m, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 28m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.028m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitQuantity" },
                values: new object[] { 10m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 4, 10m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 31m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.010333333333333333m, 3m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 15m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.00375m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 46m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.005111111111111111m, 9m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 38m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 2, 4.222222222222222m, 9m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 34m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.017m, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 50m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.0125m, 4m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 48m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 2, 4.8m, 10m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 21m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 4, 10.5m, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 38m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 4, 12.666666666666666m, 3m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 39m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.013m, 3m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 31m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 15.5m, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 8m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 5, 0.8888888888888888m, 9m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 26m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 4, 26m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 16m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 1, 0.008m, 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 6m, new DateTime(2021, 12, 1, 10, 29, 53, 25, DateTimeKind.Utc), 0.0015m, 4m });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 6m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 5m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2, 5m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 10000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 1, 10m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 3m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 3m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 10000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 10m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 1, 9m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 1m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice" },
                values: new object[] { 2m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 6m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 4m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 4m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 5000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 1, 5m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 7m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 7m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 8m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 8m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 6m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 1m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 3m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2, 3m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2, 1m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 1m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 8m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 8m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2, 6m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 3000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 3m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 4000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 4m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 9m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 10m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 10m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 5m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2, 5m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 9m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 2000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 1, 2m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2, 6m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 10m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 10m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 10000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 10m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitQuantity" },
                values: new object[] { 1m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 10m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 10m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 1m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 4m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 4m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 4000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 1, 4m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 9m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 6m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 9m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 10000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 1, 10m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 6m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 1, 1m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 2000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 4m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 4m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 7m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 7m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 9m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 9m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 6m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 7000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 7m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 2m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 2m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice" },
                values: new object[] { 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 8000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 1, 8m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 7m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2, 7m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 3m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 4m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2, 4m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 4m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 4m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 10m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2, 10m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 5000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 1, 5m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 3m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 3m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 5m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 5m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2, 9m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 3m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 7m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 7m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 4000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 4m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 6m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 5000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 8m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2, 8m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 2m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2, 2m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 9m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 6m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 5000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 5m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 5000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 1, 5m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 6000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 6m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 6m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 4000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 4m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 1, 9m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 2m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 2m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 9000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 1, 9m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 8000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 8m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 2000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 2m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 3m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2, 3m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 1, 1m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 5m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 5m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 5m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2, 5m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 7m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 7m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitQuantity" },
                values: new object[] { 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 8m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 8m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 1m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 9m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 4000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 4m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 6000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 6m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 9m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 1m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 1m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 4000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 3, 4m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 1m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 1m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 2m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 2m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 9m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 4, 9m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice" },
                values: new object[] { 6m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 6m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CostIngredient", "CreatedAt", "MeasureUnit", "UnitPrice", "UnitQuantity" },
                values: new object[] { 2m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 5, 2m, 1m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CostIngredient", "CreatedAt", "UnitPrice", "UnitQuantity" },
                values: new object[] { 7000m, new DateTime(2021, 11, 29, 12, 45, 24, 619, DateTimeKind.Utc), 7m, 1m });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
