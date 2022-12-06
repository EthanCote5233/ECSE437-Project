Select [Total].Name 
From
(Select Recipe.Name, Count(*) AS iTotal
From Recipe, Recipes_Ingredient, Ingredient
Where Recipe.Name = Recipes_Ingredient.RecipeName and Recipes_Ingredient.IngredientName = Ingredient.Name
Group By Recipe.Name) As [Total]
,
(Select Recipe.Name, Count(*) AS iMatch
From Recipe, Recipes_Ingredient, Ingredient
Where Recipe.Name = Recipes_Ingredient.RecipeName and Recipes_Ingredient.IngredientName = Ingredient.Name and Ingredient.Name In ('I0', 'I1', 'I2')
Group By Recipe.Name) As [Match]
Where [Total].Name = [Match].Name and [Total].iTotal = [Match].iMatch 
