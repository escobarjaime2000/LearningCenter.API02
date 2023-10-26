using AutoMapper;
using LearningCenter.API02.Learning.Domain.Models;
using LearningCenter.API02.Learning.Domain.Services;
using LearningCenter.API02.Learning.Resources;
using LearningCenter.API02.Shared.Extensions;
using Microsoft.AspNetCore.Mvc;
namespace LearningCenter.API02.Learning.Controllers;
//22.10.2023

[Route("/api/v1/[controller]")] //api/v1/categories
public class CategoriesController: ControllerBase

{
   private readonly ICategoryService _categoryService;
   private readonly IMapper _mapper;


   public CategoriesController(ICategoryService categoryService, IMapper mapper)
   {
      _categoryService = categoryService;
      _mapper = mapper;
   }
   //es el verbo que va asociarse al metodo, cuando alguien haga un get al endpoint va a llamar al metodo adjunto
   [HttpGet]
   public async Task<IEnumerable<CategoryResource>> GetAllSync()
   {
      var categories = await _categoryService.ListAsync();
      var resources = _mapper.Map<IEnumerable<Category>,IEnumerable<CategoryResource>>(categories);
      return resources;
   }

   [HttpPost]
   public async Task<IActionResult> PostAsync([FromBody] SaveCategoryResource resource)
   {
      if (!ModelState.IsValid)
         return BadRequest(ModelState.GetErrorMessages());

      var category = _mapper.Map<SaveCategoryResource, Category>(resource);

      var result = await _categoryService.SaveAsync(category);

      if (!result.Success)
         return BadRequest(result.Message);
      var categoryResource = _mapper.Map<Category, CategoryResource>(result.Resource);
      return Ok(categoryResource);

   }
 //Sesion 11-25.10.2023
   //se va actualizar por eso se toma el Id
   //el segundo parametro FromBody es la data que se va a reemplazar
   [HttpPut("{id}")]
   public async Task<IActionResult> PutAsync(int id, [FromBody] SaveCategoryResource resource)
   {
      //verificar que cumpla las reglas de validacion 
      if (!ModelState.IsValid)
      {
         return BadRequest(ModelState.GetErrorMessages());
      }
      
      //empezamos hacer la traduccion 
      var category = _mapper.Map<SaveCategoryResource, Category>(resource);
      //ejecutar la accion , interactuamos con la capa de servicio
      var result = await _categoryService.UpdateAsync(id, category);
      //comprobando el result
      if (!result.Success)
      {
         //ebviamos el mensaje de la capa de servicio de lo que paso
         return BadRequest(result.Message);
      }

      var categoryResource = _mapper.Map<Category, CategoryResource>(result.Resource);
      return Ok(categoryResource);

   }
   
   //la eliminacion es con [HttpDelete]
   [HttpDelete("{id}")]
   public async Task<IActionResult> DeleteAsync(int id)
   {
      var result = await _categoryService.DeleteAsync(id); // de forma directa

      if (!result.Success)
      {
         return BadRequest(result.Message);
      }

      var categoryResource = _mapper.Map<Category, CategoryResource>(result.Resource);
      return Ok(categoryResource);
   }
}
