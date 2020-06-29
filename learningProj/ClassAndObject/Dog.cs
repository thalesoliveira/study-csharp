using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObject
{
    public class Dog
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Porte { get; set; }
        public string NomeDoDono { get; set; }
        public string CorDoPelo { get; set; }


        public void Comer()
        {
            Console.WriteLine($"O {Nome} está comendo");
        }

        public string Latir()
        {
            return "Au au au";
        }


        public void Passear (bool estaChovendo)
        {
            if (estaChovendo)
                Console.WriteLine($"O {Nome} não poderá passear");
            else
                Console.WriteLine($"O {Nome} poderá passear");
        }



    }
}
