using Model.DTOs;
using Model.Entities;

namespace DAL.Interfaces.Repositories;

public interface IProjectRepository
{
    Task<Project> GetByIdAsync(int id);

    Task<ICollection<ProjectDTO>> GetAllInDTOAsync();

    Task<Project> GetByNaamAsync(string naam);
    Task<ICollection<ProjectDTO>> GetProjectDTOByContactpersoon(string contactpersoonNaam);
    Task<ICollection<ProjectDTO>> GetProjectDTOByOrganisatieNaam(string organisatieNaam);


    Task<Project> GetByBeschrijvingAsync(string beschrijving);

    Task DeleteAsync(int id);

    Task<Project> UpdateAsync(Project project);
    Task<Project> CreateAsync(ProjectDTO project);
}