using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateOrder([FromBody][Bind("OrderDate,InvoicePrice,Products")] Order order)
    {
        var calculatedInvoicePrice = order.Products.Sum(p => p.Price * p.Quantity);
        if (order.InvoicePrice != calculatedInvoicePrice)
        {
            return BadRequest("InvoicePrice doesn't match with the total cost of the specified products in the order.");
        }
        
        // Generate a random order number
        Random random = new Random();
        order.Number = random.Next(1, 99999);

        // Return the new order number in the response
        return Ok(order);
    }
}
