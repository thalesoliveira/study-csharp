using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambda.Modelos
{
    class Turma
    {

        public int Id { get; set; }
        public string nomeDaTurma { get; set; }
        public int IdCurso { get; set; }
        public int IdProfessor { get; set; }
        public List<int> Alunos { get; set; }
    }
}
