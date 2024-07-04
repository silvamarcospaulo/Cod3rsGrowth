using Cod3rsGrowth.Dominio.Auth;
using System.Collections;
using System.Security.Cryptography;
using System.Text;

namespace Cod3rsGrowth.Servico.ServicoJogador.ServicoAuth
{
    public class HashServico
    {
        public static string Gerar(string senhaUsuarioPura)
        {
            using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(ConfiguracaoChave.Segredo)))
            {
                var hashBytes =  hmac.ComputeHash(Encoding.UTF8.GetBytes(senhaUsuarioPura));

                StringBuilder senhaHash = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    senhaHash.Append(hashBytes[i].ToString("x2"));
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