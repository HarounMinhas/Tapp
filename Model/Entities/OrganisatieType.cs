using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities;

public class OrganisatieType
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrganisatieTypeId { get; set; }

    [Required]
    public string Naam { get; set; }
}