using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;
public class ToDo
{
    public int ToDoId { get; set; } //PK
    public int DatumUurId { get; set; } //FK
    public DatumUur DatumUur { get; set; }
    public int StatusId { get; set; } //FK
    public Status Status { get; set; }
    public int TaakId { get; set; }
    public Taak Taak { get; set; }
    public string Titel { get; set; }
    public string Beschrijving { get; set; }
    public ICollection<Label> Labels { get; set; }
}
