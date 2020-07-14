using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class CalculoGenerico<T> where T : ICalculo
    {
        private decimal _imposto = 0.05m;
        private decimal _lucro = 0.05m;

        public void CalcularValorUnitario(T obj)
        {
            obj.ValorFinal += obj.ValorBruto;
            obj.ValorFinal += obj.ValorBruto * _imposto;
            obj.ValorFinal += obj.ValorBruto * _lucro;
        }
    }
}
