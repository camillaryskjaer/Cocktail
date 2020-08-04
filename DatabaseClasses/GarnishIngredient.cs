using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.DatabaseClasses
{
    class GarnishIngredient : Entity
    {
        public Drink DrinkId { get; set; }
        public Garnish GarnishId { get; set; }
    }
}
