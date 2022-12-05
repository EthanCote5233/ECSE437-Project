using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using KannotEven.Models;

namespace KannotEven.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Recipe> Recipe { get; set; }

        private int NumSeedIngredients;

        public ApplicationDbContext(int numSeedIngredients) {
            NumSeedIngredients = numSeedIngredients;
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFDataSeeding;Trusted_Connection=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Queue<Ingredient> allIngredients = new Queue<Ingredient>();

            for (int i = 0; i < NumSeedIngredients; i++)
            {
                Ingredient ingredient = new Ingredient { Name = "I" + i.ToString() };

                allIngredients.Enqueue(ingredient);
                modelBuilder.Entity<Ingredient>().HasData(ingredient);
            }

            for (int i = 0; i < NumSeedIngredients/3; i++)
            {
                String name = "R" + i.ToString();
                String url = "www.test" + i.ToString() + ".com";
                List<Ingredient> ingredients = new List<Ingredient>();

                for (int j = 0; j < 3; j++)
                {
                    ingredients.Add(allIngredients.Dequeue());
                }
            
                modelBuilder.Entity<Recipe>().HasData(new Recipe { Name = name, URL = url, Ingredients =  ingredients});
            }
            
        }
    }
}
