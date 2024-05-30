using Model.Entities;

namespace Model.DTOs;

public class OrganisatieDTO
{
    public int OrganisatieId { get; set; }
    public string Naam { get; set; }
    public OrganisatieType OrganisatieType { get; set; }

    public ContactPersoonDTO Contactpersonen { get; set; }
}