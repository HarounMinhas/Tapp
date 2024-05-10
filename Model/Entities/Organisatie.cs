using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

public class Organisatie
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrganisatieId { get; set; } //PK

    [Required]
    public string Naam { get; set; }

    [Required]
    public string BTWNummer { get; set; }

    [Required]
    public string Rekeningnummer { get; set; }

    public ICollection<Contactpersoon> Contactpersonen { get; set; }
    public int OrganisatieTypeId { get; set; }
    public OrganisatieType OrganisatieType { get; set; }
    public int AdresId { get; set; }
    public Adres Adres { get; set; }
}