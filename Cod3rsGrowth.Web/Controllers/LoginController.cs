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
            var diretorioToken = ObterCaminhoArquivoToken();

            var lerTokenTxt = System.IO.File.ReadAllLines(diretorioToken);

            var jogador = VerificarTokenTxt(lerTokenTxt, modelo.UsuarioJogador);

            if (jogador is not null)
            {
                jogador.Id = ObtemIdJogador(jogador, _jogadorServico);
            }
            else
            {
                jogador = AutenticaUsuarioSenhaJogador(modelo, _jogadorServico);

                if (jogador is null) return NotFound(new { BadRequest = "Não foi possível encontrar uma conta que corresponda ao que você inseriu." });

                var token = JwtServico.GeradorDeToken(jogador);

                var escreverTokenTxt = new StreamWriter(diretorioToken, true);

                escreverTokenTxt.WriteLine(token);

                escreverTokenTxt.Dispose();

                jogador.SenhaHashJogador = "";
            }

            return Ok(jogador);
        }

        private static Jogador AutenticaUsuarioSenhaJogador(Jogador jogador, JogadorServico jogadorServico)
        {
            var jogadorBanco = jogadorServico.ObterTodos(new JogadorFiltro() { UsuarioJogador = jogador.UsuarioJogador }).First();

            if (HashServico.Comparar(jogador.SenhaHashJogador, jogadorBanco?.SenhaHashJogador)) return jogadorBanco;

            return null;
        }

        private static string ObterCaminhoArquivoToken()
        {
            var diretorioLocal = AppDomain.CurrentDomain.BaseDirectory;

            var caminho = Path.Combine(diretorioLocal, @"..\..\..\..\Cod3rsGrowth.Infra\Auth\token.txt");

            return Path.GetFullPath(caminho);
        }

        private static Jogador VerificarTokenTxt(string[] tokenTxt, string usuario)
        {
            var handler = new JwtSecurityTokenHandler();

            var validations = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(ConfiguracaoChave.Segredo)),
                ValidateIssuer = false,
                ValidateAudience = false
            };

            foreach (var token in tokenTxt)
            {
                var jogador = handler.ValidateToken(token, validations, out var tokenSecure);

                if (jogador.Identity.Name == usuario) return new Jogador() { UsuarioJogador = usuario };
            }

            return null;
        }

        private static int ObtemIdJogador(Jogador jogador, JogadorServico jogadorServico)
        {
            var idJogador = jogadorServico.ObterTodos(new JogadorFiltro() { UsuarioJogador = jogador.UsuarioJogador }).First().Id;
            return idJogador;
        }
    }
}