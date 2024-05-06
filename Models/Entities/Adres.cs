namespace Models.Entities;
public class Adres
{
    public int AdresId { get; set; }
    public string Straatnaam { get; set; }
    public string Straatnummer { get; set; } //mogelijkheden voor bv 11a en 11b
    public string? Busnummer { get; set; }
    public string Postcode { get; set; }
    public string Gemeente { get; set; }
    public string Provincie { get; set; }
    public string Land { get; set; }
}
