﻿using Models.Entities;

namespace Model.Interfaces;

public interface ILabelRepository
{
    Task<Label> GetByIdAsync(int id);

    Task<Label> GetByTitelAsync(string titel);

    Task<Label> CreateAsync(Label label);

    Task<Label> UpdateAsync(Label label);

    Task DeleteAsync(int id);
}