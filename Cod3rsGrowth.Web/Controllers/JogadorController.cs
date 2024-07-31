using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoJogador;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cod3rsGrowth.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JogadorController : ControllerBase
    {
        private readonly JogadorServico _jogadorServico;

        public JogadorController(JogadorServico jogadorServico)
        {
            _jogadorServico = jogadorServico;
        }

        [HttpPost]
        public ActionResult Criar([FromBody] Jogador jogador)
        {
            if (jogador == null) return BadRequest("O jogador não pode ser nulo.");

            try
            {
                jogador.Id = _jogadorServico.Criar(jogador);
                return CreatedAtAction("Conta criada com sucesso!", jogador);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao criar jogador: {ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult ObterTodos([FromQuery] JogadorFiltro? filtro)
        {
            try
            {
                var jogadores = _jogadorServico.ObterTodos(filtro);

                if (jogadores == null || !jogadores.Any<Jogador>()) return NotFound("Nenhum jogador encontrado.");

                return Ok(jogadores);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao obter jogadores: {ex.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult ObterPorId([FromRoute] int id)
        {
            if (id <= 0) return BadRequest("ID inválido.");

            try
            {
                var jogador = _jogadorServico.ObterPorId(id);

                if (jogador == null) return NotFound("Jogador não encontrado.");

                return Ok(jogador);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao obter jogador: {ex.Message}");
            }
        }

        [HttpPatch("{id:int}")]
        public IActionResult Atualizar([FromBody] Jogador jogador)
        {
            if (jogador == null) return BadRequest("O jogador não pode ser nulo.");

            try
            {
                _jogadorServico.Atualizar(jogador);
                return Ok(jogador);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao atualizar jogador: {ex.Message}");
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult Excluir([FromRoute] int id)
        {
            if (id <= 0) return BadRequest("ID inválido.");

            try
            {
                _jogadorServico.Excluir(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao excluir jogador: {ex.Message}");
            }
        }
    }
}