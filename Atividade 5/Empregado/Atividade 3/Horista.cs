using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    internal class Horista : Empregado
    {
        public double precoHora { get; set; }
        public double horasTrabalhadas { get; set; }

        public override double vencimento()
        {
            return precoHora * horasTrabalhadas;
                
        }
    }
}
