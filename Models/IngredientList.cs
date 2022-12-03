using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KannotEven.Models
{
	public class IngredientList
	{
		public string List { get; set; }

		public List<Ingredient> Ingredients
		{
			get
			{
				List<Ingredient> ingredients = new List<Ingredient>();

				return ingredients;
			}
		}
	}
}
