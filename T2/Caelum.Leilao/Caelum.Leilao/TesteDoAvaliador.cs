using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Caelum.Leilao
{
    [TestFixture]
    public class AvaliadorTest
    {
        [Test]
        public void DeveEntenderLancesEmOrdemCrescente()
        {
            // 1a parte: cenário
            Usuario joao = new Usuario("João");
            Usuario jose = new Usuario("Jose");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(maria, 250.0));
            leilao.Propoe(new Lance(joao, 300.0));
            leilao.Propoe(new Lance(jose, 400));

            // 2a parte: ação
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            // 3a parte: validação
            double maiorEsperado = 400;
            double menorEsperado = 250;

            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(menorEsperado, leiloeiro.MenorLance, 0.0001);            
        }

        // [Test]
        // public void DeveCalcularAMediaDeTodos()
        // {
        //     Usuario joao = new Usuario("João");
        //     Usuario jose = new Usuario("José");
        //     Usuario maria = new Usuario("Maria");

        //     Leilao leilao = new Leilao("Playstation 3 Novo");

        //     leilao.Propoe(new Lance(maria, 300.0));
        //     leilao.Propoe(new Lance(joao, 400.0));
        //     leilao.Propoe(new Lance(jose, 500.0));

        //     Avaliador leiloeiro = new Avaliador();
        //     leiloeiro.Avalia(leilao);

        //     Assert.AreEqual(400, leiloeiro.MediaDeTodos, 0.0001);
        // }


        [Test]
        public void DeveEntenderLancesEmOrdemCrescenteComOutrosValores()
        {
            // 1a parte: cenário
            Usuario joao = new Usuario("João");
            Usuario jose = new Usuario("Jose");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(maria, 1000.0));
            leilao.Propoe(new Lance(joao, 2000.0));
            leilao.Propoe(new Lance(jose, 3000));

            // 2a parte: ação
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            // 3a parte: validação            
            Assert.AreEqual(3000, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(1000, leiloeiro.MenorLance, 0.0001);
        }

        [Test]
        public void DeveEntenderLeilaoComApenasUmLance()
        {
            Usuario joao = new Usuario("João");
            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 1000.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(1000, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(1000, leiloeiro.MenorLance, 0.0001);
        }
        [Test]
        public void DeveEncontrarOsTresMaioresLances()
        {
            Usuario joao = new Usuario("Joao");
            Usuario maria = new Usuario("Maria");
            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 100.0));
            leilao.Propoe(new Lance(maria, 200.0));
            leilao.Propoe(new Lance(joao, 300.0));
            leilao.Propoe(new Lance(maria, 400.0));


            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(400, maiores[0].Valor, 0.0001);
            Assert.AreEqual(300, maiores[1].Valor, 0.0001);
            Assert.AreEqual(200, maiores[2].Valor, 0.0001);
        }
        [Test]
        public void DeveEntenderLeilaoComLancesEmOrdemRandomico()
        {
            Usuario joao = new Usuario("João");
            Usuario maria = new Usuario("Maria");
            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 200.0));
            leilao.Propoe(new Lance(maria, 450.0));
            leilao.Propoe(new Lance(joao, 120.0));
            leilao.Propoe(new Lance(maria, 700.0));
            leilao.Propoe(new Lance(joao, 630.0));
            leilao.Propoe(new Lance(maria, 230.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(700, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(120, leiloeiro.MenorLance, 0.0001);
        }
        [Test]
        public void DeveEntenderLeilaoComLancesEmOrdemDecrescente()
        {
            Usuario joao = new Usuario("João");
            Usuario maria = new Usuario("Maria");
            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 400.0));
            leilao.Propoe(new Lance(maria, 300.0));
            leilao.Propoe(new Lance(joao, 200.0));
            leilao.Propoe(new Lance(maria, 100.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(400, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(100, leiloeiro.MenorLance, 0.0001);
        }


        // Mão-Na-Massa:     -Exercícios-
        //
        //[Test]
        //public void DeveEncontrarOsTresMaiores()
        //{
        //    Usuario joao = new Usuario("João");
        //    Usuario maria = new Usuario("Maria");
        //    Leilao leilao = new Leilao("Playstation 3 Novo");

        //    leilao.Propoe(new Lance(joao, 500.0));
        //    leilao.Propoe(new Lance(maria, 650.0));
        //    leilao.Propoe(new Lance(joao, 320.0));
        //    leilao.Propoe(new Lance(maria, 250.0));

        //    Avaliador leiloeiro = new Avaliador();
        //    leiloeiro.Avalia(leilao);

        //    var maiores = leiloeiro.TresMaiores;

        //    Assert.AreEqual(3, maiores.Count);
        //    Assert.AreEqual(650, maiores[0].Valor, 0.0001);
        //    Assert.AreEqual(500, maiores[1].Valor, 0.0001);
        //    Assert.AreEqual(320, maiores[2].Valor, 0.0001);
        //}
        //[Test]
        //public void DeveDevolverTodosOsLancesCasoNaoHajaNoMinimo3()
        //{
        //    Usuario joao = new Usuario("João");
        //    Usuario maria = new Usuario("Maria");
        //    Leilao leilao = new Leilao("Playstation 3 Novo");

        //    leilao.Propoe(new Lance(joao, 300.0));
        //    leilao.Propoe(new Lance(maria, 500.0));

        //    Avaliador leiloeiro = new Avaliador();
        //    leiloeiro.Avalia(leilao);

        //    var maiores = leiloeiro.TresMaiores;

        //    Assert.AreEqual(2, maiores.Count);
        //    Assert.AreEqual(200, maiores[0].Valor, 0.0001);
        //    Assert.AreEqual(100, maiores[1].Valor, 0.0001);
        //}
        //[Test]
        //public void DeveDevolverUmaListaVaziaCasoNaoHajaNenhumLance()
        //{
        //    Leilao leilao = new Leilao("Playstation 3 Novo");

        //    Avaliador leiloeiro = new Avaliador();
        //    leiloeiro.Avalia(leilao);

        //    var maiores = leiloeiro.TresMaiores;

        //    Assert.AreEqual(0, maiores.Count);
        //}


    }
}
