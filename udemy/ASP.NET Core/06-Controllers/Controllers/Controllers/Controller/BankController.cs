using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Controllers.Controller;

[ApiController]
[Route("api/[controller]")]
public class BankController(IOptions<BankingOptions> options) : ControllerBase
{
    private readonly BankingOptions _banking = options.Value;

    [HttpGet]
    public IActionResult GetBank()
    {
        return Ok("Welcome to the Best Bank");
    }

    [HttpGet("account-details")]
    public IActionResult GetAccountDetails()
    {
        if (_banking.accountNumber == 0)
        {
            return BadRequest("Banking is not valid");
        }
        return Ok(_banking);
    }

    [HttpGet("get-current-balance/{accountNumber}")]
    public IActionResult GetCurrentBalance(string accountNumber)
    {
        if (_banking.accountNumber == 0)
        {
            return BadRequest("Banking is not valid");
        }

        if (_banking.accountNumber != int.Parse(accountNumber))
        {
            return NotFound("Account Number is not valid");
        }
        return Ok(_banking.currentBalance);
    }
}