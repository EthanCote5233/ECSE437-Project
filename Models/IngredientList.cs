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

		private List<Ingredient> cachedList;
		public List<Ingredient> Ingredients
		{
			get
			{
				if (cachedList != null)
				{
					return cachedList;
				}
				HashSet<Ingredient> ingredients = new HashSet<Ingredient>();

				foreach (string str in List.Split(',', StringSplitOptions.RemoveEmptyEntries))
				{
					ingredients.Add(new Ingredient() { Name = str });
				}

				cachedList = ingredients.ToList();

				return cachedList;
			}
		}
	}
}
