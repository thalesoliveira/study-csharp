using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            nomes.Add("Nomea");
            nomes.Add("Nomeb");
            nomes.Add("Nomec");

            Console.WriteLine(nomes[0]);

            nomes.ForEach(x =>
            {
                Console.WriteLine(x);
            });

            SortedList<int, int> dados = new SortedList<int, int>();
            dados.Add(5,5);
            dados.Add(4,4);
            dados.Add(3,3);
            dados.Add(2,2);
            dados.Add(1,1);

            Console.WriteLine(dados[2]);


            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("DF", "Distrito Federal");
            estados.Add("SC", "Santa Catarina");
            estados.Add("SP", "Sao Paulo");

            Console.WriteLine(estados["DF"]);

            Queue<int> senhasFila = new Queue<int>();
            senhasFila.Enqueue(1);
            senhasFila.Enqueue(2);
            senhasFila.Enqueue(3);
            senhasFila.Enqueue(4);
            senhasFila.Enqueue(5);

            senhasFila.Dequeue();
            Console.WriteLine(senhasFila.Peek());

            Stack<int> senhasPilha = new Stack<int>();

            senhasPilha.Push(1);
            senhasPilha.Push(2);
            senhasPilha.Push(3);
            senhasPilha.Push(4);

            senhasPilha.Pop();
            Console.WriteLine(senhasPilha.Peek());

        }
    }
}
