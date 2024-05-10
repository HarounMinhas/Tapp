using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

public class Status
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StatusId { get; set; } //PK

    [Required]
    public string Titel { get; set; }

    [Required]
    public string Beschrijving { get; set; }

    public ICollection<Project>? Projecten { get; set; }
    public ICollection<Taak>? Taken { get; set; }
    public ICollection<ToDo>? ToDos { get; set; }
}