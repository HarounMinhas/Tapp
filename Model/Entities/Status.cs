using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
