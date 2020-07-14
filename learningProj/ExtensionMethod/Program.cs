using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            var texto = "A Lorem Lipsum ?? Or ... S hkrpdplj";
            
            Console.WriteLine($"O texto possui {texto.ContadorDePalavras()} palavras");
        }
    }
}
