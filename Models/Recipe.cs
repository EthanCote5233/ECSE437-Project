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
        public List<Ingredient> Ingredients { get; set; }

        public Recipe()
        {
           
        }
    }
}
