using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Microsoft.AspNetCore.Mvc;

namespace Cod3rsGrowth.Web.Controllers
{
    [ApiController]
    [Route("v1")]
    public class LoginController : ControllerBase
    {
        private JogadorServico jogadorServico;
        public LoginController(JogadorServico _jogadorServico)
        {
            jogadorServico = _jogadorServico;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Autenticacao([FromBody] Jogador modelo)
        {
            var jogador = jogadorServico.ObterPorLogin(modelo);

            if (jogador is null) return NotFound(new {message = "Credenciais inválidas."});

            var token = TokenServico.GeradorDeToken(jogador);

            jogador.SenhaHashJogador = "";

            jogador.TokenJogador = token;

            return jogador;
        }



    }
}