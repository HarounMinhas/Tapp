using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities;

public class Adres
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AdresId { get; set; }

    [Required]
    public string Straatnaam { get; set; }

    [Required]
    public string Straatnummer { get; set; } //mogelijkheden voor bv 11a en 11b

    public string? Busnummer { get; set; }

    [Required]
    public string Postcode { get; set; }

    [Required]
    public string Gemeente { get; set; }

    [Required]
    public string Provincie { get; set; }

    [Required]
    public string Land { get; set; }
}