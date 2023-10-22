using Microsoft.EntityFrameworkCore;

namespace LearningCenter.API02.Shared.Extensions;

public static class ModelBuilderExtensions
{
    public static void UseSnakeCaseNamingConvention(this ModelBuilder builder)
    {
        //voy a recorrer toda la coleccion de tipos entity que tiene el 
        //modelo
   
        foreach (var entity in builder.Model.GetEntityTypes())
        {
            entity.SetTableName(entity.GetTableName().ToSnakeCase());
            //no importa que tenga muchas entidades en el modelo 
            //a todas hare que sus tablas se conviertan en Snakecase
            foreach (var property in entity.GetProperties())
            {
                property.SetColumnName(property.GetColumnName().ToSnakeCase());
            }
            // para las claves
            foreach (var key in entity.GetKeys())
            {
                key.SetName(key.GetName().ToSnakeCase());
            }
            //foreign keys
            foreach (var foreignKey in entity.GetForeignKeys())
            {
                foreignKey.SetConstraintName(foreignKey.GetConstraintName().ToSnakeCase());
            }

            foreach (var index in entity.GetIndexes())
            {
                index.SetDatabaseName(index.GetDatabaseName().ToSnakeCase());
            }
        }
    }
}