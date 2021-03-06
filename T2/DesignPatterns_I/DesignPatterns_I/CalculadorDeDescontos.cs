﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_1
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            Desconto d1 = new DescontoPor5Itens();
            Desconto d2 = new DescontoPorMaisDe500Reais();
            Desconto d3 = new DescontoPorVendoCasada();
            Desconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;                        
            
            return d1.Desconta(orcamento);            
        }
    }
}
