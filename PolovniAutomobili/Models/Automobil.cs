namespace PolovniAutomobili.Models
{
    public class Automobil
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Godiste { get; set; }
        public int ZapreminaMotora { get; set; }
        public int Snaga { get; set; }
        public string Gorivo { get; set; }
        public string Karoserija { get; set; }
        public string Opis { get; set; }
        public decimal Cena { get; set; }
        public string Kontakt { get; set; }
    }
}