using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoAuth;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Security;

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
            var diretorioToken = ObterUrlArquivoToken();

            var lerTokenTxt = System.IO.File.ReadAllLines(diretorioToken);

            var jogador = AutenticaUsuarioSenhaJogador(modelo, _jogadorServico);

            if (jogador is null) return NotFound(new { BadRequest = "Não foi possível encontrar uma conta que corresponda ao que você inseriu." });

            var token = JwtServico.GeradorDeToken(jogador);

            jogador.SenhaHashJogador = "";

            return Ok(jogador);
        }

        public static Jogador AutenticaUsuarioSenhaJogador(Jogador jogador, JogadorServico jogadorServico)
        {
            var jogadorBanco = jogadorServico.ObterTodos(new JogadorFiltro() { UsuarioJogador = jogador.UsuarioJogador }).First();

            if (HashServico.Comparar(jogador.SenhaHashJogador, jogadorBanco?.SenhaHashJogador)) return jogadorBanco;

            return null;
        }

        public static string ObterUrlArquivoToken()
        {
            var diretorioLocal = AppDomain.CurrentDomain.BaseDirectory;
        
            var caminho =  Path.Combine(diretorioLocal, @"..\..\..\..\Cod3rsGrowth.Infra\Auth\token.txt");

            return Path.GetFullPath(caminho);
        }
    }
}