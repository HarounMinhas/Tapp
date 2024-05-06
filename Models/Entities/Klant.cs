using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;
class Klant
{
    public int KlantId { get; set; }
    public string Voornaam { get; set; }
    public string Familienaam { get; set; }
    public string Email { get; set; }
    public string TelefoonNummer { get; set; }
    public string GSMNummer { get; set; }
}
