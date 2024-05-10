using Model.DTOs;
using Model.Entities;

namespace Model.Interfaces.Repositories;

public interface IProjectRepository
{
    Task<Project> GetByIdAsync(int id);

    Task<ICollection<ProjectDTO>> GetAllInDTOAsync();

    Task<Project> GetByNaamAsync(string naam);

    Task<Project> GetByBeschrijvingAsync(string beschrijving);

    Task DeleteAsync(int id);

    Task<Project> UpdateAsync(Project project);
}