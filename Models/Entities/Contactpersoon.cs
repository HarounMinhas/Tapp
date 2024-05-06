namespace Models.Entities;
class Contactpersoon
{
    public int ContactpersoonId { get; set; } //PK
    public string Voornaam { get; set; }
    public string Familienaam { get; set; }
    public string Email { get; set; }
    public string TelefoonNummer { get; set; }
    public string GSMNummer { get; set; }
}
