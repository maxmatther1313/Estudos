using DesignPatterns_II.Cap_II;
using DesignPatterns_II.Cap_III;
using DesignPatterns_II;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns_II.Cap_V;
using DesignPatterns_II.Cap_VI;

namespace DesignPatterns_II
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aula_VI :

            IMensagem mensagem = new MensagemDoCliente("victor");
            IEnviador enviador = new EnviaPorEmail();
            mensagem.Enviador = enviador;
            mensagem.Envia();







            // Aula_V :

            // ((1 + 10)) + (20 - 10))
            // + 1 100
            //IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            //IExpressao soma = new Soma(esquerda, direita);

            //Console.WriteLine(soma.Avalia());

            //ImpressoraVisitor impressora = new ImpressoraVisitor();
            //soma.Aceita(impressora);

            // Teste:
            // PreFixaVisitor prefixo = new PreFixaVisitor();
            // soma.Aceita(prefixo);







            // Aula_IV Interpreter:
            //
            // Interpreter => ((1 + 100) + 10) + (20 - 10)
            //IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));

            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));

            //IExpressao soma = new Soma(esquerda, direita);

            //Console.WriteLine(soma.Avalia());

            //Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            //Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();
            //Console.WriteLine(funcao());









            // Aula_III:
            //
            //Historico historico = new Historico();

            //Contrato c = new Contrato(DateTime.Now, "victor", TipoContrato.Novo);
            //historico.Adiciona(c.SalvaEstado());

            //c.Avanca();
            //historico.Adiciona(c.SalvaEstado());

            //c.Avanca();
            //historico.Adiciona(c.SalvaEstado());

            //Console.WriteLine(historico.Pega(0).Contrato.Tipo);







            // Aula_II:
            //
            //NotasMusicais notas = new NotasMusicais();
            //IList<INota> musica = new List<INota>()
            //{
            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("mi"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),

            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("re"),
            //    notas.Pega("re"),

            //    notas.Pega("do"),
            //    notas.Pega("sol"),
            //    notas.Pega("fa"),
            //    notas.Pega("mi"),
            //    notas.Pega("mi"),
            //    notas.Pega("mi"),

            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("mi"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa")

            //};

            //Piano piano = new Piano();
            //piano.Toca(musica);




            // Aula_I:
            //
            //IDbConnection conexao = new ConnectionFactory().GetConnection();
            //IDbCommand comando = conexao.CreateCommand();
            //comando.CommandText = "select * from tabela";

        }
    }
}
