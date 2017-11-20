﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void adiciona (ITributavel t)
        {
            this.Total += t.CalculaTributos(); 
        }
    }
}
