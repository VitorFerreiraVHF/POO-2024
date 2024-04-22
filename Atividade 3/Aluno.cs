using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ativi02
{
    internal class Aluno
    {
        public int RA;
        public string nome;
        public double notaProva;
        public double notaTrabalho;
        public double notaFinal;

        public void receberDados()
        {
            Console.WriteLine("Insira os seguintes dados:");

            Console.WriteLine("Seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Seu RA:");
            RA = int.Parse(Console.ReadLine());

            Console.WriteLine("A nota da sua prova:");
            notaProva = double.Parse(Console.ReadLine());

            Console.WriteLine("A nota do seu trabalho");
            notaTrabalho = double.Parse(Console.ReadLine());
        }
        public void CalcularMedia()
        {
            notaFinal = (notaProva + notaTrabalho) / 2;
        }

        public void CalcularNotaFinal()
        {
            if (notaFinal < 7)
            {
                Console.WriteLine("Você está de progressão!");
                Console.WriteLine("Você precisa de: " + (7 - notaFinal) + " pontos.");
            } else
            {
                Console.WriteLine("Parabéns! Você está aprovado!");
            }
        }
        public void ImprimirNotaFinal()
        {
            Console.WriteLine("Sua nota final é: " + notaFinal);
        }

    }
}
