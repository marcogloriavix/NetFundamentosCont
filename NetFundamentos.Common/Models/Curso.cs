using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetFundamentos.Common.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<PessoaSeg> Alunos { get; set; }

        public void AdicionarAluno (PessoaSeg aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunoMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        // public void RemoverAluno(PessoaSeg aluno)
        // {
        //     Alunos.Remove(aluno);
        // }

       public bool RemoverAluno(PessoaSeg aluno)
       {
          return Alunos.Remove(aluno);
       }

       public void ListarAlunos()
       {
        Console.WriteLine ($"Alunos do curso de : {Nome}");
        
        foreach (PessoaSeg aluno in Alunos)
        {
            Console.WriteLine(aluno.NomeCompleto);
        }
       }
    }
}