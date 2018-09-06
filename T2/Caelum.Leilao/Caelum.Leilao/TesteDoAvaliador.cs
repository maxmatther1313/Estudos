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

        [Test]
        public void DeveCalcularAMediaDeTodos()
        {
            Usuario joao = new Usuario("João");
            Usuario jose = new Usuario("José");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(maria, 300.0));
            leilao.Propoe(new Lance(joao, 400.0));
            leilao.Propoe(new Lance(jose, 500.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(400, leiloeiro.MediaDeTodos, 0.0001);
        }
    }
}
