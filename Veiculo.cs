using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVeiculo
{
    public abstract class Veiculo
    {
        private string placa;
        private string marca;
        private string modelo;

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }

        public int HorasEstacionadas { get; set; }

        public Veiculo(string placa, string marca, string modelo)
        {
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
        }
        public abstract double CalcularValorCobrado();
    }
}