using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Cap_2___Acoplamento_e_a_estabilidade
{
    class Fatura
    {
        public double ValorMensal { get; set; }
        public string Cliente { get; private set; }

        public Fatura(double valor, string cliente)
        {
            this.ValorMensal = valor;
            this.Cliente = cliente;
        }
    }
}
