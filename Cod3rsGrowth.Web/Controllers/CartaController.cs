using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoCarta;
using Microsoft.AspNetCore.Http;
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
        public IActionResult ObterTodos([FromQuery] CartaFiltro? filtro)
        {
            try
            {
                var cartas = _cartaServico.ObterTodos(filtro);

                if (cartas == null || !cartas.Any<Carta>()) return NotFound("Nenhuma carta encontrada.");

                return Ok(cartas);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao obter cartas: {ex.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult ObterPorId([FromRoute] int id)
        {
            if (id <= 0) return BadRequest("ID inválido.");

            try
            {
                var carta = _cartaServico.ObterPorId(id);

                if (carta == null) return NotFound("Carta não encontrada.");

                return Ok(carta);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao obter carta: {ex.Message}");
            }
        }
    }
}