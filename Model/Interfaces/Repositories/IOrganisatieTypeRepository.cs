using Models.Entities;

namespace Model.Interfaces.Repositories;

public interface IOrganisatieTypeRepository
{
    Task<OrganisatieType> GetByIdAsync(int id);

    Task<OrganisatieType> CreateAsync(OrganisatieType organisatieType);

    Task<OrganisatieType> UpdateAsync(OrganisatieType organisatieType);

    Task DeleteAsync(OrganisatieType organisatieType);
}