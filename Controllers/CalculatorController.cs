using Microsoft.AspNetCore.Mvc;

namespace SmartCalculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("calculate")]
        public IActionResult Calculate(double num1, double num2, string operation)
        {
            double result;

            switch (operation.ToLower())
            {
                case "add":
                    result = num1 + num2;
                    break;
                case "subtract":
                    result = num1 - num2;
                    break;
                case "multiply":
                    result = num1 * num2;
                    break;
                case "divide":
                    if (num2 == 0)
                        return BadRequest("Division by zero is not allowed");
                    result = num1 / num2;
                    break;
                case "power":
                    result = Math.Pow(num1, num2);
                    break;
                case "mod":
                    result = num1 % num2;
                    break;
                default:
                    return BadRequest("Invalid operation");
            }

            return Ok(new { result });
        }
    }
}
