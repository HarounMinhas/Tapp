using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities;

public class Contactpersoon
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ContactpersoonId { get; set; } //PK

    [Required]
    [StringLength(50)]
    public string Voornaam { get; set; }

    [Required]
    [StringLength(50)]
    public string Familienaam { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Phone]
    public string? TelefoonNummer { get; set; }

    [Phone]
    public string? GSMNummer { get; set; }

    public int OrganisatieId { get; set; }
    public Organisatie Organisatie { get; set; }
}