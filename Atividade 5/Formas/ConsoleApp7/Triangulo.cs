using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Triangulo : Forma
    {
        public override void calcularArea()
        {
            Console.WriteLine("Digite o valor do lado A: ");
            double valorA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B: ");
            double valorB = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C: ");
            double valorC = double.Parse(Console.ReadLine());

            double s = (valorA + valorB + valorC) / 2;

            double area = Math.Sqrt(s * (s - valorA) * (s - valorB) * (s - valorC));

            Console.WriteLine("A área do seu triângulo é: " + area);

        }
            public override void calcularPerimetro()
        {
            Console.WriteLine("Digite o valor do lado A: ");
            double valorA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B: ");
            double valorB = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C: ");
            double valorC = double.Parse(Console.ReadLine());

            Console.WriteLine("O perimetro de seu triangulo é: " + (valorA + valorB + valorC));
        }
    }
}
