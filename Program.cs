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



            double valorAPagar = veiculoEscolhido.CalcularValorCobrado();

            Console.WriteLine("\nEscolha a forma de pagamento:");
            Console.WriteLine("1 - Cartão (Acréscimo de 2%)");
            Console.WriteLine("2 - Dinheiro");
            Console.WriteLine("3 - PIX");
            Console.Write("Opção: ");
            int opcaoPagamento = int.Parse(Console.ReadLine());

            IPagamento metodoPagamento = null;

            if (opcaoPagamento == 1)
            {
                metodoPagamento = new PagamentoCartao();
            }
            else if (opcaoPagamento == 2)
            {
                metodoPagamento = new PagamentoDinheiro();
            }
            else if (opcaoPagamento == 3)
            {
                metodoPagamento = new PagamentoPix();
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

            if (metodoPagamento != null)
            {
                metodoPagamento.FinalizarPagamento(valorAPagar);
            }

            Console.ReadKey();
        }
    }
}