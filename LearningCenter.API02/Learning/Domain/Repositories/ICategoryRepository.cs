using LearningCenter.API02.Learning.Domain.Models;

namespace LearningCenter.API02.Learning.Domain.Repositories;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> ListAsync();
    Task AddAsync(Category category);
    Task<Category> FindByIdAsync(int id);
    void Update(Category category);
    void delete(Category category);
    
}