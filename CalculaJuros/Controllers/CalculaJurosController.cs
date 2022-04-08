using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalculaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ILogger<CalculaJurosController> _logger;
        public CalculaJurosController(ILogger<CalculaJurosController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<CalculaJuros> Get(Double valorinicial, int tempo)
        {
            return Enumerable.Range(1, 1).Select(index => new CalculaJuros
            {
                Tempo = tempo,
                ValorInicial = valorinicial,
                Juros = 0.01,
                ValorFinal = (int)((int)(double)valorinicial * Math.Pow((int)((1 + 0.01)), tempo))
            })
            .ToArray();
        }
        [HttpGet]
        public IEnumerable<ShowMeTheCode> Get()
        {
            return Enumerable.Range(1, 1).Select(index => new ShowMeTheCode
            {
                Url = "https://github.com/mauridf/TesteDeSelecaoSquadra/tree/main/TesteSelecaoSquadra"
            })
            .ToArray();
        }
    }
}
