using Solid.Cap_1;
using Solid.Cap_2___Acoplamento_e_a_estabilidade;
using Solid.Cap_3___Classes_abertas__Open_Closed_e_Dependency_Inversion_Principles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aula_4 :
            //












            // Aula_3 : 
            //
            // Compra compra = new Compra();
            // CalculadoraDePrecos calculadora = new CalculadoraDePrecos(new TabelaDePrecoPadrao(), new Transportadora());

            // double resultado = calculadora.Calcula(compra);

            // Console.WriteLine("O preço da compra é : " + resultado);
            // Console.ReadKey();









            // Aula_2 :
            // --> Pattern = Observer
            //
            // EnviadorDeEmail enviador = new EnviadorDeEmail();
            // NotaFiscalDAO dao = new NotaFiscalDAO();

            // IList<IAcaoAposGerarNotaFiscal> acoes = new List<IAcaoAposGerarNotaFiscal>();
            // acoes.Add(new EnviadorDeEmail());
            // acoes.Add(new NotaFiscalDAO());
            // acoes.Add(new SAP());

            // GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes);
            // Fatura fatura = new Fatura(200, "Marcos Lull");
            // gerador.Gerar(fatura);

            // Console.ReadKey();







            // Aula_1 :
            //
            // CalculadoraDeSalario cs = new CalculadoraDeSalario();
            // Funcionario funcionario = new Funcionario(new Desenvolvedor(new DezOuVintePorcento()), 2000);
            // double resultado;

            // resultado = cs.Calcula(funcionario);

            // Console.WriteLine("O salário de um desenvolvedor que ganha 2000 bruto é : ", resultado);
            // Console.ReadKey();
        }
    }
}
