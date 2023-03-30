using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Command.Contracts
{
    public class CadastrarAlunoCommand:IRequest<string>
    {
        public string Matricula { get; set; } = "";
        public int IdPessoa { get; set; }
    }
}
