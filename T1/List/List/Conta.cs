using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    abstract class Conta
    {
        public int Numero { get; set; }

        public string Titular { get; set; }

        public double Saldo { get; protected set; }

        public virtual void Depositar (double valorADepositar)
        {
            if(valorADepositar > 0)
            {
                this.Saldo += valorADepositar;
            }
        }

        public abstract bool Sacar(double valorDoSaque);        
        
    }
}
