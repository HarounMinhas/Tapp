using Microsoft.AspNetCore.Mvc;
using DAL.Interfaces.Repositories;

namespace TappService.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaakController : ControllerBase
{
    private readonly ITaakRepository _taakRepository;

    public TaakController(ITaakRepository taakRepository)
    {
        this._taakRepository = taakRepository;
    }

    [HttpGet("{projectId}")]
    public async Task<ActionResult> GetAllByProjectId(int projectId)
    {
        var taken = await _taakRepository.GetByProjectIdAsync(projectId);
        return base.Ok(taken);
    }
}
