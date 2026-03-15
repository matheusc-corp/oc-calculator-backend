using Microsoft.AspNetCore.Mvc;
using oc_calculator_backend.Models;

namespace oc_calculator_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpPost("calculate")]
        public IActionResult Calculate(int a, int b, string operation)
        {
            var result = 0;

            switch (operation)
            {
                case "+":
                    result = Sum(a, b);
                    break;
                case "-":
                    result = Subtract(a, b);
                    break;
                case "*":
                    result = Multiply(a, b);
                    break;
                case "/":
                    result = Divide(a, b);
                    break;
                default:
                    //throw new NotImplementedException();
                    return BadRequest("Invalid operation");
            }

            return Ok(result);
        }

        private int Sum(int a, int b)
        {
            return a + b;
        }

        private int Subtract(int a, int b)
        {
            return a - b;
        }

        private int Multiply(int a, int b)
        {
            return a * b;
        }

        private int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
