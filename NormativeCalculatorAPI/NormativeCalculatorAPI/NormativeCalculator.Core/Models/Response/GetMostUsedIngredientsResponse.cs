using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Response
{
    public class GetMostUsedIngredientsResponse
    {
        public string Name { get; set; }

        public int UsageCount { get; set; }
    }
}
