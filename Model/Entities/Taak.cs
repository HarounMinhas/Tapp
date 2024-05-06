using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;
public class Taak
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TaakId { get; set; } //PK
    public int? StatusId { get; set; } //FK
    public Status? Status { get; set; }
    public int? DatumUurId { get; set; } //FK
    public DatumUur? DatumUur { get; set; }
    [Required]
    public string Titel { get; set; }
    [Required]
    public string Beschrijving { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "ProjectId kan niet 0 zijn.")]
    public int ProjectId { get; set; }
    public Project Project { get; set; }
    public ICollection<ToDo>? ToDos { get; set; }
    public ICollection<Label>? Labels { get; set; }
}
