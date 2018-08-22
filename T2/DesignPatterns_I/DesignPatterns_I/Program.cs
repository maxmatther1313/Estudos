using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_1
{
    class Program 
    {
        static void Main(String[] args)
        {
            CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal();
            criador.ParaEmpresa("Caleum Ensino e Inovação")
                   .ComCnpj("23.456.789/0001-12")
                   .ComItem(new ItemDaNota("item 1", 100.0))
                   .ComItem(new ItemDaNota("item 2", 200.0))
                   .NaDataAtual()
                   .ComObservacoes("uma obs qualquer");


            criador.AdicionaAcao(new Multiplicador(2));
            criador.AdicionaAcao(new Multiplicador(3));
            criador.AdicionaAcao(new Multiplicador(5.5));

            //criador.AdicionaAcao(new EnviadorDeEmail());
            //criador.AdicionaAcao(new NotaFiscalDAO());
            //criador.AdicionaAcao(new EnviadorDeSms());

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            Console.ReadKey();










           /* IList<Conta> contas = new List<Conta>();
            Conta conta = new Conta();
            conta.Deposita(90);
            contas.Add(conta);
            conta = new Conta();
            conta.Deposita(550);
            contas.Add(conta);

        Filtro filtro = new FiltroMenorQue100Reais(new FiltroMaiorQue500MilReais());

            Console.ReadKey();*/


           /* Imposto impostos = new ImpostoMuitoAlto(new ICMS());

            Orcamento orcamento = new Orcamento(500.0);

            Console.WriteLine(impostos.Calcula(orcamento));
            */

            /*Imposto iss = new ISS(new ICMS());

            Orcamento orcamento = new Orcamento(500);

            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);

            Console.ReadKey();*/
        }
    }
}
