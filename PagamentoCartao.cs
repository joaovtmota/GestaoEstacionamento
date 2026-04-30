using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVeiculo
{
    public class PagamentoCartao : IPagamento
    {
        public void FinalizarPagamento(double valorOriginal)
        {
            double taxa = valorOriginal * 0.02;
            double valorFinal = valorOriginal + taxa;


            Console.WriteLine($"Subtotal: R$ {valorOriginal:F2}");
            Console.WriteLine($"Taxa (2%): R$ {taxa:F2}");
            Console.WriteLine($"Total: R$ {valorFinal:F2}");
            Console.WriteLine("Pagamento aprovado!");
        }
    }
}