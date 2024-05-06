using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;
public class Project
{
    public int ProjectId { get; set; }
    public int OrganisatieId { get; set; }
    public int StatusId { get; set; }
    public int DatumUurId { get; set; }
    public string Naam { get; set; }
    public string Beschrijving { get; set; }
}
