using System.ComponentModel.DataAnnotations;

namespace ModelBinding.Models;

public class Product
{
    [Required]
    public int ProductCode { get; set; }
    
    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
    public double Price { get; set; }
    
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than zero.")]
    public int Quantity { get; set; }
}