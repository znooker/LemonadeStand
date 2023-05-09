using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain.Recipes
{
    internal class Recipe : IRecipe
    {
        public Recipe(string name, FruitType fruit, decimal fruitConsumptionPerGlass, int pricePerGlass)
        {
            Name = name;
            AllowedFruit = fruit;
            ConsumptionPerGlass = fruitConsumptionPerGlass;
            PricePerGlass = pricePerGlass;
        }

        public string Name { get; set; }

        public Type AllowedFruit { get; set; }

        public decimal ConsumptionPerGlass { get; set; }

        public int PricePerGlass { get; set; }


    }
}
