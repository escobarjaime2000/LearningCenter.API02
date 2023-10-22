using LearningCenter.API02.Learning.Domain.Models;
using LearningCenter.API02.Shared.Extensions;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.API02.Learning.Persistence.Context;

public class AppDbContext:DbContext

{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<Category> Categories { set; get; }
    protected override void OnModelCreating(ModelBuilder Builder)
    {
        base.OnModelCreating(Builder);
        Builder.Entity<Category>().ToTable("Categories");
        Builder.Entity<Category>().HasKey(p => p.Id);
        Builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        Builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
        
        //aply naming conventions 
        Builder.UseSnakeCaseNamingConvention();
        
    }
}
