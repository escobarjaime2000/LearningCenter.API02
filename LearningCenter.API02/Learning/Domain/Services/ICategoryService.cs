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
  //22.10.2023<---
  //la capa service esta haciendo es trabajar a nivel de funcionalidad 
  //para acceder a esta conexion de category 
  //hay que tomar en cuenta que es una interfaz en donde se declara el 
  //comportamiento, en este interface no se implementa, solo se declara.
  
}