using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;
public class ToDo
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ToDoId { get; set; } //PK
    public int? DatumUurId { get; set; } //FK
    public DatumUur? DatumUur { get; set; }
    public int? StatusId { get; set; } //FK
    public Status? Status { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "TaakId kan geen 0 zijn.")]
    public int TaakId { get; set; }
    public Taak Taak { get; set; }
    [Required]
    public string Titel { get; set; }
    [Required]
    public string Beschrijving { get; set; }
    public int? LabelId { get; set; }
    public Label? Label { get; set; }
}
