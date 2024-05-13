using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Model.Interfaces.Repositories;
using System;

namespace TappService.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProjectController : ControllerBase
{
    private readonly IProjectRepository _projectRepository;

    public ProjectController(IProjectRepository projectRepository)
    {
        this._projectRepository = projectRepository?? throw new ArgumentNullException("yah tis hier te doen wi");
    }

    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        var test = (await _projectRepository.GetAllInDTOAsync());

        return base.Ok(test);
    }
}
