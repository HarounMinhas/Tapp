using System.Collections.ObjectModel;
using System.Threading.Tasks;
using DAL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Model.DTOs;
using Model.Entities;

namespace DAL.Repositories;
public class TaakRepository : ITaakRepository
{
    private readonly EFTappContext _dbContext;
    public TaakRepository(EFTappContext eFTappContext)
    {
        _dbContext = eFTappContext;
    }

    public Task<Taak> CreateAsync(Taak taak)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<ICollection<TaakDTO>> GetByProjectIdAsync(int projectId)
    {
        var alleTaken = (await _dbContext.Taken
            .Include(t => t.Status)
            .Include(t => t.ToDos)
            .ThenInclude(todo=> todo.DatumUur)
            .Include(t => t.ToDos)
            .ThenInclude(todo => todo.Label)
            .Include(t => t.DatumUur)
            .Include(t => t.Label)
            .Where(t => t.ProjectId == projectId).ToListAsync());

        var DTOs = alleTaken.Select(t => (new TaakDTO
        {
            TaakId = t.TaakId,
            Titel = t.Titel,
            Beschrijving = t.Beschrijving,
            Status = new StatusDTO
            {
                StatusId = t.Status.StatusId,
                Titel = t.Status.Titel,
                Beschrijving = t.Status.Beschrijving
            },
            DatumUur = new DatumUurDTO
            {
                DatumUurId = t.DatumUur.DatumUurId,
                BeginDatumUur = t.DatumUur.BeginDatumUur,
                EindDatumUur = t.DatumUur.EindDatumUur,
                AfgerondDatumUur = t.DatumUur.AfgerondDatumUur
            },
            ToDos = t.ToDos.Select(todo => new ToDoDTO
            {
                ToDoId = todo.ToDoId,
                Titel = todo.Titel,
                Beschrijving = todo.Beschrijving,
                DatumUur = new DatumUurDTO
                {
                    DatumUurId = todo.DatumUur.DatumUurId,
                    BeginDatumUur = todo.DatumUur.BeginDatumUur,
                    EindDatumUur = todo.DatumUur.EindDatumUur,
                    AfgerondDatumUur = todo.DatumUur.AfgerondDatumUur
                },
                Label = new LabelDTO
                {
                    LabelId = todo.Label.LabelId,
                    Titel = todo.Label.Titel,
                    Beschrijving = todo.Label.Beschrijving
                },
                Status = new StatusDTO
                {
                    StatusId = todo.Status.StatusId,
                    Titel = todo.Status.Titel,
                    Beschrijving = todo.Status.Beschrijving
                }
            }).ToList(),
            Label = new LabelDTO
            {
                LabelId = t.Label.LabelId,
                Titel = t.Label.Titel,
                Beschrijving = t.Label.Beschrijving
            }
        }
        ));
        return DTOs.ToList();
    }

    public Task<Taak> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }


    public Task<Taak> GetByTitelAsync(string titel)
    {
        throw new NotImplementedException();
    }

    public Task<Taak> UpdateAsync(Taak taak)
    {
        throw new NotImplementedException();
    }
}
