namespace Model.DTOs
{
    public class ProjectDTO
    {
        public int ProjectId { get; set; }
        public OrganisatieDTO Organisatie { get; set; }
        public StatusDTO? Status { get; set; }
        public DatumUurDTO DatumUur { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
    }
}