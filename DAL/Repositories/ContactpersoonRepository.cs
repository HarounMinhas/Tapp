using DAL.Interfaces.Repositories;
using Model.DTOs;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        return (_dbContext.Contactpersonen.Select(c => ConvertContactPersoonNaarContactpersoonDTO(c)).OrderBy(c => c.Familienaam)).ToList() ;
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
                TelefoonNummer= contactPersoon.TelefoonNummer!,
                GSMNummer = contactPersoon.GSMNummer!
            };
        
    }
}
