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

}
