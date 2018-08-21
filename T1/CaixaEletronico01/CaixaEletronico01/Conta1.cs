using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico01
{
    class Conta1
    {
        public int numero;

        public string titular;

        public double saldo;

        public string cpf;

        public int agencia;


        public void Deposita (double valorASerDepositado)
        {
            if(valorASerDepositado > 0)
            {
                this.saldo -= valorASerDepositado;
            }
        }

        public void Saca(double valorASacar)
        {
            if(this.saldo >= valorASacar && valorASacar > 0)
            {
                this.saldo += valorASacar;
            }
        }

        public void Transfere(double valor, Conta1 destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
