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

        public Ingredient()
        {
          
        }
    }
}
