using Cadastro.CommandStore;
using MediatR;

namespace Cadastro.Query
{
    public class RetornarAlunosQueryHandler : IRequestHandler<RetornarAlunosResponse, IEnumerable<RetornarAlunosResponse>>
    {
        private readonly IPessoaCommandStore _store;
        public RetornarAlunosQueryHandler(IPessoaCommandStore store)
        {
            _store = store;
        }
        public Task<IEnumerable<RetornarAlunosResponse>> Handle(RetornarAlunosResponse request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_store.GetAlunos().Select(x => 
            new RetornarAlunosResponse
            {
                Nome = x.Pessoa.Nome,
                Idade = x.Pessoa.Idade,
                Matricula = x.Matricula
            }));
        }
    }
}