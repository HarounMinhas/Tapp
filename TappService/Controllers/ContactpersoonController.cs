using DAL.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace TappService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactpersoonController : ControllerBase
{
    private readonly IContactpersoonRepository _contactpersoonRepository;

    public ContactpersoonController(IContactpersoonRepository contactpersoonRepository)
    {
        _contactpersoonRepository = contactpersoonRepository;
    }

    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        var contactpersonenDTO = (await _contactpersoonRepository.GetAllAsync());

        return base.Ok(contactpersonenDTO);
    }
}