using LinqAndLambda.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambda
{
    class LoadDados
    {

        public static List<Aluno> LoadAlunos()
        {
            return new List<Aluno>()
            {
                new Aluno()
                {
                    Id = 1,
                    Nome = "Aluno 1",
                    Telefone = "1111-1111",
                    DataNasc = new DateTime(1990,05,20),
                    Email = "aluno1@gmail.com"
                },
                new Aluno()
                {
                    Id = 2,
                    Nome = "Aluno 2",
                    Telefone = "2222-2222",
                    DataNasc = new DateTime(2000,01,15),
                    Email = "aluno2@gmail.com"
                },
                new Aluno()
                {
                    Id = 3,
                    Nome = "Aluno 3",
                    Telefone = "3333-3333",
                    DataNasc = new DateTime(1980,09,23),
                    Email = "aluno3@gmail.com"
                }

            };
        }

        public static List<Curso> LoadCursos()
        {
            return new List<Curso>() {
                new Curso(){
                    Id = 1,
                    NomeDoCurso = "Aceleração de C#",
                    Descricao = "Curso Intensivo de C# para iniciantes"
                },
                new Curso(){
                    Id = 1,
                    NomeDoCurso = "Aceleração de React",
                    Descricao = "Curso Intensivo de React para iniciantes"
                },
                new Curso(){
                    Id = 1,
                    NomeDoCurso = "Aceleração de PHP",
                    Descricao = "Curso Intensivo de PHP para iniciantes"
                }
            };
        }

        public static List<Professor> LoadProfessores()
        {
            return new List<Professor>()
            {
                new Professor()
                {
                    Id = 1,
                    DataNasc = new DateTime(1988, 09, 30),
                    Email = "Professor1@gmail.com",
                    Telefone = "1111-1111",
                    AptoParaCuros = new List<int>(){1}
                },
                new Professor()
                {
                    Id = 2,
                    DataNasc = new DateTime(1990, 05, 01),
                    Email = "Professor2@gmail.com",
                    Telefone = "2222-2222",
                    AptoParaCuros = new List<int>(){1,2}
                },
                new Professor()
                {
                    Id = 3,
                    DataNasc = new DateTime(1995, 02, 20),
                    Email = "Professor3@gmail.com",
                    Telefone = "3333-3333",
                    AptoParaCuros = new List<int>(){3}
                }

            };
        }

        public static List<Turma> LoadTurmas()
        {
            return new List<Turma>()
            {
                new Turma()
                {
                    Id = 1,
                    Alunos = new List<int>(){1, 2, 3},
                    IdCurso = 1,
                    IdProfessor = 1,
                    nomeDaTurma = "Aceleração de C# Virtual"
                }
            };
        }
    }
}
