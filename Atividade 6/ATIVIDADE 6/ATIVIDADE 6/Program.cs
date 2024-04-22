using System;

namespace ATIVIDADE_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            documento doc = Imprimir.solicitarTexto();
            Imprimir.enviarImpressao(doc);
        }
    }
}
