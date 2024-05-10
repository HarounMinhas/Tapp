using Model.Entities;

namespace Model.DTOs
{
    public class ProjectDTO
    {
        public int ProjectId { get; set; }
        public int OrganisatieId { get; set; }
        public string Organisatienaam { get; set; }
        public int? StatusId { get; set; } // Alleen de StatusId wordt opgenomen
        public string StatusTitel { get; set; }
        public  string StatusBeschrijving { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        // Geen referenties naar andere entiteiten
    }
}