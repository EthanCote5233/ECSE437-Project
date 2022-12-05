using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KannotEven.Models
{
    public class Recipe_Ingredient
    {
        [Key]
        public int Id { get; set; }
        public String RecipeName { get; set; }
        public Recipe Recipe { get; set; }
        public String IngredientName { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
