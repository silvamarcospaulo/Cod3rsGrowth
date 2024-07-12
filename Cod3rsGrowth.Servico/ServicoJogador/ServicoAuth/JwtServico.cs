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
        public static string GeradorDeToken(Jogador jogador)
        {
            var numeroDeHorasParaExpirarToken = 8;
            var tokenHandler = new JwtSecurityTokenHandler();
            var chave = Encoding.ASCII.GetBytes(ConfiguracaoChave.Segredo);

            var tokenDescritor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, jogador.UsuarioJogador),
                    new Claim(ClaimTypes.Role, jogador.Role),
                    new Claim(ClaimTypes.NameIdentifier, jogador.Id.ToString()),
                    new Claim("id", jogador.Id.ToString())
                }),
                Expires = DateTime.Now.AddHours(numeroDeHorasParaExpirarToken),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(chave), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescritor);
            return tokenHandler.WriteToken(token);
        }

        public static string ObterCaminhoArquivoToken()
        {
            var diretorioLocal = AppDomain.CurrentDomain.BaseDirectory;

            var caminho = Path.Combine(diretorioLocal, @"..\..\..\..\Cod3rsGrowth.Infra\Auth\token.txt");
            if (!File.Exists(caminho)) File.Create(caminho);

            return Path.GetFullPath(caminho);
        }

        public static bool VerificarTokenTxt(string token, string usuario, JwtSecurityTokenHandler handler)
        {
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
                if (jogador.Identity.Name == usuario) return true;
            }

            return false;
        }
    }
}