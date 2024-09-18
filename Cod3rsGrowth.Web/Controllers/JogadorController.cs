using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
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
        [Route("login")]
        public IActionResult Autenticacao([FromBody] Jogador modelo)
        {
            var jogador = JwtServico.AutenticarJogador(modelo, _jogadorServico);

            return Ok(jogador);
        }

        [HttpPost]
        public CreatedResult Criar([FromBody] Jogador jogador)
        {
            _jogadorServico.Criar(jogador);
            return Created(jogador.Id.ToString(), jogador);
        }

        [HttpGet]
        public OkObjectResult ObterTodos([FromQuery] JogadorFiltro? filtro)
        {
            var jogadores = _jogadorServico.ObterTodos(filtro);
            foreach (var jogador in jogadores)
            {
                jogador.SenhaHashJogador = string.Empty;
                jogador.SenhaHashConfirmacaoJogador = string.Empty;
            };

            return Ok(jogadores);
        }

        [HttpGet("{id}")]
        public OkObjectResult ObterPorId([FromRoute] int id)
        {
            var jogador = _jogadorServico.ObterPorId(id);
            jogador.SenhaHashJogador = string.Empty;
            jogador.SenhaHashConfirmacaoJogador = string.Empty;
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