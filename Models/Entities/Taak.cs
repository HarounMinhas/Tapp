using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;
public class Taak
{
    public  int TaakId { get; set; }
    public int StatusId { get; set; }
    public int DatumUurId { get; set; }
    public string Titel { get; set; }
    public string Beschrijving { get; set; }
    
}
