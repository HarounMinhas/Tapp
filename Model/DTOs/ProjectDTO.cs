using Model.Entities;

namespace Model.DTOs
{
    public class ProjectDTO
    {
        public int ProjectId { get; set; }
        public OrganisatieDTO Organisatie { get; set; }
        public StatusDTO? Status { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        

    }
}