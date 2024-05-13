using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTOs;
public class OrganisatieDTO
{
    public int OrganisatieId { get; set; }
    public string Naam { get; set; }
    public OrganisatieType OrganisatieType { get; set; }

    public ContactPersoonDTO Contactpersonen { get; set; }
}
