using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Cast
{
    class Program
    {
        static void Main(string[] args)
        {
            Programador dev = new Programador();

            dev.Nome = "Dev";
            dev.AnosCarreira = 10;
            dev.ConheceMetodologiaAgil = true;
            dev.Id = 5;
            dev.DataAdmissao = new DateTime(2020, 03, 03);
            dev.Linguagens = new List<string>() { "C#", "Javasvript" };


            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Diego";
            funcionario.DataAdmissao = new DateTime(2020, 03, 03);


            //Conversao implicita
            int varInt = 20;
            long varLong = varInt;

            float varFloat = 10.5F;
            double varDouble = varFloat;

            char varChar = 'T';
            int varInt1 = varChar;

            //interpolacao - caso não ouvesse o $, seria necessário a conversão das variaveis na string
            string texto = $"Conversao implicita de variavel inteira {varInt} e da variavel float {varFloat}";

            // conversao implicita da classe filha para a classe pai
            Funcionario devFunc = dev;

            Console.WriteLine(texto);


            //Conversao explicita
            long varLongExp = 9223372036854775807;
            int varIntExp = (int)varLongExp;

            varInt = (int)varLong;
            string longParaString = varLong.ToString();

            decimal varDecimal = Convert.ToDecimal("12,5");
            varDecimal += 10;

            decimal.TryParse("morango", out decimal varDecimalTry);

            //verifica se devFunc e do tipo Programador, se sim ele converte e atribuia a variavel info
            if (devFunc is Programador info)
                Console.WriteLine($"sim => {info.Nome}");

            if (funcionario is Programador infoFunc)
                Console.WriteLine($"nao => {infoFunc.Nome}");




        }

        public class Funcionario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public DateTime DataAdmissao { get; set; }
        }
        public class Programador : Funcionario
        {
            public int AnosCarreira { get; set; }
            public bool ConheceMetodologiaAgil { get; set; }
            public List<string> Linguagens { get; set; }
        }
    }


}
