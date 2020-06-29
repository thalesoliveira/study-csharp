using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Adulto : Pessoa
    {

        public Adulto(int id, string nome) : base(id, nome)
        {

        }

        public override void estudar()
        {
            Console.WriteLine($"{Nome} esta estudando");
        }
    }
}
