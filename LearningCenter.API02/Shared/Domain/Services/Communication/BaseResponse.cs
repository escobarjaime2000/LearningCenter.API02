namespace LearningCenter.API02.Shared.Domain.Services.Communication;
// clase abstracta y generica 
public abstract class BaseResponse <T>
{
    //properties
    protected BaseResponse(T resource)
    {
        //respuesta positiva 
        Success = true;
        Resource = resource; // data a transferir
        Message = string.Empty; // mensaje vacio 
    }

    protected BaseResponse(string message)
    {
        Success = false; // respuesta negativa 
        Resource = default;
        Message = message;
    }

    public bool Success { get; set; }
    public string Message { get; set; }
    public T Resource { get; set; }
}