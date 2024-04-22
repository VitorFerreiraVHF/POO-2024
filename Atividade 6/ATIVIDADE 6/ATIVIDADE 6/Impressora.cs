using System;

namespace ATIVIDADE_6
{
    internal class Impressora
    {
        private documento documento;

        public Impressora(documento doc)
        {
            documento = doc;
        }

        public void Imprimir(int quantidadeCopias = 5)
        {
            for (int i = 0; i < quantidadeCopias; i++)
            {
                Console.WriteLine(documento.Texto);
            }
        }
    }
}
