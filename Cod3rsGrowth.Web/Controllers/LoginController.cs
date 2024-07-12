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
            var diretorioToken = JwtServico.ObterCaminhoArquivoToken();

            var lerTokenTxt = System.IO.File.ReadAllLines(diretorioToken).ToList();

            var handler = new JwtSecurityTokenHandler();

            var jogador = new Jogador();

            var _lerTokenTxt = new List<string>();

            _lerTokenTxt.AddRange(lerTokenTxt);

            for (int contador = 0; contador < lerTokenTxt?.Count(); contador++)
            {
                if (JwtServico.VerificarTokenTxt(lerTokenTxt[contador], modelo.UsuarioJogador, handler))
                {
                    jogador = JogadorServico.ObtemIdJogador(modelo.UsuarioJogador, _jogadorServico);
                }
                else
                {
                    _lerTokenTxt.Remove(lerTokenTxt[contador]);
                }
            }
            
            System.IO.File.WriteAllLines(diretorioToken, _lerTokenTxt);

            if (jogador?.NomeJogador is null)
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