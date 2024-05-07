using Models.Entities;

namespace Model.Interfaces;

public interface IToDoRepository
{
    Task<ToDo> GetByIdAsync(int id);

    Task<List<ToDo>> GetByTaakIdAsync(int taakId);

    Task<ToDo> CreateAsync(ToDo toDo);

    Task<ToDo> UpdateAsync(ToDo toDo);

    Task DeleteAsync(int id);
}