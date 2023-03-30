using MediatR;

namespace Cadastro.Command.Contracts
{
    public class CadastrarCommand:IRequest<string>
    {
        public string Nome { get; set; } = "";
        public int Idade { get; set; }
    }
}
