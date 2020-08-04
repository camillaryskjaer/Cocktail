using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cocktail.DatabaseClasses;

namespace Cocktail
{
    class CocktailContext : DbContext
    {
        public CocktailContext() : base("CocktailDB")
        {
            //Database.SetInitializer<CocktailContext>(new DropCreateDatabaseAlways<CocktailContext>());
        }

        public DbSet<Drink> Drink { get; set; }
        public DbSet<Alcoholic> Alcoholic { get; set; }
        public DbSet<NonAlcoholic> NonAlcoholic { get; set; }
        public DbSet<LiquidIngredient> LiquidIngredients { get; set; }
        public DbSet<Garnish> Garnish { get; set; }
        public DbSet<GarnishIngredient> GarnishIngredients { get; set; }
    }
}
