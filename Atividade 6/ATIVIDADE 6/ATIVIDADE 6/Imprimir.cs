using System;

namespace ATIVIDADE_6
{
    internal class Imprimir
    {
        public static documento solicitarTexto()
        {
            Console.WriteLine("Digite o texto a ser impresso:");
            string texto = Console.ReadLine();
            return new documento(texto);
        }

        public static void enviarImpressao(documento doc)
        {
            Impressora impressora = new Impressora(doc);
            impressora.Imprimir();
        }
    }
}
