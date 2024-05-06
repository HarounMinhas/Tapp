using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;
public class Label
{
    public int LabelId { get; set; } //PK
    public string Titel { get; set; }
    public string Beschrijving { get; set; }
}
