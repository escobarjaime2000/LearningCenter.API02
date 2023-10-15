namespace LearningCenter.API02.Learning.Domain.Models;

public class Tutorial
{
    //Id, Name, Descripcion 
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    //establecemos una relacion de asociacion de uno a muchos 
    //Relationship 
    //asp.net Core (entity Framework ) -- persistencia 
    //necesita que se le indique que atributo usa la contraparte , a nivel de tabla
    public int CategoryId { get; set; }
   
    // poo 
    public Category Category { get; set; }
}