using LearningCenter.API02.Learning.Domain.Models;
using LearningCenter.API02.Shared.Domain.Services.Communication;

namespace LearningCenter.API02.Learning.Domain.Services.Communication;

public class CategoryResponse:BaseResponse<Category>
{
    public CategoryResponse(Category resource) : base(resource)
    {
    }

    public CategoryResponse(string message) : base(message)
    {
    }
}