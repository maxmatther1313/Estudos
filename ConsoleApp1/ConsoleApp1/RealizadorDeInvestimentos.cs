using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RealizadorDeInvestimentos
    {
        void Realiza(Conta conta, Investimento investimento)
        {
            double resultado = investimento.Calcula(conta);
            conta.Deposita(resultado * 0.75);

            Console.WriteLine("Saldo Novo: " + conta.Saldo);            
        }
    }
}
