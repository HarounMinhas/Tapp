using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities;
public class Status
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StatusId { get; set; } //PK
    [Required]
    public string Titel { get; set; }
    [Required]
    public string Beschrijving { get; set; }
}
