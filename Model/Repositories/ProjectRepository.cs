using Microsoft.EntityFrameworkCore;
using Model.Interfaces.Repositories;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DTOs;

namespace Model.Repositories;
public class ProjectRepository : IProjectRepository
{
    private readonly EFTappContext _dbContext;
    public ProjectRepository(EFTappContext dbContext)
    {
        this._dbContext = dbContext;
    }
    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<ICollection<ProjectDTO>> GetAllInDTOAsync()
    {
         var projecten = await _dbContext.Projecten
            .Include(t => t.Taken)!
            .ThenInclude(taken => taken.ToDos)
            .ThenInclude(l => l.Label)
            .Include(s => s.Status)
            .Include(o => o.Organisatie)
            .ToListAsync();

        var projectDTOs = projecten.Select(
                project => new ProjectDTO
                {
                    ProjectId = project.ProjectId,
                    OrganisatieId = project.Organisatie.OrganisatieId,
                    Organisatienaam = project.Organisatie.Naam,
                    StatusId = project.Status.StatusId,
                    StatusTitel = project.Status.Titel,
                    StatusBeschrijving = project.Status.Beschrijving,
                    Naam = project.Naam,
                    Beschrijving = project.Beschrijving
                }).ToList();

            return projectDTOs;
    }

    public Task<Project> GetByBeschrijvingAsync(string beschrijving)
    {
        throw new NotImplementedException();

        
    }

    public async Task<Project> GetByIdAsync(int id)
    {
        return (await _dbContext.Projecten.FirstOrDefaultAsync(p => p.ProjectId == id))!;

    }

    public Task<Project> GetByNaamAsync(string naam)
    {
        throw new NotImplementedException();
    }

    public Task<Project> UpdateAsync(Project project)
    {
        throw new NotImplementedException();
    }
}
