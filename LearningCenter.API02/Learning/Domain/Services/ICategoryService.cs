using LearningCenter.API02.Learning.Domain.Models;
using LearningCenter.API02.Learning.Domain.Services.Communication;

namespace LearningCenter.API02.Learning.Domain.Services;

public interface ICategoryService
{
   //la capa service permite trabajar la funcionalidad de category
   Task<IEnumerable<Category>> ListAsync();
   Task<CategoryResponse> SaveAsync(Category category);
   Task<CategoryResponse> UpdateAsync(int id, Category category);
   Task<CategoryResponse> DeleteAsync(int id);
  //corresponde al contrato, en donde se dice que se debe cumplir 
  
  
}