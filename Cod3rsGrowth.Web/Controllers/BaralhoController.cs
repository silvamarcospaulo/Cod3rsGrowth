using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Microsoft.AspNetCore.Mvc;

namespace Cod3rsGrowth.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaralhoController : ControllerBase
    {
        private readonly BaralhoServico _baralhoServico;

        public BaralhoController(BaralhoServico baralhoServico)
        {
            _baralhoServico = baralhoServico;
        }

        [HttpPost]
        public ActionResult Criar([FromBody] Baralho baralho)
        {
            if (baralho == null) return BadRequest("O baralho não pode ser nulo.");

            try
            {
                baralho.Id = _baralhoServico.Criar(baralho);
                return CreatedAtAction("Baralho criado com sucesso!", baralho);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao criar baralho: {ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult ObterTodos([FromQuery] BaralhoFiltro? filtro)
        {
            try
            {
                var baralhos = _baralhoServico.ObterTodos(filtro);

                if (baralhos == null || !baralhos.Any<Baralho>()) return NotFound("Nenhum baralho encontrado.");

                return Ok(baralhos);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao obter baralhos: {ex.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult ObterPorId([FromRoute] int id)
        {
            if (id <= 0) return BadRequest("ID inválido.");

            try
            {
                var baralho = _baralhoServico.ObterPorId(id);

                if (baralho == null) return NotFound("Baralho não encontrado.");

                return Ok(baralho);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao obter baralho: {ex.Message}");
            }
        }

        [HttpPatch("{id:int}")]
        public IActionResult Atualizar([FromBody] Baralho baralho)
        {
            if (baralho == null) return BadRequest("O baralho não pode ser nulo.");

            try
            {
                _baralhoServico.Atualizar(baralho);
                return Ok(baralho);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao atualizar baralho: {ex.Message}");
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult Excluir([FromRoute] int id)
        {
            if (id <= 0) return BadRequest("ID inválido.");

            try
            {
                _baralhoServico.Excluir(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao excluir baralho: {ex.Message}");
            }
        }
    }
}