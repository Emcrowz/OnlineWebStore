using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Models;

public class ProductCategory
{
    [Key]
    public int Id { get; set; }
    [Required, DisplayName("Category Name"), MaxLength(10)]
    public string? Name { get; set; }
    [Required, DisplayName("Category Description"), MaxLength(50)]
    public string? Description { get; set; }
}
