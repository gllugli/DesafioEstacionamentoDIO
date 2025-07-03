using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacionamentoDIO.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial = 0;
        private decimal PrecoPorHora = 0;
        private List<string> Veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.PrecoInicial = precoInicial;
            this.PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("\nDigite a placa: ");
            string? placa = Console.ReadLine();

            if (placa != null)
            {
                Veiculos.Add(placa);  
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            Console.WriteLine("\nDigite a placa: ");
            string? placa = Console.ReadLine();

            if (placa != null)
            {
                // Verifica se o veículo existe
                if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    int horas = 0;
                    decimal valorTotal = 0;

                    // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    horas = Convert.ToInt32(Console.ReadLine());

                    // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                    valorTotal = PrecoInicial + PrecoPorHora * horas;

                    // TODO: Remover a placa digitada da lista de veículos
                    Veiculos.Remove(placa);
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string i in Veiculos)
                {
                    Console.WriteLine($"Veículo: {i}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}