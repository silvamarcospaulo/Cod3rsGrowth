﻿using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public interface IServicoCarta
    {
        Carta NovaCarta(string nomeCarta, double custoDeManaConvetido,
            RaridadeEnum raridadeCarta, List<CoresEnum> corCarta);
        int GerarIdCarta(List<Carta> quantidadeDeCartasNoBancoDeDados);
        decimal GerarPrecoCarta(RaridadeEnum raridadeDaCarta);
        List<CoresEnum> AdicionarCoresDaCarta(string cor);
    }
}