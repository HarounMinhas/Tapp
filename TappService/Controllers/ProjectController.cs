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
public class ProjectController : ControllerBase
{
    private readonly IProjectRepository _projectRepository;

    public ProjectController(IProjectRepository projectRepository)
    {
        this._projectRepository = projectRepository;
    }

    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        var projectenDTO = (await _projectRepository.GetAllInDTOAsync());

        return base.Ok(projectenDTO);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] ProjectDTO projectDTO)
    {
        if (projectDTO == null)
        {
            return base.BadRequest();
        }
        await _projectRepository.CreateAsync(projectDTO);
        return base.Ok(projectDTO);
    }

    [HttpGet]
    [Route("contactpersoon/{naam}")]
    public async Task<ActionResult> GetProjectDTOByContactpersoon(string naam)
    {
        return base.Ok(await _projectRepository.GetProjectDTOByContactpersoon(naam));
    }

}
