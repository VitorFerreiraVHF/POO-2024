using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Servico
{
    public class Client
    {
        public double SCORE;
        public void AnaliseDados()
        {
            Console.WriteLine("Quanto é o seu SCORE atual? (0 à 1000)");
            SCORE = double.Parse(Console.ReadLine());  


            if (SCORE >= 800 && SCORE < 1000)
            {
                Console.WriteLine("Bom cliente!!");
            }
            else if (SCORE < 800 &&SCORE > 500)
            {
                Console.WriteLine("Precisa de analise!");
            }
            else if (SCORE < 500)
            {
                Console.WriteLine("Precisa de outras análises");
            }
            else
            {
                Console.WriteLine("Insira um número valido (0 à 1000)");
            }
        }
    }
}