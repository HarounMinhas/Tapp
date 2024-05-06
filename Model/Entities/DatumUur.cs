using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;
public class DatumUur
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DatumUurId { get; set; } //PK
                                        //Indien dit bestaat, dan moet er minstens een BeginDatumUur zijn, anders is
                                        //dit gewoon 0 bij de todo of taak of project
    [Required]
    public DateTime BeginDatumUur { get; set; }
    public DateTime? EindDatumUur { get; set; }
    public DateTime? AfgerondDatumUur { get; set; }
}
