using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    internal class Assalariado : Empregado
    {
        public double salario { get; set; }

        public override double vencimento()
        {
            return salario;
        }
    }
}
