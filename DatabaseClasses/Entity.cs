using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.DatabaseClasses
{
    //I dit klassediagram viser du at alle sub-klasser implementerer dette interface. 
    //Eftersom dette ikke er et interface er der tale om almindelig arv og pilen skal derfor ikke være stiplet
    
    class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
