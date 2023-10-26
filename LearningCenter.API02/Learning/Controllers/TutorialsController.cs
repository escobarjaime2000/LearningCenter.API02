using AutoMapper;
using LearningCenter.API02.Learning.Resources;
using Microsoft.AspNetCore.Mvc;
using ZstdSharp.Unsafe;

namespace LearningCenter.API02.Learning.Controllers;
//tutorial controller es descendiente de ControllerBase  y ademas es decorado con [ApiController]
//especificamos la ruta con la cual se asocia 
[ApiController]
[Route("/api/v1/[controller]")]
public class TutorialsController: ControllerBase

{
    private readonly ITutorialService _tutorialService;
    private readonly IMapper _mapper;
    
}
public async Task<IEnumerable<TutorialResource>> GetAllAsync()
{
    var tutorials = await _tutorialServices.ListAsync();
    var resources = _mapper.Map<IEnumerable<Tutorial>, IEnumerable<TutorialResource>>(tutorials);
    return resources;
}