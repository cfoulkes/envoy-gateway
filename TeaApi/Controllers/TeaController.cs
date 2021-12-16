using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Teas = new[]
        {
            "Black", "Green", "Earl Grey", "Darjeeling"
        };


        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();

            return Ok(Teas[rng.Next(Teas.Length)]);
        }
    }
}
