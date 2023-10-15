namespace LearningCenter.API02.Learning.Domain.Models;

public class Category
{
    //patron de diseño identity field
    public int Id { get; set; }
    public string Name { get; set; }
   /*ya tenemos tutorial y Category lo que falta es relacionarlos , representacion
   a traves de una clase */
   public IList<Tutorial> Tutorials { get; set; } = new List<Tutorial>();
  
   

}