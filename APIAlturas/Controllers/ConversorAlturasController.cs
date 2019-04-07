using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alturas;
using Microsoft.AspNetCore.Mvc;

namespace APIAlturas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversorAlturasController : Controller
    {
        // GET api/values
        [HttpGet("PesParaMetros/{pes}")]
        public object Get(double pes)
        {
            return new 
            {
                alturaPes = pes,
                alturaMetros = ConversorAlturas.PesParaMetros(pes)
            };
        }
    }
}
