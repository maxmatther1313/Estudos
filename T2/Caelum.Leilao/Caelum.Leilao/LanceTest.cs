﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace Caelum.Leilao
{
    [TestFixture]
    public class LanceTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveRecusarLancesComValorDeZero()
        {
            new Lance(new Usuario("John Doe"), 0);
        }
        [Test]
        [Ex]
    }
}
