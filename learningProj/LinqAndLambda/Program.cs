using LinqAndLambda.Consultas;
using System;

namespace LinqAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultasLambda lambdas = new ConsultasLambda();
            ConsultasLinq linq = new ConsultasLinq();

            lambdas.SelecionaNomeDosAlunos().ForEach(x =>
            {
                Console.WriteLine($"Alunos por lambda: {x}");
            });

            linq.SelecionaNomeDosAlunos().ForEach(x =>
            {
                Console.WriteLine($"Alunos por linq: {x}");
            });

            lambdas.SelecionaProfessorPorCurso(1).ForEach(x =>
            {
                Console.WriteLine($"Professor por lambda: {x}");
            });

            linq.SelecionaProfessorPorCurso(1).ForEach(x =>
            {
                Console.WriteLine($"Professor por linq: {x}");
            });

            Console.WriteLine(lambdas.IsCursoExiste("Javascript"));
            Console.WriteLine(linq.IsCursoExiste("Javascript"));

            var turmasLambda = lambdas.SelecionaDadosTurma();
            var turmasLinq = linq.SelecionaDadosTurma();

        }
    }
}
