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
        private JogadorServico _jogadorServico;

        public LoginController(JogadorServico jogadorServico)
        {
            _jogadorServico = jogadorServico;
        }
        
        [HttpPost]
        [Route("login")]
        public ActionResult Autenticacao([FromServices] Jogador modelo)
        {
            var jogador = JwtServico.AutenticarJogador(modelo, _jogadorServico);

            if (jogador is null)
                return NotFound(new { BadRequest = "Não foi possível encontrar uma conta que corresponda ao que você inseriu." });

            return Ok(jogador);
        }
    }
}