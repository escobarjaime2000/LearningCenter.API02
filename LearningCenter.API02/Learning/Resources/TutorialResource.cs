namespace LearningCenter.API02.Learning.Resources;

public class TutorialResource
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public CategoryResource Category { get; set; }
    //se relaciona Category a traves de CategoryResource que es property
    //esto es un resource no es un  modelo 
    //se elige categoryResource y no category 
    //Category tiene la conexion Tutorials que el cliente no debe ver
    //en cambio resource tiene su propia informacion, conveniente.
    
}