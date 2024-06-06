using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;
using Cod3rsGrowth.Teste.Singleton;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Teste.Repository
{
    public class JogadorRepositoryMock : IJogadorRepository
    {
        public List<Jogador> tabelasJogadores = SingletonTabelas.InstanciaJogadores;

        public void Inserir(Jogador jogador)
        {
            tabelasJogadores.Add(jogador);
        }

        public void Excluir(int idJogador)
        {
        }

        public Jogador ObterPorId(string idJogador)
        {
            return verificaIdJogador(idJogador) == false ? throw new Exception("Valor Invalido")
                : tabelasJogadores.FirstOrDefault(carta => carta.IdJogador == idJogador) ?? throw new Exception("Jogador Nao Encontrado");
        }

        public List<Jogador> ObterTodos()
        {
            return tabelasJogadores;
        }

        static public bool verificaIdJogador(string idJogador)
        {
            int tamanhoDeUmCpf = 11;
            int SomatorioDigitoUm = 0;
            int SomatorioDigitoDois = 0;

            if (idJogador.Length != tamanhoDeUmCpf) return false;

            for (int cont = 0; cont < (tamanhoDeUmCpf - 2); cont++)
            {
                SomatorioDigitoUm = SomatorioDigitoUm + ((int.Parse(idJogador[cont].ToString()) * (tamanhoDeUmCpf - (cont + 1))));
            }
            int valorDigitoUm = ((SomatorioDigitoUm * 10) % tamanhoDeUmCpf);
            if (valorDigitoUm > 9) valorDigitoUm = 0;
            if (valorDigitoUm != int.Parse(idJogador[9].ToString())) return false;

            for (int cont = 0; cont < (tamanhoDeUmCpf - 1); cont++)
            {
                SomatorioDigitoDois = SomatorioDigitoDois + ((int.Parse(idJogador[cont].ToString()) * (tamanhoDeUmCpf - cont)));
            }
            int valorDigitoDois = ((SomatorioDigitoDois * 10) % tamanhoDeUmCpf);
            if (valorDigitoDois > 9) valorDigitoDois = 0;
            if (valorDigitoDois != int.Parse(idJogador[10].ToString())) return false;

            return true;
        }
    }
}