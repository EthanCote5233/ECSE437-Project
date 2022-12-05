using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KannotEven.Models
{
    public class Recipe
    {       
        [Key]
        public String Name { get; set; }
        public String URL { get; set; }

        //Nav Properties
        public List<Recipe_Ingredient> Recipe_Ingredients { get; set; }

        public Recipe()
        {
            Recipe_Ingredients = new List<Recipe_Ingredient>();
        }
    }
}
