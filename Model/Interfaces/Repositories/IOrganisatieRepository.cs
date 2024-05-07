using Models.Entities;

namespace Model.Interfaces.Repositories;

public interface IOrganisatieRepository
{
    Task<Organisatie> GetByIdAsync(int id);

    Task<List<Organisatie>> GetByNaamAsync(string naam);

    Task<Organisatie> CreateAsync(Organisatie organisatie);

    Task<Organisatie> UpdateAsync(Organisatie organisatie);

    Task DeleteAsync(int id);
}