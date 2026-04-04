using Microsoft.AspNetCore.Mvc;
using oc_calculator_backend.Models;

namespace oc_calculator_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpPost("calculate")]
        public IActionResult Calculate(int firstValue, int secondValue, string operation)
        {
            var result = 0;

            switch (operation)
            {
                case "+":
                    result = Sum(firstValue, secondValue);
                    break;
                case "-":
                    result = Subtract(firstValue, secondValue);
                    break;
                case "*":
                    result = Multiply(firstValue, secondValue);
                    break;
                case "/":
                    result = Divide(firstValue, secondValue);
                    break;
                default:
                    //throw new NotImplementedException();
                    return BadRequest("Invalid operation");
            }

            return Ok(result);
        }

        private int Sum(int valueA, int  valueB)
        {
            return valueA +  valueB;
        }

        private int Subtract(int valueA, int  valueB)
        {
            return valueA -  valueB;
        }

        private int Multiply(int valueA, int  valueB)
        {
            return valueA *  valueB;
        }

        private int Divide(int valueA, int  valueB)
        {
            return valueA /  valueB;
        }
    }
}
