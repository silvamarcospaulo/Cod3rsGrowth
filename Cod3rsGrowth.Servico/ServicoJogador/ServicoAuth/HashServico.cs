using Cod3rsGrowth.Dominio.Auth;
using System.Security.Cryptography;
using System.Text;

namespace Cod3rsGrowth.Servico.ServicoJogador.ServicoAuth
{
    public class HashServico
    {
        public static string Gerar(string senhaUsuarioPura)
        {
            const int valorInicialContador = 0;

            using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(ConfiguracaoChave.Segredo)))
            {
                var hashBytes =  hmac.ComputeHash(Encoding.UTF8.GetBytes(senhaUsuarioPura));

                StringBuilder senhaHash = new StringBuilder();
                for (int contador = valorInicialContador; contador < hashBytes.Length; contador++)
                {
                    senhaHash.Append(hashBytes[contador].ToString("x2"));
                }

                return senhaHash.ToString();
            }
        } 

        public static bool Comparar(string senhaUsuarioPura, string senhaBanco)
        {
            var senhaUsuarioHash = Gerar(senhaUsuarioPura);
            return senhaBanco == senhaUsuarioHash;
        }
    }
}