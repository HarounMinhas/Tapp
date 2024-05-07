using Models.Entities;

namespace Model.Interfaces;

public interface IDatumUurRepository
{
    Task<DatumUur> GetByIdAsync(int id);

    Task<DatumUur> CreateAsync(DatumUur datumUur);

    Task<DatumUur> UpdateAsync(DatumUur datumUur);

    Task DeleteAsync(int id);
}