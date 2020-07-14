using LinqAndLambda.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAndLambda.Consultas
{
    class ConsultasLambda
    {

        private List <Aluno> Alunos { get; set; }
        private List <Curso> Cursos { get; set; }
        private List <Professor> Professores { get; set; }
        private List <Turma> Turmas { get; set; }


        public ConsultasLambda()
        {
            Alunos = LoadDados.LoadAlunos();
            Cursos = LoadDados.LoadCursos();
            Professores = LoadDados.LoadProfessores();
            Turmas = LoadDados.LoadTurmas();
        }

        public List<String> SelecionaNomeDosAlunos()
        {
            return Alunos.Select(x => x.Nome).ToList();
        }

        public List<string> SelecionaProfessorPorCurso(int idCurso)
        {
            return Professores.Where(x => x.AptoParaCuros.Contains(idCurso)).Select(x => x.Nome).ToList();
        }

        public bool IsCursoExiste(string palavraChave)
        {
            return Cursos.Any(x => x.Descricao.Contains(palavraChave));
        }

        public object SelecionaDadosTurma()
        {
            return Turmas.Join(
                Professores,
                turma => turma.IdProfessor,
                prof => prof.Id,
                (turma, prof) => new { Turma = turma, Prof = prof });
        }

    }
}
