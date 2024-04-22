using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Forma
    {
        public double area { get; set; }
        public int perimetro { get; set; }

        public virtual void calcularArea()
        {
        }
        public virtual void calcularPerimetro()
        {
        }
    }
}
