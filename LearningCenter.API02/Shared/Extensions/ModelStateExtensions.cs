using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LearningCenter.API02.Shared.Extensions;

public static class ModelStateExtensions
{
    public static List<string> GetErrorMessages(this ModelStateDictionary dictionary)
    {
        //aplico un proceso flat . cuando se hacen validaciones de una entidad podrian fallar 
        //varias cosas , varios errores por entidad o por property
        //dado la coleccion de errores , debo tener una coleccion de respuesta a los errores 
        //por cada error capturado quiero el mensaje de error el cual estara en una coleccion
        return dictionary.SelectMany(m => m.Value.Errors)
            .Select(m => m.ErrorMessage)
            .ToList(); //listString
    }
    //cada models tiene posiblemente tres errores por lo cual 
    //me devuelve una lista de errores el cual finalmente se 
    //pone como una lista de errores 
    
}