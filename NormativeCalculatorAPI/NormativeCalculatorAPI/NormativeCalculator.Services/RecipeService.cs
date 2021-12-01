using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Core;
using NormativeCalculator.Core.Helper;
using NormativeCalculator.Core.Models.DTOs;
using NormativeCalculator.Core.Models.Request;
using NormativeCalculator.Core.Models.Response;
using NormativeCalculator.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NormativeCalculator.Services
{
    public interface IRecipeService
    {
        Task<GetRecipesDto> GetRecipeByIdAsync(int id, CancellationToken cancellationToken);
        Task<PaginationResponse<List<GetRecipesResponse>>> GetRecipesAsync(RecipeSearchRequest request, CancellationToken cancellationToken = default);
        Task<GetRecipesResponse> InsertRecipeAsync(AddRecipeRequest request, CancellationToken cancellationToken = default);
    }

    public class RecipeService : IRecipeService
    {
        private readonly NormativeCalculatorDBContext _context;
        protected readonly IMapper _mapper;
        private readonly IUserService _userService;

        public RecipeService(NormativeCalculatorDBContext context, IMapper mapper, IUserService userService
            )
        {
            _context = context;
            _mapper = mapper;
            _userService = userService;
        }

        public async Task<GetRecipesDto> GetRecipeByIdAsync(int id, CancellationToken cancellationToken)
        {
            var recipe = await _context.Recipes.Where(x => x.Id == id).Include(i => i.RecipesIngredients)
                .Select(s => new GetRecipesDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    RecipeIngredient = s.RecipesIngredients.Select(c =>
                          new GetRecipesIngredientsDto
                          {
                              Ingredient_Id = c.Ingredient_Id,
                              Recipe_Id = c.Recipe_Id,
                              UnitQuantity = c.UnitQuantity,
                              IngredinentName = c.Ingredient.Name,
                              MeasureUnits = c.MeasureUnit,
                              CostOfIngredient = CalculatedPrice.CalculatedIngredientPrice(c.UnitQuantity, c.MeasureUnit, c.Ingredient.UnitPrice)
                          }
                        )

                }).FirstOrDefaultAsync();

            recipe.TotalCost = recipe.RecipeIngredient.Sum(x => x.CostOfIngredient);

            return recipe;
        }

        public async Task<PaginationResponse<List<GetRecipesResponse>>> GetRecipesAsync(RecipeSearchRequest request, CancellationToken cancellationToken = default)
        {
            var list = await _context.Recipes.Include(r => r.RecipesIngredients).ThenInclude(i => i.Ingredient)
               .Where(x => x.RecipeCategory_Id == request.CategoryId)
               .Where(s => (string.IsNullOrWhiteSpace(request.SearchQuery)) ||
                   s.Name.ToLower().Trim().StartsWith(request.SearchQuery.ToLower().Trim()) ||
                   s.Description.ToLower().Trim().StartsWith(request.SearchQuery.ToLower().Trim()) ||
                   s.RecipesIngredients.Any(y => y.Ingredient.Name.ToLower().Contains(request.SearchQuery)))
               .Select(s => new GetRecipesDto
               {
                   Id = s.Id,
                   Name = s.Name,
                   Description = s.Description,
                   TotalCost = CalculatedPrice.CalculatedTotalPrice(s)
               }).ToListAsync(cancellationToken);

            list = list.OrderBy(x => x.TotalCost).ThenByDescending(c => c.Created).Skip(request.Skip)
               .Take(10)
               .ToList();

            var countAllRecipes = _context.Recipes.Count();
            var data = _mapper.Map<List<GetRecipesResponse>>(list);

            return new PaginationResponse<List<GetRecipesResponse>>(data, countAllRecipes);
        }

        public async Task<GetRecipesResponse> InsertRecipeAsync(AddRecipeRequest request, CancellationToken cancellationToken = default)
        {
            if (request.RecipeCategory_Id == 0)
            {
                return null;
            }


            if (request.User == null)
            {
                var user = await _userService.GetLoggedInUser();
                request.User = user;
                request.UserId = user.Id;
            }

            request.Ingredients = request.Ingredients.GroupBy(x => x.Ingredient_Id)
                .Select(x => x.First()).ToList();

            var entity = _mapper.Map<Recipe>(request);
            entity.CreatedAt = DateTime.Now;
            entity.IsDeleted = false;
            await _context.Recipes.AddAsync(entity);
            await _context.SaveChangesAsync(cancellationToken);

            if (request.Ingredients != null)
            {
                foreach (var ingredient in request.Ingredients)
                {
                    await _context.RecipesIngredients.AddAsync(
                         new RecipeIngredient()
                         {
                             Recipe_Id = entity.Id,
                             Ingredient_Id = ingredient.Ingredient_Id,
                             MeasureUnit = ingredient.MeasureUnit,
                             UnitQuantity = ingredient.UnitQuantity
                         }
                     );
                }
            }

            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<GetRecipesResponse>(entity);
        }
    }
}
