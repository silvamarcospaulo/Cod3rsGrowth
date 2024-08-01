using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Servico.ServicoCarta;
using Microsoft.AspNetCore.Mvc;

namespace Cod3rsGrowth.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartaController : ControllerBase
    {
        private readonly CartaServico _cartaServico;

        public CartaController(CartaServico cartaServico)
        {
            _cartaServico = cartaServico;
        }

        [HttpGet]
        public OkObjectResult ObterTodos([FromQuery] CartaFiltro? filtro)
        {
            var cartas = _cartaServico.ObterTodos(filtro);

            return Ok(cartas);
        }

        [HttpGet("{id}")]
        public OkObjectResult ObterPorId([FromRoute] int id)
        {
            var carta = _cartaServico.ObterPorId(id);

            return Ok(carta);
        }
    }
}