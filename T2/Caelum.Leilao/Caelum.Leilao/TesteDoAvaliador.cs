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

        private Avaliador leiloeiro;
        private Usuario maria;
        private Usuario jose;
        private Usuario joao;

        [SetUp]
        public void SetUp()
        {
            this.leiloeiro = new Avaliador();
            this.joao = new Usuario("João");
            this.jose = new Usuario("José");
            this.maria = new Usuario("Maria");
        }

        [Test]
        public void DeveEntenderLancesEmOrdemCrescente()
        {

            Leilao leilao = new CriadorDeLeilao()
                .Para("Playstation 3 Novo")
                .Lance(joao, 250)
                .Lance(jose, 300)
                .Lance(maria, 400)
                .Constroi();

            leiloeiro.Avalia(leilao);

            Assert.AreEqual(400.0, leiloeiro.MaiorLance, 0.00001);
            Assert.AreEqual(250.0, leiloeiro.MenorLance, 0.00001);
        }

        [Test]
        public void DeveEntenderLeilaoComApenasUmLance()
        {
            Leilao leilao = new CriadorDeLeilao()
            .Para("Playstation 3 Novo")
            .Lance(joao, 1000)
            .Constroi();

            leiloeiro.Avalia(leilao);

            Assert.AreEqual(1000.0, leiloeiro.MaiorLance, 0.00001);
            Assert.AreEqual(1000.0, leiloeiro.MenorLance, 0.00001);
        }

        [Test]
        public void DeveEncontrarOsTresMaioresLances()
        {
            Leilao leilao = new CriadorDeLeilao()
                .Para("Playstation 3 Novo")
                .Lance(joao, 100)
                .Lance(maria, 200)
                .Lance(joao, 300)
                .Lance(maria, 400)
                .Constroi();

            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;
            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(400.0, maiores[0].Valor, 0.00001);
            Assert.AreEqual(300.0, maiores[1].Valor, 0.00001);
            Assert.AreEqual(200.0, maiores[2].Valor, 0.00001);
        }
    }
}

