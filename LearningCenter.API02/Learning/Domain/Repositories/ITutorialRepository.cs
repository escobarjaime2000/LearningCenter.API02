using LearningCenter.API02.Learning.Domain.Models;

namespace LearningCenter.API02.Learning.Domain.Repositories;
//sesion 10 parte 02
public interface ITutorialRepository
{
    //recordar que es una estructura donde se define lo que el metodo debe hacer 
    //pero no como debe hacerlo.
    // establezco la interfaz ItutorialRepository de lo que se va a tener disponible 
    // para el manejo de este conjunto de elementos. se ofrece a la capa de servicio 
    //la capacidad de recuperar todos los tutorials, agregar los tutorial, buscar el tutorial por Id, name
    /*la capacidad de buscar todo el conjunto de tutorial asociados a una misma categoria*/
    Task<IEnumerable<Tutorial>> ListAsync();
    Task AddAsync(Tutorial tutorial);
    Task<Tutorial> FindByIdAsync(int id);
    Task<Tutorial> FindByNameAsync(string name);

    Task<IEnumerable<Tutorial>> FindByCategoryId(int categoryId);

    void Update(Tutorial tutorial);
    void Remove(Tutorial tutorial);
}