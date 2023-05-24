﻿namespace BusinessLogic.Logic
{
    public class Recept
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public int Duur { get; set; }
        public int Moeilijkheid { get; set; }
        public string Beschrijving { get; set; }
        public List<Ingredient> Ingredienten { get; set; }
    }
}