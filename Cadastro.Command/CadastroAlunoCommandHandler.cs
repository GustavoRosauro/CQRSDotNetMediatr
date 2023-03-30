using Cadastro.Command.Contracts;
using Cadastro.CommandStore;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Command
{
    public class CadastroAlunoCommandHandler : IRequestHandler<CadastrarAlunoCommand, string>
    {
        private readonly IPessoaCommandStore _store;
        public CadastroAlunoCommandHandler(IPessoaCommandStore store)
        {
            _store = store;
        }
        public Task<string> Handle(CadastrarAlunoCommand request, CancellationToken cancellationToken)
        {
            var pessoa = _store.GetPessoa(request.IdPessoa);
            _store.CadastrarAluno(request.Matricula,pessoa);
            return Task.FromResult("Inserido com sucesso!");
        }
    }
}
