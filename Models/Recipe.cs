using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KannotEven.Models
{
    public class Recipe
    {
        String name { get; set; }
        List<Ingredient> ingredients { get; set; }

        public Recipe(string name, List<Ingredient> ingredients)
        {
            this.name = name;
            this.ingredients = ingredients;
        }

    }
}
