using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public class Aguia : IAves, IAvesQueVoam
    {
        public decimal CalcularAltitude()
        {
            throw new NotImplementedException();
        }

        public decimal CalcularLocalizacao()
        {
            throw new NotImplementedException();
        }
    }
}
