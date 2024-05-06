using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;
public class DatumUur
{
    public int DatumUurId { get; set; } //PK
    public DateTime BeginDatumUur { get; set; }
    public DateTime EindDatumUur { get; set; }
    public DateTime AfgerondDatumUur { get; set; }
}
