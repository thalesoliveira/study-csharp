using System;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog pastorAlemao = new Dog();

            pastorAlemao.Id = 1;
            pastorAlemao.Nome = "Rex";
            pastorAlemao.NomeDoDono = "Joao";
            pastorAlemao.Porte = "Medio";
            pastorAlemao.CorDoPelo = "Marrom e Preto";

            pastorAlemao.Comer();
            Console.WriteLine(pastorAlemao.Latir());

            pastorAlemao.Passear(true);
        }
    }
}
