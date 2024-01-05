using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinutosTelefone
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira abaixo o valor em minutos que o cliente utilizou:");

            int min;
            min = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Minutos utilizados: " + min);

            if(min <= 100) {

                Console.WriteLine("Valor a pagar: R$ 50,00");

            } else {

                int valor2;
                valor2 = ((min - 100) * 2) + 50;

                Console.WriteLine("Valor a pagar: R$ " + valor2 + ",00");

            }

            Console.ReadLine();

        }
    }
}
