using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CocktailContext ctx = new CocktailContext())
            {
                ctx.Database.CreateIfNotExists();
                //SQLQuery.InsertData(ctx);
                ctx.SaveChanges();
            }
        }
    }
}
