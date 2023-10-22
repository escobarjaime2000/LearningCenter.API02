namespace LearningCenter.API02.Shared.Extensions;

public static class StringExtensions
{

   //funcion va a recibir un texto y lo convertirlo en snake
   //una extension toma la clase existente y redefinirla
   //agregando o extendiendola
   public static string ToSnakeCase(this string text)
   {
//IEnumerable es una interfaz que representa a una coleccion
      static IEnumerable<char> Convert(CharEnumerator e)
      {
         //si en esa coleccion enumerable ya no hay mas elementos
         //se sale con break 
         if (!e.MoveNext()) yield break; // si no hay siguiente
         // el caracter buscado se convierte a minuscula
         yield return char.ToLower(e.Current);
         while (e.MoveNext())
         {
            if (char.IsUpper(e.Current))
            {
               yield return '_';
               yield return char.ToLower(e.Current);
            }
            else
            {
               yield return e.Current;
            }

         }

      }

      //obtengo la capacidad de recorrerlo y luego a ese resultado
      //le coloco toArray
      //creo un nuevo string en base de la conversion del texto 
      //lo recorro con getEnumerator y el resultado lo
      //coloco en un array
      return new string(Convert(text.GetEnumerator()).ToArray());
      //CustomerId ---> customer_id
   }
}
