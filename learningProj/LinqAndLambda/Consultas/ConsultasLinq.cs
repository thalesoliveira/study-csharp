using LinqAndLambda.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAndLambda.Consultas
{
    class ConsultasLinq
    {

        private List<Aluno> Alunos { get; set; }
        private List<Curso> Cursos { get; set; }
        private List<Professor> Professores { get; set; }
        private List<Turma> Turmas { get; set; }

        public ConsultasLinq()
        {
            Alunos = LoadDados.LoadAlunos();
            Cursos = LoadDados.LoadCursos();
            Professores = LoadDados.LoadProfessores();
            Turmas = LoadDados.LoadTurmas();
        }

        public List<String> SelecionaNomeDosAlunos()
        {
            return (from alunos in Alunos select alunos.Nome).ToList();
        }

        public List<string> SelecionaProfessorPorCurso(int idCurso)
        {
            return (from prof in Professores
                    where prof.AptoParaCuros.Contains(idCurso)
                    select prof.Nome)
                    .ToList();
        }

        public bool IsCursoExiste(string palavraChave)
        {
            return (from curso in Cursos
                    select curso)
                    .Any(x => x.Descricao.Contains(palavraChave));
        }

        public object SelecionaDadosTurma()
        {
            return (from turma in Turmas
                    join prof in Professores on turma.IdProfessor equals prof.Id
                    select new { Turma = turma, Prof = prof })
                    .ToList();
        }

    }
}
