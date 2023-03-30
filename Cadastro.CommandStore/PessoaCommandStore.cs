using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.CommandStore
{
    public class PessoaCommandStore : IPessoaCommandStore
    {
        private readonly CadastroContext _cadastro;
        public PessoaCommandStore(CadastroContext cadastro) 
        {
            _cadastro = cadastro;
        }
        public void Cadastrar(string nome, int idade)
        {
            var pessoa = new Pessoa() { Nome = nome, Idade = idade };
            _cadastro.Pessoas.Add(pessoa);
            _cadastro.SaveChanges();
        }

        public void CadastrarAluno(string matricula, Pessoa pessoa)
        {
            Aluno aluno = new Aluno() {Matricula = matricula, Pessoa = pessoa};
            _cadastro.Alunos.Add(aluno);
            _cadastro.SaveChanges();
        }

        public Aluno GetAluno(int id)
        {
            return _cadastro.Alunos.Find(id);
        }

        public IEnumerable<Aluno> GetAlunos()
        {
            return _cadastro.Alunos.Include(e => e.Pessoa);
        }

        public Pessoa GetPessoa(int id)
        {
            return _cadastro.Pessoas.Find(id);
        }
    }
}
