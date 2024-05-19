using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using DAL.Interfaces.Repositories;


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
        var test = (await _projectRepository.GetAllInDTOAsync());

        return base.Ok(test);
    }
}
