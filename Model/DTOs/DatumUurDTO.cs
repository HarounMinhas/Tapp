using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTOs;
public class DatumUurDTO
{
    public int DatumUurId { get; set; }
    public DateTime? BeginDatumUur { get; set; }
    public DateTime? EindDatumUur { get; set; }
    public DateTime? AfgerondDatumUur { get; set; }
}
