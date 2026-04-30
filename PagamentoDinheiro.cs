using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVeiculo
{
    public class PagamentoDinheiro : IPagamento
    {
        public void FinalizarPagamento(double valorOriginal)
        {
            Console.WriteLine($"Total: R$ {valorOriginal:F2}");
            Console.Write("Valor entregue: R$ ");
            double entregue = double.Parse(Console.ReadLine());

            if (entregue >= valorOriginal)
            {
                Console.WriteLine($"Troco: R$ {(entregue - valorOriginal):F2}");
                Console.WriteLine("Pagamento concluído.");
            }
            else
            {
                Console.WriteLine("Valor insuficiente!");
            }
        }
    }
}