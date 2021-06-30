using System;
using Microsoft.AspNetCore.Mvc;

namespace Corporate.DotnetSE.ExampleErrorHandlingCenter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        [HttpGet("with-error")]
        public IActionResult Get()
        {
            throw new Exception("Deu ruim ein....!, vou ter que entregar minha CTPS");
        }
    }
}