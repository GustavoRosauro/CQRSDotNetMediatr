using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.CommandStore
{
    public interface IPessoaCommandStore
    {
        public void Cadastrar(string nome, int idade);
        public void CadastrarAluno(string matricula, Pessoa pessoa);
        public Pessoa GetPessoa(int id);
        public Aluno GetAluno(int id);
        public IEnumerable<Aluno> GetAlunos();
    }
}
