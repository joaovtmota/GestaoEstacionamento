using System;

namespace ExercicioVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tipo (1-Carro / 2-Moto): ");
            int opcao = int.Parse(Console.ReadLine());

            Console.Write("Placa: ");
            string placa = Console.ReadLine();

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Horas: ");
            int horas = int.Parse(Console.ReadLine());

            Veiculo veiculoEscolhido;

            if (opcao == 1)
                veiculoEscolhido = new Carro(placa, marca, modelo);
            else
                veiculoEscolhido = new Moto(placa, marca, modelo);

            veiculoEscolhido.HorasEstacionadas = horas;

            Console.WriteLine("\nVeiculo: " + veiculoEscolhido.Marca + " " + veiculoEscolhido.Modelo);
            Console.WriteLine("Placa: " + veiculoEscolhido.Placa);
            Console.WriteLine("Tempo: " + veiculoEscolhido.HorasEstacionadas + "horas");
            Console.WriteLine("Valor a pagar: R$ " + veiculoEscolhido.CalcularValorCobrado());

            Console.ReadKey();
        }
    }
}