using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Models;

public abstract class Product
{
    [Key]
    public int ProductId { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Description { get; set; }
    [Required, Range(1, 1000)]
    public double Price { get; set; }

    [ValidateNever]
    public string ImageUrl { get; set; }

    // Foreign Key
    public int CategoryId { get; set; }
    [ForeignKey("CategoryId"), ValidateNever]
    public ProductCategory Category { get; set; }
}
