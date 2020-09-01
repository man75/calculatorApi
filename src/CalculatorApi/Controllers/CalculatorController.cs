using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        [Route("somme/{a}/{b}")]
        public float Somme(float a, float b)
        {
            return a + b;
           
        }
        [HttpGet]
        [Route("multiplication/{a}/{b}")]
        public float multi(float a, float b)
        {
            return a * b;

        }
        [HttpGet]
        [Route("masse/{energie}/{poids}")]
        public float Masse(float energie, float poids)
        {
            return energie + poids;

        }
    }
}
