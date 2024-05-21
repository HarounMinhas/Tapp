using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTOs;
public class ToDoDTO
{
    public int ToDoId { get; set; }
    public string Titel { get; set; }
    public string Beschrijving { get; set; }
    public DatumUurDTO DatumUur { get; set; }
    public StatusDTO Status { get; set; }
    public LabelDTO? Label { get; set; }
}
