using Model.DTOs;
using Model.Entities;

namespace DAL.Interfaces.Repositories;

public interface IContactpersoonRepository
{
    Task<ContactPersoonDTO> GetByIdAsync(int id);

    Task<ICollection<ContactPersoonDTO>> GetAllAsync();

    Task<ContactPersoonDTO> CreateAsync(Contactpersoon contactpersoon);

    Task<ContactPersoonDTO> UpdateAsync(Contactpersoon contactpersoon);

    Task DeleteAsync(int id);
}