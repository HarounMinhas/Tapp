using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;
public class Taak
{
    public int TaakId { get; set; } //PK
    public int StatusId { get; set; } //FK
    public Status Status { get; set; }
    public int DatumUurId { get; set; } //FK
    public DatumUur DatumUur { get; set; }
    public string Titel { get; set; }
    public string Beschrijving { get; set; }
    public int ProjectId { get; set; }
    public Project Project { get; set; }
    public ICollection<ToDo> ToDos { get; set; }
    public ICollection<Label> Labels { get; set; }
}
