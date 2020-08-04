using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.DatabaseClasses
{
    class Garnish : Entity
    {
        public string Name { get; set; }
    }
}
