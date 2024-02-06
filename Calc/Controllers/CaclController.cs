using Calc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Calc.Controllers
{
    [Route("api/calc")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        public ICalcRepository Actions { get; set; }
        public CalcController(ICalcRepository actoins)
        {
            Actions = actoins;
        }
      

        [HttpPost("plus")]
        public IActionResult plus([FromBody] Values values)
        {
            return Ok(Actions.Plus(values));
        }

        [HttpPost("minus")]
        public IActionResult minus([FromBody] Values values)
        {
            return Ok(Actions.Minus(values));
        }

        [HttpPost("division")]
        public IActionResult division([FromBody] Values values)
        {
            if (values.num2 == 0)
            {
                return BadRequest("Делитель не может быть равен нулю");
            }
            return Ok(Actions.Division(values));
        }

        [HttpPost("multiplication")]
        public IActionResult multiplication([FromBody] Values values)
        {
            return Ok(Actions.Multiplication(values));
        }

        [HttpPost("pow")]
        public IActionResult pow([FromBody] Values values)
        {
            return Ok(Actions.Pow(values));
        }

        [HttpPost("sqrt")]
        public IActionResult sqrt([FromBody] Values values)
        {
            if (values.num1 < 0)
            {
                return BadRequest();
            }
            return Ok(Actions.Sqrt(values));
        }

        [HttpPost("calcFromString")]
        public IActionResult Test([FromBody] Values values)
        {
            return Ok(Actions.CalcFromString(values));
        }

    }
}
