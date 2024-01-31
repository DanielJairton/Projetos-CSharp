using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Locadora
{
    internal class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo");
            string placa = Console.ReadLine();

            //if (veiculos.Any(x => x.Equals(placa.ToUpper())))
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("");
                Console.WriteLine("Já existe um veículo com essa placa");
                Console.WriteLine("");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("");
                Console.WriteLine("Veículo cadastrado com sucesso");
                Console.WriteLine("");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo ficou no estacionamento");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal precoTotal = precoInicial + precoHora * horas;

                veiculos.Remove(placa);
                Console.WriteLine($"Veículo com a placa {placa.ToUpper()} foi removido e deve pagar R$ {precoTotal}");
                Console.WriteLine("");
                Console.WriteLine("---------------Comprovante---------------");
                Console.WriteLine("");
                Console.WriteLine($"Placa: {placa.ToUpper()}");
                Console.WriteLine($"Horas: {horas}");
                Console.WriteLine($"Preço de entrada: R$ {precoInicial}");
                Console.WriteLine($"Preço por hora: R$ {precoHora}");
                Console.WriteLine("");
                Console.WriteLine($"Total: R$ {precoTotal}");
                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Não foi encontrado um veículo com essa placa");
                Console.WriteLine("");
            }
        }

        public void ListarVeiculo()
        {
            if ( veiculos.Any() )
            {
                Console.WriteLine("");
                Console.Write("Os veículos estacionados são:");
                Console.WriteLine("");
                foreach (var v in veiculos)
                {
                    Console.WriteLine($"- {v.ToUpper()}");
                }
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Não há veículos no pátio");
                Console.WriteLine("");
            }

        }
    }
}
