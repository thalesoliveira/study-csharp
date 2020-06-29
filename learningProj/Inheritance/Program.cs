using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Adulto maria = new Adulto(1, "Maria");

            //maria.Id = 1;
            //maria.Nome = "Maria";
            maria.DataDeNascimento = new DateTime(1990, 01, 01);

            maria.andar();
            maria.dormir();

            Crianca davi = new Crianca(2, "Davi");

            //davi.Id = 2;
            //davi.Nome = "Davi";
            davi.DataDeNascimento = new DateTime(2018, 01, 01);

            davi.andar();
            davi.dormir();

            Console.WriteLine(Calculo.Soma(2, 2));

        }
    }
}
