using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;
public class ToDo
{
    public int ToDoId { get; set; }
    public int DatumUurId { get; set; }
    public int StatusId { get; set; }
    public string Titel { get; set; }
    public string Beschrijving { get; set; }
}
