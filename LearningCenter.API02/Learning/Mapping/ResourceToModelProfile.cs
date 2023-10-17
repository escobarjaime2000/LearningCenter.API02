using AutoMapper;
using LearningCenter.API02.Learning.Domain.Models;
using LearningCenter.API02.Learning.Resources;

namespace LearningCenter.API02.Learning.Mapping;

public class ResourceToModelProfile:Profile
{
    protected ResourceToModelProfile()
    {
        CreateMap<SaveCategoryResource, Category>();
    }
}