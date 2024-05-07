﻿using Models.Entities;

namespace Model.Interfaces;

public interface IProjectRepository
{
    Task<Project> GetByIdAsync(int id);

    Task<ICollection<Project>> GetAllAsync();

    Task<Project> GetByNaamAsync(string naam);

    Task<Project> GetByBeschrijvingAsync(string beschrijving);

    Task DeleteAsync(int id);

    Task<Project> UpdateAsync(Project project);
}