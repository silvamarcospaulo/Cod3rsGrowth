using Cod3rsGrowth.Dominio.Auth;
using Cod3rsGrowth.Dominio.Modelos;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Cod3rsGrowth.Servico.ServicoJogador.ServicoToken
{
    public class JwtServico
    {
        public static Jogador AutenticarJogador(Jogador modelo, JogadorServico jogadorServico)
        {
            var diretorioToken = ObterCaminhoArquivoToken();
            var jogador = VerificarTokens(modelo, diretorioToken, jogadorServico);

            if (jogador?.NomeJogador is null)
            {
                jogador = RefreshToken(modelo, jogadorServico, diretorioToken);
            }

            return jogador;
        }

        private static Jogador RefreshToken(Jogador modelo, JogadorServico jogadorServico, string diretorioToken)
        {
            var jogador = JogadorServico.AutenticaUsuarioSenhaJogador(modelo, jogadorServico);

            if (jogador != null)
            {
                var token = GerarToken(jogador);

                using (var escreverTokenTxt = new StreamWriter(diretorioToken, true))
                {
                    escreverTokenTxt.WriteLine(token);
                }

                jogador.SenhaHashJogador = string.Empty;
            }

            return jogador;
        }

        private static string GerarToken(Jogador jogador)
        {
            const int numeroDeHorasParaExpirarToken = 8;
            var tokenHandler = new JwtSecurityTokenHandler();
            var chave = Encoding.ASCII.GetBytes(ConfiguracaoChave.Segredo);

            var tokenDescritor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, jogador.UsuarioJogador),
                    new Claim(ClaimTypes.Role, jogador.Role),
                    new Claim(ClaimTypes.NameIdentifier, jogador.Id.ToString()),
                }),
                Expires = DateTime.Now.AddHours(numeroDeHorasParaExpirarToken),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(chave), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescritor);
            return tokenHandler.WriteToken(token);
        }

        private static string ObterCaminhoArquivoToken()
        {
            var diretorioLocal = AppDomain.CurrentDomain.BaseDirectory;
            var caminho = Path.Combine(diretorioLocal, @"..\..\..\..\Cod3rsGrowth.Infra\Auth\token.txt");

            if (!File.Exists(caminho))
            {
                File.Create(caminho).Dispose();
            }

            return Path.GetFullPath(caminho);
        }

        private static bool ValidarToken(string token, string usuario)
        {
            var handler = new JwtSecurityTokenHandler();

            var validacoes = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(ConfiguracaoChave.Segredo)),
                ValidateIssuer = false,
                ValidateAudience = false
            };

            if (handler.ReadToken(token).ValidTo > DateTime.Now)
            {
                var jogador = handler.ValidateToken(token, validacoes, out var tokenSecure);
                return jogador.Identity.Name == usuario && handler.ReadToken(token).ValidTo > DateTime.Now;
            }

            return false;
        }

        private static Jogador VerificarTokens(Jogador modelo, string diretorioToken, JogadorServico jogadorServico)
        {
            var lerTokenTxt = File.ReadAllLines(diretorioToken).ToList();
            var tokensValidos = new List<string>();
            Jogador jogador = null;

            foreach (var token in lerTokenTxt)
            {
                if (ValidarToken(token, modelo.UsuarioJogador))
                {
                    jogador = JogadorServico.ObtemIdJogador(modelo.UsuarioJogador, jogadorServico);
                    tokensValidos.Add(token);
                }
            }

            AtualizarListaDeTokens(diretorioToken, tokensValidos);
            return jogador;
        }

        private static void AtualizarListaDeTokens(string diretorioToken, List<string> tokensValidos)
        {
            File.WriteAllLines(diretorioToken, tokensValidos);
        }
    }
}