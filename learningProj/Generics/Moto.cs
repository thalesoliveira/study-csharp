using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Moto : ICalculo
    {
        public decimal ValorBruto { get; set; }
        public decimal ValorFinal { get ; set; }

        public Moto()
        {
            ValorBruto = 11000;
        }
    }
}
