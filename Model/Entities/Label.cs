using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

public class Label
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LabelId { get; set; } //PK

    [Required(ErrorMessage = "Dit moet ingevuld zijn.")]
    [MinLength(1, ErrorMessage = "Dit moet ingevuld zijn.")]
    public string Titel { get; set; }

    [Required(ErrorMessage = "Dit moet ingevuld zijn.")]
    [MinLength(1, ErrorMessage = "Dit moet ingevuld zijn.")]
    public string Beschrijving { get; set; }

    // Navigatie-eigenschappen voor de relaties
    public ICollection<Taak>? Taken { get; set; }// = new List<Taak>();

    public ICollection<ToDo>? ToDos { get; set; }// = new List<ToDo>();
}