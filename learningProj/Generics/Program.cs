using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto moto = new Moto();
            CalculoGenerico<Moto> calcMoto = new CalculoGenerico<Moto>();

            calcMoto.CalcularValorUnitario(moto);
            Console.WriteLine($"O Valor final da moto e {moto.ValorFinal}");

            Monitor monitor = new Monitor();
            CalculoGenerico<Monitor> calcMonitor = new CalculoGenerico<Monitor>();

            calcMonitor.CalcularValorUnitario(monitor);
            Console.WriteLine($"O Valor final da moto e {monitor.ValorFinal}");

        }
    }
}
