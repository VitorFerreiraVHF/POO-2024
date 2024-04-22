using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    internal class Comissionado : Empregado
    {
        public double totalVenda { get; set; }
        public double taxaComissao { get; set; }
        
        public override double vencimento()
        {
           return  totalVenda * (taxaComissao / 100);
        }

    }
}
