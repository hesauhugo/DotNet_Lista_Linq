using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListasLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Veiculo> veiculos = new List<Veiculo>();

            veiculos.Add(new Veiculo { Capacidade = 10, LocalDestino = 1 ,LocalOrigem = 1 });
            veiculos.Add(new Veiculo { Capacidade = 10, LocalDestino = 1, LocalOrigem = 1 });
            veiculos.Add(new Veiculo { Capacidade = 15, LocalDestino = 2, LocalOrigem = 2 });
            veiculos.Add(new Veiculo { Capacidade = 15, LocalDestino = 2, LocalOrigem = 2 });

            double total = veiculos.Sum((v) => v.Capacidade);
            Console.WriteLine("Total");
            Console.WriteLine(total);

            Console.WriteLine("Informações da lista");
            veiculos.ForEach((conteudo) => {
                Console.WriteLine($"Capacidade: {conteudo.Capacidade} Local Detino: {conteudo.LocalDestino} Local Origem:{conteudo.LocalOrigem}" ) ;
            });

            double somaTotal = veiculos.Where(w => w.LocalDestino is 1).Sum((v) => v.Capacidade);
            Console.WriteLine("Total Destino 1");
            Console.WriteLine(somaTotal);
            Console.ReadKey();

        }

        public class Veiculo
        {
            public int LocalOrigem;
            public int LocalDestino;
            public double Capacidade;
        }

    }
}
