using AutoMapper;
using LearningCenter.API02.Learning.Domain.Models;
using LearningCenter.API02.Learning.Resources;

namespace LearningCenter.API02.Learning.Mapping;

public class ModelToResourceProfile: Profile
{
    protected ModelToResourceProfile()
    {
        CreateMap<Category, CategoryResource>();
        //---->22.10.2023<----
        CreateMap<Category, CategoryResource>();
        CreateMap<Tutorial, TutorialResource>();
    }
}