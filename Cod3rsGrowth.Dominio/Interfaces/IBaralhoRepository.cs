using System;
using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Dominio.Interfaces
{
    public interface IBaralhoRepository
    {
        int Criar(Baralho baralho);
        void Atualizar(Baralho baralho);
        void Excluir(int idBaralho);
        Baralho ObterPorId(int idBaralho);
        List<Baralho> ObterTodos(BaralhoFiltro? filtro);
        void CriarCopiaDeCartas(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho);
        void AtualizarCopiaDeCartas(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho);
        void ExcluirCopiaDeCartas(int idCopiaDeCartasNoBaralho);
        CopiaDeCartasNoBaralho ObterPorIdCopiaDeCartas(int idCopiaDeCartasNoBaralho);
        List<CopiaDeCartasNoBaralho> ObterTodosCopiaDeCartas(CopiaDeCartasNoBaralhoFiltro filtro);
    }
}