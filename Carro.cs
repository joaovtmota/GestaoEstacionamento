using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVeiculo
{
    public class Carro : Veiculo
    {
        public Carro(string placa, string marca, string modelo) 
            : base(placa, marca, modelo) { }

        public override double CalcularValorCobrado()
        {
            double valorTotal = 12;
            if (HorasEstacionadas > 1)
            {
                valorTotal += (HorasEstacionadas - 1) * 3;
            }
            return valorTotal;
        }
    }
}