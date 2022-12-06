using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using KannotEven.Models;

namespace KannotEven.Data
{
    public class ApplicationDbContext : DbContext
    {
        private int NumSeedIngredients = 9;
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Recipe_Ingredient> Recipes_Ingredient { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFDataSeeding;Trusted_Connection=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe_Ingredient>().
                HasOne(a => a.Recipe).
                WithMany(b => b.Recipe_Ingredients).
                HasForeignKey(c => c.RecipeName);

            modelBuilder.Entity<Recipe_Ingredient>().
                HasOne(a => a.Ingredient).
                WithMany(b => b.Recipe_Ingredients).
                HasForeignKey(c => c.IngredientName);

            
            Queue<Ingredient> allIngredients = new Queue<Ingredient>();
            Queue<Recipe> allRecipes = new Queue<Recipe>();

            for (int i = 0; i < NumSeedIngredients; i++)
            {
                String ingredientName = "I" + i.ToString();

                Ingredient ingredient = new Ingredient { Name = ingredientName };

                allIngredients.Enqueue(ingredient);

            }

            for (int i = 0; i < NumSeedIngredients; i++)
            {
                String recipeName = "R" + i.ToString();
                String url = "www.test" + i.ToString() + ".com";

                Recipe recipe = new Recipe { Name = recipeName, URL = url};

                allRecipes.Enqueue(recipe);
            }

            for (int i = 1; i <= NumSeedIngredients; i++)
            {
                Recipe recipe = new Recipe();
                try
                {
                    if (i % 3 == 0)
                    {
                        recipe = allRecipes.Dequeue();
                        modelBuilder.Entity<Recipe>().HasData(recipe);
                    }
                    else recipe = allRecipes.Peek();
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Queue FUCKED");
                }
                
             
                Ingredient ingredient = allIngredients.Dequeue();          

                Recipe_Ingredient recipe_ingredient = new Recipe_Ingredient
                { Id = i + 1,
                    RecipeName = recipe.Name,
                    IngredientName = ingredient.Name,
                };

                modelBuilder.Entity<Recipe_Ingredient>().HasData(recipe_ingredient);
                modelBuilder.Entity<Ingredient>().HasData(ingredient);                       
            }      
        }
    }
}
