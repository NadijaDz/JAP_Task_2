using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;
using NormativeCalculator.Common.Enums;
using NormativeCalculator.Core;
using NormativeCalculator.Core.Helper;
using NormativeCalculator.Core.Models.Request;
using NormativeCalculator.Database;
using NormativeCalculator.Mapper.Mapping;
using NormativeCalculator.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormativeCalculator.NUnitTest
{
    [TestFixture]
    public class RecipeNUnitTests
    {
        private RecipeService _recipeService;

        private NormativeCalculatorDBContext _context;

        private IMapper mapperMock;

        private DbContextOptions<NormativeCalculatorDBContext> _options;

        private Mock<IUserService> _userService;

        [OneTimeSetUp]
        public void SetUp()
        {
            _options = new DbContextOptionsBuilder<NormativeCalculatorDBContext>()
              .UseInMemoryDatabase(databaseName: "TempNormativeCalculator").Options;
            _context = new NormativeCalculatorDBContext(_options);

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new NormativeCalculatorProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            mapperMock = mapper;

            _userService = new Mock<IUserService>();
            _userService.Setup(x => x.GetLoggedInUser()).Returns(Task.FromResult(new IdentityUser()
            {
                Id = Guid.NewGuid().ToString()
            }));

            _recipeService = new RecipeService(_context, mapperMock, _userService.Object);

            _context.RecipeCategories.Add(new RecipeCategory
            {
                Id = 5,
                CategoryName = "Category 1"

            });

            for (int i = 0; i < 18; i++)
            {
                _context.Recipes.Add(new Recipe
                {
                    Id = i + 1,
                    RecipeCategory_Id = 5
                });
            }

            _context.Ingredients.Add(new Ingredient
            {
                Id = 1,
                UnitPrice = (decimal)0.0035,
                UnitQuantity = 4,
                CostIngredient = 14,
                MeasureUnit = MeasureUnit.kg
            });

            _context.Ingredients.Add(new Ingredient
            {
                Id = 2,
                UnitPrice = (decimal)0.04,
                UnitQuantity = 2,
                CostIngredient = 9,
                MeasureUnit = MeasureUnit.ml

            });
            _context.Ingredients.Add(new Ingredient
            {
                Id = 3,
                UnitPrice = (decimal)0.04,
                UnitQuantity = 2,
                CostIngredient = 9,
                MeasureUnit = MeasureUnit.ml

            });
            _context.Ingredients.Add(new Ingredient
            {
                Id = 4,
                UnitPrice = (decimal)0.04,
                UnitQuantity = 2,
                CostIngredient = 9,
                MeasureUnit = MeasureUnit.ml

            });
            _context.Ingredients.Add(new Ingredient
            {
                Id = 5,
                UnitPrice = (decimal)0.04,
                UnitQuantity = 2,
                CostIngredient = 9,
                MeasureUnit = MeasureUnit.ml

            });

            _context.RecipesIngredients.Add(new RecipeIngredient
            {
                Recipe_Id = 1,
                Ingredient_Id = 1,
                UnitQuantity = 500,
                MeasureUnit = MeasureUnit.gr
            });

            _context.RecipesIngredients.Add(new RecipeIngredient
            {
                Recipe_Id = 1,
                Ingredient_Id = 2,
                UnitQuantity = 5,
                MeasureUnit = MeasureUnit.L
            });

            _context.SaveChanges();

        }

        // ** Test add new recipe is working properly **
        [Test]
        public void InsertRecipeAsync_InputRequestRecipeWithMultipleIngredients_GetCorrectInsert()
        {
            //arrange
            var request = new AddRecipeRequest
            {
                Name = "Recipe 1",
                Description = "Description for Recipe 1",
                RecipeCategory_Id = 5,
                CreatedAt = DateTime.Now,
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient {
                    Ingredient_Id = 1,
                    MeasureUnit = Common.Enums.MeasureUnit.kg,
                    UnitQuantity = 15,
                    },
                    new RecipeIngredient {
                    Ingredient_Id = 2,
                    MeasureUnit = Common.Enums.MeasureUnit.L,
                    UnitQuantity = 10,
                    },
                    new RecipeIngredient {
                    Ingredient_Id = 3,
                    MeasureUnit = Common.Enums.MeasureUnit.gr,
                    UnitQuantity = 5,
                    }
                }
            };

            //act
            var result = _recipeService.InsertRecipeAsync(request);

            //assert
            var expectedRecipe = _context.Recipes.FirstOrDefault(r => r.Name == request.Name);

            Assert.AreEqual(expectedRecipe.Name, request.Name);
            Assert.AreEqual(expectedRecipe.Description, request.Description);
            Assert.AreEqual(expectedRecipe.RecipeCategory_Id, request.RecipeCategory_Id);
            Assert.AreEqual(expectedRecipe.RecipesIngredients.FirstOrDefault().Ingredient_Id, request.Ingredients.FirstOrDefault().Ingredient_Id);
            Assert.AreEqual(expectedRecipe.RecipesIngredients.FirstOrDefault().UnitQuantity, request.Ingredients.FirstOrDefault().UnitQuantity);
            Assert.AreEqual(expectedRecipe.RecipesIngredients.FirstOrDefault().MeasureUnit, request.Ingredients.FirstOrDefault().MeasureUnit);

        }

        [Test]
        public void InsertRecipeAsync_InputRequestWithoutCategory_ReturnNull()
        {
            //arrange
            var request = new AddRecipeRequest
            {
                Name = "Recipe 1",
                Description = "Description for Recipe 1"
            };

            //act
            var result = _recipeService.InsertRecipeAsync(request);

            //assert
            Assert.IsNull(result.Result);

        }

        // ** Test that user can’t add same ingredient twice for one recipe  **
        [Test]
        public void InsertRecipeIngredientsAsync_InputRequestWithTwoSameIngredients_ReturnInsertRecipeWithOneIngredient()
        {
            //arrange
            var request = new AddRecipeRequest
            {
                Name = "Recipe 3",
                Description = "Description for Recipe 3",
                RecipeCategory_Id = 336995,
                CreatedAt = DateTime.Now,
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient {
                    Ingredient_Id = 5,
                    MeasureUnit = Common.Enums.MeasureUnit.kg,
                    UnitQuantity = 15,
                    },
                    new RecipeIngredient {
                    Ingredient_Id = 5,
                    MeasureUnit = Common.Enums.MeasureUnit.kg,
                    UnitQuantity = 15,
                    }
                }
            };

            //act
            var result = _recipeService.InsertRecipeAsync(request);

            //assert
            var expectedRecipe = _context.Recipes.FirstOrDefault(r => r.Name == request.Name);

            Assert.That(expectedRecipe.RecipesIngredients, Is.Unique);

        }

        [Test]
        public void InsertRecipeIngredientsAsync_InputRequestWithMultipleIngredientsWhereTwoIsSame_ReturnRecipeWithOneOfDuplicateIngredient()
        {
            //arrange
            var request = new AddRecipeRequest
            {
                Name = "Recipe 4",
                Description = "Description for Recipe 4",
                RecipeCategory_Id = 7775,
                CreatedAt = DateTime.Now,
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient {
                    Ingredient_Id = 4,
                    MeasureUnit = Common.Enums.MeasureUnit.gr,
                    UnitQuantity = 200,
                    },
                    new RecipeIngredient {
                    Ingredient_Id = 4,
                    MeasureUnit = Common.Enums.MeasureUnit.gr,
                    UnitQuantity = 200,
                    },
                    new RecipeIngredient {
                    Ingredient_Id = 2,
                    MeasureUnit = Common.Enums.MeasureUnit.kg,
                    UnitQuantity = 3,
                    },
                    new RecipeIngredient {
                    Ingredient_Id = 1,
                    MeasureUnit = Common.Enums.MeasureUnit.ml,
                    UnitQuantity = 900,
                    },
                }
            };


            //act
            var result = _recipeService.InsertRecipeAsync(request);

            //assert
            var expectedRecipe = _context.Recipes.FirstOrDefault(r => r.Name == request.Name);

            Assert.That(expectedRecipe.RecipesIngredients, Is.Unique);
            Assert.That(expectedRecipe.RecipesIngredients.Count, Is.EqualTo(3));

        }

        [Test]
        public void InsertRecipeIngredientsAsync_InputRequestWithMultipleIngredientsWithSameIdButDifferentQuantity_ReturnRecipeWithOneOfDuplicateIngredient()
        {
            //arrange
            var request = new AddRecipeRequest
            {
                Name = "Recipe 22",
                Description = "Description for Recipe 22",
                RecipeCategory_Id = 5,
                CreatedAt = DateTime.Now,
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient {
                    Ingredient_Id = 4,
                    MeasureUnit = Common.Enums.MeasureUnit.gr,
                    UnitQuantity = 200,
                    },
                    new RecipeIngredient {
                    Ingredient_Id = 4,
                    MeasureUnit = Common.Enums.MeasureUnit.kg,
                    UnitQuantity = 5,
                    },
                    new RecipeIngredient {
                    Ingredient_Id = 2,
                    MeasureUnit = Common.Enums.MeasureUnit.kg,
                    UnitQuantity = 3,
                    },
                }
            };

            //act
            var result = _recipeService.InsertRecipeAsync(request);

            //assert
            var expectedRecipe = _context.Recipes.FirstOrDefault(r => r.Name == request.Name);

            Assert.That(expectedRecipe.RecipesIngredients, Is.Unique);
            Assert.That(expectedRecipe.RecipesIngredients.Count, Is.EqualTo(2));

        }

        // ** Test ingredient unit cost is calculating properly **

        [Test]
        public void CalculatedIngredientPrice_InputRequestQuantityInKg_ReturnCorrectPrice()
        {

            //act
            var result = CalculatedPrice.CalculatedIngredientPrice(10, MeasureUnit.kg, (decimal)0.5);

            //assert
            var expectedCost = Math.Round(0.5f * (10f * 1000f), 2);
            Assert.That(expectedCost, Is.EqualTo(result));
        }

        [Test]
        public void CalculatedIngredientPrice_InputRequestQuantityInGr_ReturnCorrectPrice()
        {

            //act
            var result = CalculatedPrice.CalculatedIngredientPrice(500, MeasureUnit.gr, (decimal)0.8);

            //assert
            var expectedCost = Math.Round(0.8f * 500f, 2);
            Assert.That(expectedCost, Is.EqualTo(result));
        }

        [Test]
        public void CalculatedIngredientPrice_InputRequestQuantityInKom_ReturnCorrectPrice()
        {

            //act
            var result = CalculatedPrice.CalculatedIngredientPrice(5, MeasureUnit.kom, 10);

            //assert
            var expectedCost = Math.Round(10f * 5f, 2);
            Assert.That(expectedCost, Is.EqualTo(result));
        }

        // ** Test that recipe load more works properly  **

        [Test]
        public void GetRecipesAsync_RequestSkip0Take10_Return10OrLessRecipe()
        {
            //arrange
            var request = new RecipeSearchRequest
            {
                CategoryId = 5,
                Skip = 0
            };

            //act
            var result = _recipeService.GetRecipesAsync(request);

            //assert
            Assert.That(result.Result.Data.Count, Is.GreaterThan(0));
            Assert.That(result.Result.Data.Count, Is.LessThan(11));

        }

        [Test]
        public void GetRecipesAsync_RequestSkip10Take10_ReturnLastPage()
        {
            //arrange
            var request = new RecipeSearchRequest
            {
                CategoryId = 5,
                Skip = 10
            };
            //act
            var result = _recipeService.GetRecipesAsync(request);

            //assert
            var expectedNumberOfData = result.Result.TotalCount - 10;
            Assert.That(result.Result.Data.Count, Is.GreaterThan(0));
            Assert.That(result.Result.Data.Count, Is.EqualTo(expectedNumberOfData));
        }

        [Test]
        public void GetRecipesAsync_RequestSkip20Take10_Return0()
        {
            //arrange
            var request = new RecipeSearchRequest
            {
                CategoryId = 5,
                Skip = 20
            };
            //act
            var result = _recipeService.GetRecipesAsync(request);

            //assert
            Assert.That(result.Result.Data.Count, Is.EqualTo(0));
            Assert.That(result.Result.TotalCount, Is.LessThan(20));
        }

        // ** Test that recipe cost is calculating properly   **

        [Test]
        public void CalculatedRecipeTotalPrice_InputRecipeRequest_ReturnCorrectPrice()
        {
            //arrange
            var recipe = _context.Recipes.FirstOrDefault(x => x.Id == 1);

            //act
            var result = CalculatedPrice.CalculatedTotalPrice(recipe);

            //assert
            decimal totalCost = 0;
            foreach (var r in recipe.RecipesIngredients)
            {
                totalCost += Math.Round(CalculatedPrice.CalculatedIngredientPrice(r.UnitQuantity, r.MeasureUnit, r.Ingredient.UnitPrice), 2);
            }

            Assert.That(totalCost, Is.EqualTo(result));
        }


        [Test]
        public void CalculatedRecipeTotalPrice_InputRecipeRequest_ReturnInCorrectPrice()
        {
            //arrange
            var recipe = _context.Recipes.FirstOrDefault(x => x.Id == 1);

            //act
            var result = CalculatedPrice.CalculatedTotalPrice(recipe);

            //assert
            Assert.That(500, !Is.EqualTo(result));
        }

    };
}