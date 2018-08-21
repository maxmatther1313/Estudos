
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class ContaPoupanca : Conta
    {
        public override bool Sacar(double valorDoSaque)
        {
            if(valorDoSaque > this.Saldo || valorDoSaque < 0)
            {
                return false;
            }
            else
            {
                this.Saldo -= valorDoSaque;
                return true;
            }
        }
    }
}
