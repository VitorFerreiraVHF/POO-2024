using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    public abstract class Empregado
    {
        private protected string Nome { get; set; }
        private protected string Sobrenome { get; set; }
        private protected string CPF { get; set; }

        public virtual double vencimento()
        {
            return 0;
        }
    }
}
