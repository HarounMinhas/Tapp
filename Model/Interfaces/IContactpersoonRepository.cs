using Models.Entities;

namespace Model.Interfaces;

public interface IContactpersoonRepository
{
    Task<Contactpersoon> GetByIdAsync(int id);

    Task<ICollection<Contactpersoon>> GetAllAsync();

    Task<Contactpersoon> CreateAsync(Contactpersoon contactpersoon);

    Task<Contactpersoon> UpdateAsync(Contactpersoon contactpersoon);

    Task DeleteAsync(int id);
}