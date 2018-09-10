using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace Caelum.Leilao
{
    [TestFixture]
    public class LeilaoTest
    {
        [Test]
        public void DeveReceberUmLance()
        {
            Leilao leilao = new Leilao("Macbook Pro 15");
            Assert.AreEqual(0, leilao.Lances.Count);
            
            leilao.Propoe(new Lance(new Usuario("Steve Jobs"), 2000));

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);
        }
        [Test]
        public void DeveReceberVariosLances()
        {
            Leilao leilao = new CriadorDeLeilao()
            .Para("Macbook Pro 15")
            .Lance(new Usuario("Steve Jobs"), 2000)
            .Lance(new Usuario("Steve Jobs"), 3000)
            .Constroi();

            Assert.AreEqual(2, leilao.Lances.Count);
            Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);
            Assert.AreEqual(3000, leilao.Lances[1].Valor, 0.0001);
        }
        [Test]
        public void NaoDeveAceitarDoisLancesSeguidosDoMesmoUsuario()
        {
            Usuario steveJobs = new Usuario("Steve Jobs");
            Leilao leilao = new CriadorDeLeilao()
                .Para("Macbook Pro 15")
                .Lance(steveJobs, 2000)
                .Lance(steveJobs, 3000)
                .Constroi();
                        

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);
        }
        [Test]
        public void NaoDeveAceitarMaisDoQue5LancesDeUmMesmoUsuario()
        {
            Usuario steveJobs = new Usuario("Steve Jobs");
            Usuario billGates = new Usuario("Bill Gates");

            Leilao leilao = new CriadorDeLeilao().Para("Macbook Pro 15")
                    .Lance(steveJobs, 2000)
                    .Lance(billGates, 3000)
                    .Lance(steveJobs, 4000)
                    .Lance(billGates, 5000)
                    .Lance(steveJobs, 6000)
                    .Lance(billGates, 7000)
                    .Lance(steveJobs, 8000)
                    .Lance(billGates, 9000)
                    .Lance(steveJobs, 10000)
                    .Lance(billGates, 11000)
                    .Lance(steveJobs, 12000)
                    .Constroi();

            Assert.AreEqual(10, leilao.Lances.Count);
            int ultimo = leilao.Lances.Count - 1;
            Assert.AreEqual(11000.0, leilao.Lances[ultimo].Valor, 0.00001);
        }
    }

}

