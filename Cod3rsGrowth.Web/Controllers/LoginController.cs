﻿using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Microsoft.AspNetCore.Http.HttpResults;
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
        public IActionResult Autenticacao([FromServices] Jogador modelo)
        {
            var jogador = jogadorServico.AutenticaLogin(modelo);

            if (jogador is null) return BadRequest(new { BadRequest = "Credenciais inválidas." });

            var token = JwtServico.GeradorDeToken(jogador);

            jogador.SenhaHashJogador = token;

            return new OkObjectResult(jogador);
        }
    }
}