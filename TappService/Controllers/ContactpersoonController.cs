using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using DAL.Interfaces.Repositories;
using Model.DTOs;
using System.Threading.Tasks;

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