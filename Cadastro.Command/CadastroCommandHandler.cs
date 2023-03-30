using Cadastro.Command.Contracts;
using Cadastro.CommandStore;
using MediatR;

namespace Cadastro.Command
{
    public class CadastroCommandHandler : IRequestHandler<CadastrarCommand, string>
    {
        IPessoaCommandStore _store;
        public CadastroCommandHandler(IPessoaCommandStore store)
        {
            _store = store;
        }
        public Task<string> Handle(CadastrarCommand request, CancellationToken cancellationToken)
        {
            _store.Cadastrar(request.Nome,request.Idade);
            return Task.FromResult("Salvo com sucesso!");
        }
    }
}