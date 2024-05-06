using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;
public class Organisatie
{
    public int OrganisatieId { get; set; } //PK
    public string Naam { get; set; }
    public string BTWNummer { get; set; }
    public string Rekeningnummer { get; set; }

}
