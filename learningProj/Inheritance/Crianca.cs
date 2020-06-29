using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Crianca : Pessoa
    {

        public Crianca(int id, string nome) : base(id, nome)
        {

        }

        public override void andar()
        {
            Console.WriteLine($"{Nome} ja sabe andar");
        }

        public override void dormir()
        {
            base.dormir();
        }

        //metodo implementado de forma obrigatoria devido esse metodo ser abstract na classe pai
        public override void estudar()
        {
           Console.WriteLine($"{Nome} esta estudando");
        }

    }
}
