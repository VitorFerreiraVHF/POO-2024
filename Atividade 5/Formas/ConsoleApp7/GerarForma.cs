using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class GerarForma
    {
          Triangulo triangulo = new Triangulo();
            Circuferencia circuferencia = new Circuferencia();
            Quadrado quadrado = new Quadrado();
        public void SolicitarForma()
        {
            Console.WriteLine("Qual forma você deseja utilizar para os calculos?\n1-Quadrado\n2-Triangulo\n3-Circulo");
            int escolhaFoforma = int.Parse(Console.ReadLine());
            Console.WriteLine("Deseja calcula a área(1) ou o perimetro(2)");
            int escolhaAP = int.Parse(Console.ReadLine());

            if (escolhaFoforma == 1 && escolhaAP == 1)
            {
                quadrado.calcularArea();
            } else if(escolhaFoforma == 1 && escolhaAP == 2)
                        { quadrado.calcularPerimetro();}

            if (escolhaFoforma == 2 && escolhaAP == 1)
            {
                triangulo.calcularArea();
            }
            else if (escolhaFoforma == 2 && escolhaAP == 2)
            { triangulo.calcularPerimetro(); }

            if (escolhaFoforma == 3 && escolhaAP == 1)
            {
                circuferencia.calcularArea();
            }
            else if (escolhaFoforma == 3 && escolhaAP == 2)
            { circuferencia.calcularPerimetro(); }
        }
    }
}
