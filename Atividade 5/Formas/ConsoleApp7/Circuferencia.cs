using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Circuferencia : Forma
    {   
        public override void calcularArea()
        {
            Console.WriteLine("Digite o raio do seu circuito: ");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine("A área do circulo é: " + (Math.PI * Math.Pow(raio, 2)));
        }

        public override void calcularPerimetro()
        {
            Console.WriteLine("Digite o raio do seu circuito: ");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine("A sua circuferencia é: " + ((2 * Math.PI) * raio));
        }
    }
}
