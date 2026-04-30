using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVeiculo
{
    public class PagamentoPix : IPagamento
    {
        public void FinalizarPagamento(double valorOriginal)
        {
            string chave = Guid.NewGuid().ToString();
            Console.WriteLine($"Total: R$ {valorOriginal:F2}");
            Console.WriteLine($"Chave Copia e Cola: {chave}");
            Console.WriteLine("Pagamento recebido!");
        }
    }
}