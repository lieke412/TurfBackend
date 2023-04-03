namespace InterfaceLayer.DTO
{
    public class ReceptDTO
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public int Duur { get; set; }
        public int Moeilijkheid { get; set; }
        public List<IngredientDTO> Ingredienten { get; set; }

        public ReceptDTO(int iD, string naam, int duur, int moeilijkheid, List<IngredientDTO> ingredienten)
        {
            ID = iD;
            Naam = naam;
            Duur = duur;
            Moeilijkheid = moeilijkheid;
            Ingredienten = ingredienten;
        }
    }
}