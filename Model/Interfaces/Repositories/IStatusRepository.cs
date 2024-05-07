using Models.Entities;

namespace Model.Interfaces.Repositories;

public interface IStatusRepository
{
    Task<Status> GetByIdAsync(int id);

    Task<Status> GetByTitelAsync(string titel);

    Task<Status> CreateAsync(Status status);

    Task<Status> UpdateByIdAsync(Status status);

    Task DeleteByIdAsync(int id);
}