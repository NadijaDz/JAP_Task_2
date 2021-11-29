using System;
using System.Linq;
using System.Text;

namespace NormativeCalculator.Core.Models.Response
{
    public class GetRecipesOrderByCostRecipeGroupByCategoryResponse
    {
        public string CategoryName { get; set; }

        public string Name { get; set; }

        public decimal RecipeCost { get; set; }

    }
}
