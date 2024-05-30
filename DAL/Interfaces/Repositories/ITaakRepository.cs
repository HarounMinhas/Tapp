using Model.DTOs;
using Model.Entities;

namespace DAL.Interfaces.Repositories;

public interface ITaakRepository
{
    Task<Taak> GetByIdAsync(int id);

    Task<Taak> GetByTitelAsync(string titel);

    Task<ICollection<TaakDTO>> GetByProjectIdAsync(int projectId);

    Task<Taak> CreateAsync(Taak taak);

    Task<Taak> UpdateAsync(Taak taak);

    Task DeleteAsync(int id);
}