using System;
using System.Collections.Generic;
using System.Text;

/**
 * A palavra reservada virtual no metodo indica que este pode ser sobrescrito
 * 
 */

namespace Inheritance
{
    public abstract class Pessoa
    {

        //Atalho para criar construtor ctor + tab

        //Construtor obriga as classes filha a implementar um contrutor tambem devido a esta classe ser abstrata
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;

        }         
        
        public int  Id { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Nome { get; set; }

        public virtual void andar()
        {
            Console.WriteLine($"{Nome} andando");
        }

        public virtual void dormir()
        {
            Console.WriteLine($"{Nome} dormindo");
        }

        public abstract void estudar();

    }
}
