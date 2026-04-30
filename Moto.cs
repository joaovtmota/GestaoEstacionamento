using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVeiculo
{
    public class Moto : Veiculo
    {
        public Moto(string placa, string marca, string modelo) 
            : base(placa, marca, modelo) { }

        public override double CalcularValorCobrado()
        {
            double valorTotal = 7;
            if (HorasEstacionadas > 1)
            {
                valorTotal += (HorasEstacionadas - 1) * 3;
            }
            return valorTotal;
        }
    }
}