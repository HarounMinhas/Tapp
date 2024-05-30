using Microsoft.EntityFrameworkCore;
using DAL.Interfaces.Repositories;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DTOs;
using DAL;
using System.Collections.ObjectModel;

namespace DAL.Repositories;
public class ProjectRepository : IProjectRepository
{
    private readonly EFTappContext _dbContext;
    public ProjectRepository(EFTappContext dbContext)
    {
        this._dbContext = dbContext;
    }

    public Task<Project> CreateAsync(ProjectDTO project)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<ICollection<ProjectDTO>> GetAllInDTOAsync()
    {
        var projecten = await _dbContext.Projecten
           .Include(t => t.Taken)!
           .ThenInclude(taken => taken.ToDos)!
           .ThenInclude(l => l.Label)
           .Include(s => s.Status)!
           .Include(o => o.Organisatie)
           .ThenInclude(oT => oT.OrganisatieType)
           .Include(o => o.Organisatie)
           .ThenInclude(c => c.Contactpersoon)
           .Include(d => d.DatumUur)

           .ToListAsync();

        var projectDTOs = projecten.Select(
                project => ConvertProjectNaarProjectDTO(project)).ToList();

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

    public async Task<ICollection<ProjectDTO>> GetProjectDTOByContactpersoon(string contactpersoon)
    {
        var projectDTOs =
            _dbContext.Projecten
            .Include(o => o.Organisatie)
            .ThenInclude(c => c.Contactpersoon)
            .Where(p => p.Organisatie.Contactpersoon.Familienaam.Contains(contactpersoon) || p.Organisatie.Contactpersoon.Voornaam.Contains(contactpersoon))
            .Include(o => o.Organisatie)
            .ThenInclude(ot => ot.OrganisatieType)
            .Include(s => s.Status)
            .Include(d => d.DatumUur)
            .Select(p => ConvertProjectNaarProjectDTO(p))
            .ToList();



        return projectDTOs;
    }

    public Task<ICollection<ProjectDTO>> GetProjectDTOByOrganisatieNaam(string organisatienaam)
    {
        throw new NotImplementedException();
    }

    public Task<Project> UpdateAsync(Project project)
    {
        throw new NotImplementedException();
    }

    private static ProjectDTO ConvertProjectNaarProjectDTO(Project project)
    {
        return new ProjectDTO
        {
            ProjectId = project.ProjectId,
            Organisatie = new OrganisatieDTO
            {
                OrganisatieId = project.Organisatie.OrganisatieId,
                Naam = project.Organisatie.Naam,
                OrganisatieType = project.Organisatie.OrganisatieType,
                Contactpersonen = new ContactPersoonDTO
                {
                    ContactpersoonId = project.Organisatie.Contactpersoon.ContactpersoonId,
                    Familienaam = project.Organisatie.Contactpersoon.Familienaam,
                    Voornaam = project.Organisatie.Contactpersoon.Voornaam,
                    Email = project.Organisatie.Contactpersoon.Email,
                    TelefoonNummer = project.Organisatie.Contactpersoon.TelefoonNummer!,
                    GSMNummer = project.Organisatie.Contactpersoon.GSMNummer!
                },
            },
            Status = new StatusDTO
            {
                StatusId = project.Status.StatusId,
                Titel = project.Status.Titel,
                Beschrijving = project.Status.Beschrijving
            },

            DatumUur = new DatumUurDTO
            {
                DatumUurId = project.DatumUur.DatumUurId,
                BeginDatumUur = project.DatumUur.BeginDatumUur,
                EindDatumUur = project.DatumUur.EindDatumUur,
                AfgerondDatumUur = project.DatumUur.AfgerondDatumUur
            },

            Naam = project.Naam,
            Beschrijving = project.Beschrijving
        };

    }
}
