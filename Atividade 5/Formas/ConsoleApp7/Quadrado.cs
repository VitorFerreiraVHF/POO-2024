using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Quadrado : Forma
    {
        public override void calcularArea()
        {
            Console.WriteLine("Digite o valor do lado A: ");
            double valorA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B: ");
            double valorB = double.Parse(Console.ReadLine());

            Console.WriteLine("A area de seu quadrado é: " + (valorA * valorB));
        }

        public override void calcularPerimetro()
        {
            Console.WriteLine("Digite o valor do lado A: ");
            double valorA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B: ");
            double valorB = double.Parse(Console.ReadLine());

            Console.WriteLine("O perimetro de seu quadrado é: " + ((2 * valorA) + (2 * valorB)));
        }
    }
}
