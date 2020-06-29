using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Phone : ISom
    {
        public string Name{ get; set; }
        public int Id { get; set; }
        public string Resolution { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Emitindo Som");
        }
    }
}
