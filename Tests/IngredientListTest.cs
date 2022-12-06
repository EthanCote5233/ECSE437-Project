using System;
using System.Collections.Generic;
using KannotEven.Models;
using Xunit;

namespace Tests
{
	public class IngredientListTest
	{
		private static Ingredient onion = new Ingredient() { Name = "onion"};
		private static Ingredient pasta = new Ingredient() { Name = "pasta" };
		private static Ingredient pesto = new Ingredient() { Name = "pesto" };
		private static Ingredient mushrooms = new Ingredient() { Name = "mushrooms" };
		private static Ingredient cream = new Ingredient() { Name = "cream" };

		public static IEnumerable<object[]> Ingredients =>
			new List<object[]>
			{
				new object[] { "onion,pasta", onion, pasta },
				new object[] { "pasta,pesto", pasta, pesto },
				new object[] { "pasta,mushrooms,cream", pasta, mushrooms, cream }
			};

		[Theory]
		[MemberData(nameof(Ingredients))]
		public void Ingredients_NormalInput_ReturnsList(string input, params Ingredient[] expectedIngredients)
		{
			IngredientList list = new IngredientList() { List = input };

			Assert.True(expectedIngredients.Length == list.Ingredients.Count);

			for (int i = 0; i < expectedIngredients.Length; i++)
			{
				Assert.Equal(expectedIngredients[i].Name, list.Ingredients[i].Name);
			}
		}
	}
}
