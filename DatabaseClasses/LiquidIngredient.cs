using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.DatabaseClasses
{
    class LiquidIngredient : Entity
    {
        public Drink DrinkId { get; set; }
        public Liquid Liquid { get; set; }
        public int AmountInMl { get; set; }
    }
}
