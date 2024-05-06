using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;
public class Organisatie
{
    public int OrganisatieId { get; set; }
    public string Naam { get; set; }
    public string Straatnaam { get; set; }
    public string Straatnummer { get; set; } //mogelijkheden voor bv 11a en 11b
    public string? Busnummer { get; set; }
    public string Postcode { get; set; }
    public string Gemeente { get; set; }
    public string Provincie { get; set; }
    public string Land { get; set; }

}
