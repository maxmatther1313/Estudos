﻿using DesignPatterns_II.Cap_V;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_II
{
    interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }
}