using DesignPatterns_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_2
{
    public class EnviadorDeEmail : AcaoAposGerarNotaFiscal
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Simulando envio de e-mail");
        }
    }
}
