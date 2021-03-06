using NormativeCalculator.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Response
{
    public class GetIngredientsResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal UnitQuantity { get; set; }

        public MeasureUnit MeasureUnit { get; set; }

        public decimal CostIngredient { get; set; }

    }
}
