using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cocktail.DatabaseClasses;

namespace Cocktail
{
    class SQLQuery
    {
        public static void InsertData(CocktailContext ctx)
        {
            //alcoholic
            Liquid vodka = new Alcoholic(){ Name = "Vodka", Type = "Vodka"};
            ctx.Alcoholic.Add(((Alcoholic) vodka));

            Liquid bourbon = new Alcoholic(){ Name = "Bourbon", Type = "Bourbon"};
            ctx.Alcoholic.Add(((Alcoholic) bourbon));

            Liquid whiteRum = new Alcoholic() { Name = "White Rum", Type = "Rum"};
            ctx.Alcoholic.Add(((Alcoholic)whiteRum));
            Liquid darkRum = new Alcoholic(){ Name = "Dark Rum", Type = "Rum"};
            ctx.Alcoholic.Add(((Alcoholic) darkRum));
            Liquid cachaca = new Alcoholic(){ Name = "Cachaca", Type = "Rum"};
            ctx.Alcoholic.Add(((Alcoholic) cachaca));

            Liquid tequila = new Alcoholic(){ Name = "Tequila", Type = "Tequila"};
            ctx.Alcoholic.Add(((Alcoholic) tequila));

            Liquid italianSweetVermouth = new Alcoholic(){ Name = "Italian Sweet Vermouth", Type = "Vermouth"};
            ctx.Alcoholic.Add(((Alcoholic) italianSweetVermouth));
            Liquid frenchDryVermouth = new Alcoholic(){ Name = "French Dry Vermouth", Type = "Vermouth"};
            ctx.Alcoholic.Add(((Alcoholic) frenchDryVermouth));

            Liquid gin = new Alcoholic(){ Name = "Gin", Type = "Gin"};
            ctx.Alcoholic.Add(((Alcoholic) gin));
            Liquid sloeGin = new Alcoholic(){ Name = "Sloe Gin", Type = "Gin"};
            ctx.Alcoholic.Add(((Alcoholic) sloeGin));

            Liquid cherryBrandy = new Alcoholic(){ Name = "Cherry Brandy", Type = "Brandy"};
            ctx.Alcoholic.Add(((Alcoholic) cherryBrandy));

            Liquid prosecco = new Alcoholic(){ Name = "Prosecco", Type = "Wine"};
            ctx.Alcoholic.Add(((Alcoholic) prosecco));

            Liquid cointreau = new Alcoholic(){ Name = "Cointreau", Type = "Liquor"};
            ctx.Alcoholic.Add(((Alcoholic) cointreau));
            Liquid tripleSec = new Alcoholic(){ Name = "Triple Sec", Type = "Liquor"};
            ctx.Alcoholic.Add(((Alcoholic) tripleSec));
            Liquid curacao = new Alcoholic(){ Name = "Curacao", Type = "Liquor"};
            ctx.Alcoholic.Add(((Alcoholic) curacao));
            Liquid kahlua = new Alcoholic(){ Name = "Kahlua", Type = "Liquor"};
            ctx.Alcoholic.Add(((Alcoholic) kahlua));

            //Non alcoholic
            Liquid limeJuice = new NonAlcoholic() { Name = "Lime Juice", Type = "Fruit" };
            ctx.NonAlcoholic.Add(((NonAlcoholic)limeJuice));
            Liquid orangeJuice = new NonAlcoholic(){Name = "Orange Juice", Type = "Fruit"};
            ctx.NonAlcoholic.Add(((NonAlcoholic) orangeJuice));
            Liquid pinkGrapefruitJuice = new NonAlcoholic(){Name = "Pink Grapefruit Juice", Type = "Fruit"};
            ctx.NonAlcoholic.Add(((NonAlcoholic) pinkGrapefruitJuice));
            Liquid grapefruitJuice = new NonAlcoholic(){Name = "Grapefruit Juice", Type = "Fruit"};
            ctx.NonAlcoholic.Add(((NonAlcoholic) grapefruitJuice));
            Liquid cranberryJuice = new NonAlcoholic(){Name = "Cranberry Juice", Type = "Fruit"};
            ctx.NonAlcoholic.Add(((NonAlcoholic) cranberryJuice));
            Liquid lemonJuice = new NonAlcoholic(){Name = "Lemon Juice", Type = "Fruit"};
            ctx.NonAlcoholic.Add(((NonAlcoholic) lemonJuice));
            Liquid pineappleJuice = new NonAlcoholic(){Name = "Pineapple Juice", Type = "Fruit"};
            ctx.NonAlcoholic.Add(((NonAlcoholic) pineappleJuice));
            Liquid peachPuree = new NonAlcoholic() { Name = "Peach Puree", Type = "Fruit" };
            ctx.NonAlcoholic.Add(((NonAlcoholic)peachPuree));

            Liquid water = new NonAlcoholic(){Name = "Water", Type = "Other"};
            ctx.NonAlcoholic.Add(((NonAlcoholic) water));
            Liquid soda = new NonAlcoholic(){Name = "Soda", Type = "Other"};
            ctx.NonAlcoholic.Add(((NonAlcoholic) soda));
            Liquid cola = new NonAlcoholic(){Name = "Cola", Type = "Other"};
            ctx.NonAlcoholic.Add(((NonAlcoholic) cola));
            Liquid almondSyrup = new NonAlcoholic() { Name = "Almond Syrup", Type = "Other" };
            ctx.NonAlcoholic.Add(((NonAlcoholic)almondSyrup));
            Liquid freshCream = new NonAlcoholic() { Name = "Fresh Cream", Type = "Other" };
            ctx.NonAlcoholic.Add(((NonAlcoholic)freshCream));
            Liquid coconutCream = new NonAlcoholic(){Name = "Coconut Cream", Type = "Other"};
            ctx.NonAlcoholic.Add(((NonAlcoholic) coconutCream));

            Liquid tomatoJuice = new NonAlcoholic(){Name = "Tomato Juice", Type = "Vegetable"};
            ctx.NonAlcoholic.Add(((NonAlcoholic) tomatoJuice));

            //Garnish
            Garnish brownSugar = new Garnish() { Name = "Brown Sugar" };
            ctx.Garnish.Add(brownSugar);
            Garnish saltRim = new Garnish(){Name = "Salt Rim"};
            ctx.Garnish.Add(saltRim);
            Garnish crushedIce = new Garnish(){Name = "Crushed Ice"};
            ctx.Garnish.Add(crushedIce);
            Garnish limeSegment = new Garnish(){Name = "Lime Segment"};
            ctx.Garnish.Add(limeSegment);
            Garnish limeSection = new Garnish(){Name = "Lime Section"};
            ctx.Garnish.Add(limeSection);
            Garnish maraschinoCherry = new Garnish(){Name = "Maraschino Cherry"};
            ctx.Garnish.Add(maraschinoCherry);
            Garnish casterSugar = new Garnish(){Name = "Caster Sugar"};
            ctx.Garnish.Add(casterSugar);
            Garnish iceCubes = new Garnish(){Name = "Ice Cubes"};
            ctx.Garnish.Add(iceCubes);
            Garnish celeryStick = new Garnish(){Name = "Celery Stick"};
            ctx.Garnish.Add(celeryStick);
            Garnish worcestershireSauce = new Garnish(){Name = "Worcestershire Sauce"};
            ctx.Garnish.Add(worcestershireSauce);
            Garnish orangeSlice = new Garnish(){Name = "Orange Slice"};
            ctx.Garnish.Add(orangeSlice);
            Garnish cubeCasterSugar = new Garnish(){Name = "Cube Caster Sugar"};
            ctx.Garnish.Add(cubeCasterSugar);
            Garnish dashAngosturaBitters = new Garnish(){Name = "Dash Angostura Bitters"};
            ctx.Garnish.Add(dashAngosturaBitters);
            Garnish orangePeel = new Garnish(){Name = "Orange Peel"};
            ctx.Garnish.Add(orangePeel);
            Garnish olive = new Garnish(){Name = "Olive"};
            ctx.Garnish.Add(olive);
            Garnish mintLeaf = new Garnish(){Name = "Mint Leaf"};
            ctx.Garnish.Add(mintLeaf);
            Garnish sodaWater = new Garnish(){Name = "Soda Water"};
            ctx.Garnish.Add(sodaWater);
            Garnish pineappleSegment = new Garnish(){Name = "Pineapple Segment"};
            ctx.Garnish.Add(pineappleSegment);

        }
    }
}
