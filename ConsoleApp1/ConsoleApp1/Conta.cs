using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Conta
    {
        public String Titular { get; private set; }
        public double Saldo { get; set; }
        public EstadoDaConta Estado { get; set; }
        public string Agencia { get; internal set; }
        public string Numero { get; internal set; }
        public DateTime DataAbertura { get; internal set; }

        public Conta(String titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public Conta()
        {
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }

        public void Depositar(double valor)
        {
            Estado.Deposita(this, valor);
        }
    }
}
