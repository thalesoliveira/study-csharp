using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace ConditionsAndIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade");

            int.TryParse(Console.ReadLine(), out int idade);

            Console.WriteLine(idade);

            if (idade < 12)
            {
                Console.WriteLine("Crianca");
            }
            else if (idade > 12 && idade < 18)
            {
                Console.WriteLine("Menor");
            }
            else
            {
                Console.WriteLine("Maior");
            }

            //ternario
            String mensagem = idade >= 18 ? "Maior" : "Menor";

            //switch
            Console.WriteLine("Informe o mes de nascimento");
            var mes = Console.ReadLine();

            switch (mes.ToLower())
            {
                case "Janeiro":
                case "Fevereiro":
                    Console.WriteLine("Verao");
                    break;

                default:
                    Console.WriteLine("Outros");
                    break;
            }


            //List e Array => Array é necessário informar o tamanho e no list não é necesário
            string[] nomes = new string[5];

            nomes[0] = "Ana";
            nomes[1] = "Dell";
            nomes[2] = "C#";


            List<string> sobrenomes = new List<string>();
            sobrenomes.Add("teste");
            sobrenomes.Add("skills");


            for (int i = 0; i < sobrenomes.Count; i++)
            {
                Console.WriteLine($"Sobrenome {i + 1}: {sobrenomes[i]}");
            }

            foreach (string sobrenome in sobrenomes)
            {
                Console.WriteLine($"Sobrenome {sobrenome}");
            }

            sobrenomes.ForEach(sobrenome =>
                Console.WriteLine($"Sobrenome {sobrenome}"));

        }
    }
}
