using LearningCenter.API02.Learning.Domain.Models;
using LearningCenter.API02.Learning.Resources;
using LearningCenter.API02.Shared.Extensions;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.API02.Learning.Persistence.Context;

public class AppDbContext:DbContext

{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<Category> Categories { get; set; }
    //sesion 10- parte 02--
    public DbSet<Tutorial> Tutorials { get; set; }
    protected override void OnModelCreating(ModelBuilder Builder)
    {
        base.OnModelCreating(Builder);
        
        //Categories
        Builder.Entity<Category>().ToTable("Categories");
        Builder.Entity<Category>().HasKey(p => p.Id);
        Builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        Builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
        
        
        
        //RelationShip

        Builder.Entity<Category>().HasMany(p => p.Tutorials)
                                  .WithOne(p=>p.Category)
                                  .HasForeignKey(p=>p.CategoryId);
              
        
        //tutorials estableciendo la relacion de uno a muchos 
        Builder.Entity<Tutorial>().ToTable("Tutorials");
        Builder.Entity<Tutorial>().HasKey(p =>p.Id);
        Builder.Entity<Tutorial>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        Builder.Entity<Tutorial>().Property(p => p.Name).IsRequired().HasMaxLength(50);
        Builder.Entity<Tutorial>().Property(p => p.Description).IsRequired().HasMaxLength(120);
        
        //aply naming conventions 
        Builder.UseSnakeCaseNamingConvention();
        
    }
}
