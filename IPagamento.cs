using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVeiculo
{
    public interface IPagamento
    {
        void FinalizarPagamento(double valorOriginal);
    }
}