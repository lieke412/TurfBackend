using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Logic
{
    public class Ingredient
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public List<Recept>? recepten { get; set; }

    }
}
