using Models.Entities;

namespace Model.Interfaces;

public interface IAdresRepository
{
    Task<Adres> GetById(int id);

    Task<Adres> Create(Adres adres);

    Task<Adres> Update(Adres adres);

    Task DeleteById(int id);
}