using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraC_
{
    internal class Calculo
    {
        public double ValorA;
        public double ValorB;
        public double Resultado;
        public double tipoCalculo;

        public void calcularSoma()
        {
            Resultado = (ValorA + ValorB);
        }
        public void calcularSubtracao()
        {
            Resultado = (ValorA - ValorB);
        }
        public void calcularMultiplicacao()
        {
            Resultado = (ValorA * ValorB);
        }
        public double retornarMaior()
        {
            if (ValorA > ValorB)
            {
                return Resultado = ValorA;
            }
            return Resultado = ValorB;
        }

        public double somarGeral(double valor)
        {
            Resultado = valor + ValorA + ValorB;
            return Resultado;
        }

        public void imprimirResultado()
        {
            Console.WriteLine("Seu resultado: " + Resultado + ".\n");
        }
    }
}
