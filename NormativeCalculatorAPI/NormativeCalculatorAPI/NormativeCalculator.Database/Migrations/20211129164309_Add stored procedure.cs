using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Infrastructure.Migrations
{
    public partial class Addstoredprocedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                IF OBJECT_ID (N'dbo.CalculateIngredientCost', N'FN') IS NOT NULL  
                    DROP FUNCTION CalculateIngredientCost;  
                GO  
                CREATE FUNCTION dbo.CalculateIngredientCost(@UnitQuantity float,@MeasureUnit_Id float,@Ingredient_Id float)  
                RETURNS float(10)   
                AS   
                BEGIN  
                    DECLARE @TotalCost float(10);  
                    DECLARE @Price float(10); 
                    DECLARE @ParsedUnitQuantity float(10);  
	
	                 IF (@MeasureUnit_Id = 1 Or @MeasureUnit_Id = 3) 
	                 begin
                        SET @ParsedUnitQuantity = @UnitQuantity*1000; 
		                end
		                Else
		                begin
		                 SET @ParsedUnitQuantity = @UnitQuantity;
		                end
		
                    SELECT @Price = i.CostIngredient from Ingredients as i 
	                WHERE i.Id = @Ingredient_Id;

	                SET @TotalCost = (@Price/1000) * @ParsedUnitQuantity
                     IF (@TotalCost IS NULL)   
                        SET @TotalCost = 0;  
                   RETURN ROUND(@TotalCost/1000,2)
                END

           ");

            migrationBuilder.Sql(@"  
                CREATE PROCEDURE GetRecipesWithAtLeast10Ingredients
                AS BEGIN 

                SELECT  r.Id,r.Name,COUNT(distinct ri.Ingredient_Id) as NumberOfIngridients,
                 ROUND(Sum(dbo.CalculateIngredientCost(ri.UnitQuantity,ri.MeasureUnit,ri.Ingredient_Id)),2) as TotalCost
                FROM  Recipes as r JOIN RecipesIngredients as ri
                ON r.Id = ri.Recipe_Id
                GROUP BY r.Id,r.Name
                HAVING COUNT(distinct ri.Ingredient_Id) >=10

                END 
            ");

            migrationBuilder.Sql(@"  
                CREATE PROCEDURE GetRecipesOrderByCostRecipeGroupByCategory
                AS BEGIN

                SELECT c.CategoryName, r.Name, ROUND(Sum(dbo.CalculateIngredientCost(ri.UnitQuantity,ri.MeasureUnit,ri.Ingredient_Id)),2) as RecipeCost
                FROM Recipes as r INNER JOIN RecipeCategories as c
                ON r.RecipeCategory_Id=c.Id INNER JOIN RecipesIngredients ri ON ri.Recipe_Id=r.Id
                GROUP BY c.CategoryName,r.Name 
                ORDER BY c.CategoryName, RecipeCost DESC

                END
            ");

            migrationBuilder.Sql(@"  
                CREATE PROCEDURE GetMostUsedIngredients @measureType int, @minQuantity float, @maxQuantity float
                AS BEGIN
  
                SELECT TOP 10 i.Name,  COUNT(ri.Ingredient_Id) AS UsageCount
                FROM Ingredients as i INNER JOIN RecipesIngredients as ri
                ON  i.id = ri.Ingredient_Id  
                WHERE @measureType=ri.MeasureUnit AND (ri.UnitQuantity BETWEEN @minQuantity AND @maxQuantity)
                GROUP BY i.Name
                ORDER BY UsageCount DESC

                END
            ");

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("Drop function CalculateIngredientCost");

            migrationBuilder.Sql("Drop procedure GetRecipesWithAtLeast10Ingredients");

            migrationBuilder.Sql("Drop procedure GetRecipesOrderByCostRecipeGroupByCategory");

            migrationBuilder.Sql("Drop procedure GetMostUsedIngredients");

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
        }
    }
}
