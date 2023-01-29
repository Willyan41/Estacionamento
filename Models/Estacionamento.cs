using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Projeto.Models
{
    public class Estacionamento
    {
        decimal PrecoInicial { get; set; }
        decimal PrecoPorHora { get; set; }
        List<string> Veiculos { get; set; } = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AddVeiculo()
        {
            Console.WriteLine("Informe a placa do veiculo: ");
            string placa = Console.ReadLine();
            Veiculos.Add(placa.ToUpper());
        }

        public void RemoverVeiculo()
        {
            decimal valorTotal = 0;
            Console.WriteLine("Informe a placa do veiculo que deseja retirar: ");
            string placa = Console.ReadLine();
            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Informe a quantidade de horas que o veiculo permaneceu no estacionamento:");
                int horaSaida = Convert.ToInt32(Console.ReadLine());
                valorTotal = PrecoInicial + (PrecoPorHora * horaSaida);
                Console.WriteLine($"o veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                Console.ReadLine();

            }
        }

        public void ListarVeiculo()
        {
            if (Veiculos != Veiculos.DefaultIfEmpty())
            {
                Console.WriteLine("Existem esse veiculos no estacionamento:\n");
                foreach (string veiculos in Veiculos)
                {
                    Console.WriteLine(veiculos);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Não tem veículo no estacionamento.");
                Console.ReadLine();
            }
        }


    }
}