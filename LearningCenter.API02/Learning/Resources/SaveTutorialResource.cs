using System.ComponentModel.DataAnnotations;

namespace LearningCenter.API02.Learning.Resources;

public class SaveTutorialResource
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    
    [MaxLength(120)]
    public string Description { get; set; }
    [Required]
    [MaxLength]
    public int CategoryId { get; set; }
}