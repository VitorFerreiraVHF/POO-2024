using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_27_02_Poo
{
    internal class Produto
    {   
        public string Descricao;
        public double Valor;
        public double Desconto;

        public void AnaliseProduto() 
        {
            Console.WriteLine("Quanto custa o seu produto?");
            Valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Quanto de desconto o cliente está recebendo?");
            Desconto = double.Parse(Console.ReadLine());

            double DescPorcem = Valor * (Desconto / 100);

            Console.WriteLine("O valor do seu produto, com o desconto é: " + (Valor - DescPorcem));
        }
    }
}
