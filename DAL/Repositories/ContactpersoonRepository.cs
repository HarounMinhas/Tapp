using DAL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Model.DTOs;
using Model.Entities;

namespace DAL.Repositories;

public class ContactpersoonRepository : IContactpersoonRepository
{
    private readonly EFTappContext _dbContext;

    public ContactpersoonRepository(EFTappContext eFTappContext)
    {
        _dbContext = eFTappContext;
    }

    public Task<ContactPersoonDTO> CreateAsync(Contactpersoon contactpersoon)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<ICollection<ContactPersoonDTO>> GetAllAsync()
    {
        return await _dbContext.Contactpersonen
             .OrderBy(c => c.Familienaam)
             .Select(c => ConvertContactPersoonNaarContactpersoonDTO(c))
             .ToListAsync();
    }

    public Task<ContactPersoonDTO> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ContactPersoonDTO> UpdateAsync(Contactpersoon contactpersoon)
    {
        throw new NotImplementedException();
    }

    private static ContactPersoonDTO ConvertContactPersoonNaarContactpersoonDTO(Contactpersoon contactPersoon)
    {
        return
            new ContactPersoonDTO
            {
                ContactpersoonId = contactPersoon.ContactpersoonId,
                Voornaam = contactPersoon.Voornaam,
                Familienaam = contactPersoon.Familienaam,
                Email = contactPersoon.Email,
                TelefoonNummer = contactPersoon.TelefoonNummer!,
                GSMNummer = contactPersoon.GSMNummer!
            };
    }
}