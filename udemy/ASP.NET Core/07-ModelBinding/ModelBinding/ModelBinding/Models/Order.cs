using System.ComponentModel.DataAnnotations;
using ModelBinding.Validations;

namespace ModelBinding.Models;

public class Order
{
    public int? Number { get; set; }
    
    [Required]
    [CustomValidation(typeof(OrderValidation), "ValidateDateTime")]
    public DateTime Date { get; set; }
    
    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Invoice Price must be greater than 0")]
    public double InvoicePrice { get; set; }
    
    [Required]
    [MinLength(1, ErrorMessage = "Products must be at least 1 symbol")]
    public List<Product> Products { get; set; }
}