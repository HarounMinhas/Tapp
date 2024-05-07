using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities;

public class Project
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProjectId { get; set; } //PK

    public int OrganisatieId { get; set; }
    public Organisatie Organisatie { get; set; }
    public int? StatusId { get; set; }
    public Status? Status { get; set; }
    public int? DatumUurId { get; set; }
    public DatumUur? DatumUur { get; set; }

    [Required]
    public string Naam { get; set; }

    [Required]
    public string Beschrijving { get; set; }

    public ICollection<Taak>? Taken { get; set; }
}