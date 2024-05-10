using Model.Entities;

namespace Model.Interfaces.Repositories;

public interface IAdresRepository
{
    Task<Adres> GetById(int id);

    Task<Adres> Create(Adres adres);

    Task<Adres> Update(Adres adres);

    Task DeleteById(int id);
}