using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository
{
    public interface ICartaRepository
    {
        List<Carta> ObterTodos();
        Carta ObterPorId(int idCarta);
        bool Atualizar (int idCarta);
        bool Excluir(int idCarta);
    }
}