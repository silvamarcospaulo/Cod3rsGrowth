using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace Cod3rsGrowth.Web.Controllers
{
    [ApiController]
    [Route("v1")]
    public class LoginController : ControllerBase
    {
        private readonly JogadorServico _jogadorServico;

        public LoginController(JogadorServico jogadorServico)
        {
            _jogadorServico = jogadorServico;
        }

        [HttpPost]
        [Route("login")]
        public ActionResult Autenticacao([FromBody] Jogador modelo)
        {
            if (modelo == null) return BadRequest("Não foi possível encontrar uma conta que corresponda ao que você inseriu.");

            var jogador = JwtServico.AutenticarJogador(modelo, _jogadorServico);

            if (jogador is null) return NotFound("Usuário e senha não encontrados.");

            return Ok(jogador);
        }
    }
}