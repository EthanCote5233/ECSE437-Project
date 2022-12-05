using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KannotEven.Models
{
    public class Ingredient
    {
        [Key]
        public String Name { get; set;}

        //Nav Properties
        public List<Recipe_Ingredient> Recipe_Ingredients { get; set; }

        public Ingredient()
        {
            Recipe_Ingredients = new List<Recipe_Ingredient>();
        }
    }
}
