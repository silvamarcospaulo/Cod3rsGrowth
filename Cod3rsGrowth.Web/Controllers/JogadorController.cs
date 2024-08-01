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
        public CreatedResult Criar([FromBody] Jogador jogador)
        {
            jogador.Id = _jogadorServico.Criar(jogador);
            return Created("Conta criada com sucesso!", jogador);
        }

        [HttpGet]
        public OkObjectResult ObterTodos([FromQuery] JogadorFiltro? filtro)
        {
            var jogadores = _jogadorServico.ObterTodos(filtro);
            return Ok(jogadores);
        }

        [HttpGet("{id}")]
        public OkObjectResult ObterPorId([FromRoute] int id)
        {
            var jogador = _jogadorServico.ObterPorId(id);
            return Ok(jogador);
        }

        [HttpPatch]
        public NoContentResult Atualizar([FromBody] Jogador jogador)
        {
            _jogadorServico.Atualizar(jogador);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public NoContentResult Excluir([FromRoute] int id)
        {
            _jogadorServico.Excluir(id);
            return NoContent();
        }
    }
}