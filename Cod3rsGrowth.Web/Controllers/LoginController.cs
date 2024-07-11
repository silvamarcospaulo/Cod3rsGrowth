using Cod3rsGrowth.Dominio.Auth;
using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoAuth;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

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
            var diretorioToken = JwtServico.ObterCaminhoArquivoToken();

            var lerTokenTxt = System.IO.File.ReadAllLines(diretorioToken);

            var jogador = JwtServico.VerificarTokenTxt(lerTokenTxt, modelo.UsuarioJogador);

            if (jogador is not null)
            {
                jogador.Id = JogadorServico.ObtemIdJogador(jogador, _jogadorServico);
            }
            else
            {
                jogador = JogadorServico.AutenticaUsuarioSenhaJogador(modelo, _jogadorServico);

                if (jogador is null) return NotFound(new { BadRequest = "Não foi possível encontrar uma conta que corresponda ao que você inseriu." });

                var token = JwtServico.GeradorDeToken(jogador);

                var escreverTokenTxt = new StreamWriter(diretorioToken, true);

                escreverTokenTxt.WriteLine(token);

                escreverTokenTxt.Dispose();

                jogador.SenhaHashJogador = "";
            }

            return Ok(jogador);
        }
    }
}