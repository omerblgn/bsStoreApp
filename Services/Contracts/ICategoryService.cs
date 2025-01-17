﻿using Entities.DataTransferObjects;
using Entities.Models;

namespace Services.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync(bool trackChanges);
        Task<CategoryDto> GetOneCategoryByIdAsync(int id, bool trackChanges);
        Task<CategoryDto> CreateOneCategoryAsync(CategoryDtoForInsertion category);
        Task UpdateOneCategoryAsync(int id, CategoryDtoForUpdate categoryDto, bool trackChanges);
        Task DeleteOneCategoryAsync(int id, bool trackChanges);
    }
}