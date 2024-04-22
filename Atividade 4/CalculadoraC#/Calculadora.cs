using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraC_
{
    internal class Calculadora
    {
        public int Calcular = 0;
        Calculo calculo = new Calculo();


        public void LerValores()
        {
            Console.WriteLine("Primeiro número:");
            calculo.ValorA = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número:");
            calculo.ValorB= double.Parse(Console.ReadLine());
            Console.WriteLine("\nQual calculo você quer?");
            Console.WriteLine("1- Adicionar\n2- Subtrair\n3- Multiplicar\n4- Retornar o maior número\n5- Somar os dois números com o resultado anterior\n6- Sair da calculadora");
            calculo.tipoCalculo = double.Parse(Console.ReadLine());
        }

        public void executarCalculadora()
        {
            LerValores();
            switch (calculo.tipoCalculo)
            {
                case 1: calculo.calcularSoma(); break;
                case 2: calculo.calcularSubtracao(); break;
                case 3: calculo.calcularMultiplicacao(); break;
                case 4: calculo.retornarMaior(); break;
                case 5: calculo.somarGeral(calculo.Resultado); break;
                case 6: Calcular = 1; break;
            }

            calculo.imprimirResultado();
        }
    }


}
