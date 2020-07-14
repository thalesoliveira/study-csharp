using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Monitor : ICalculo
    {
        public decimal ValorBruto { get ; set; }
        public decimal ValorFinal { get ; set; }

        public Monitor()
        {
            ValorBruto = 350;
        }
    }
}
